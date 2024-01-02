using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;
using System.Xml.Linq;

internal partial class Program
{
    internal static Dictionary<string, string> CharArrayTypes = new();
    internal static Dictionary<string, string> AliasTypes = new();
    internal static SortedSet<string> Enums = new();
    internal static SortedSet<string> Structs = new();
    private static void Main(string[] args)
    {
        var dir = typeof(Program).Assembly.Location!;
        dir = Path.GetDirectoryName(dir)!;
        var apiFolder = FindAPIFolder(dir);
        if (apiFolder == null)
        {
            Console.WriteLine("未能找到CTPAPI目录");
            return;
        }
        Console.WriteLine($"找到CTPAPI目录:{apiFolder}");
        var dataTypeFile = Path.Combine(apiFolder, "ThostFtdcUserApiDataType.h");
        if (!File.Exists(dataTypeFile)) 
        {
            Console.WriteLine("未能找到 ThostFtdcUserApiDataType.h");
            return;
        }
        var structFile = Path.Combine(apiFolder, "ThostFtdcUserApiStruct.h");
        if (!File.Exists(structFile))
        {
            Console.WriteLine("未能找到 ThostFtdcUserApiStruct.h");
            return;
        }
        var mdFile = Path.Combine(apiFolder, "ThostFtdcMdApi.h");
        if (!File.Exists(mdFile))
        {
            Console.WriteLine("未能找到 ThostFtdcMdApi.h");
            return;
        }
        var tdFile = Path.Combine(apiFolder, "ThostFtdcTraderApi.h");
        if (!File.Exists(tdFile))
        {
            Console.WriteLine("未能找到 ThostFtdcTraderApi.h");
            return;
        }
        var parentDir = Path.GetDirectoryName(apiFolder);
        var outDir = Path.Combine(parentDir!, "generated");
        if(!Directory.Exists(outDir))
        { 
            Directory.CreateDirectory(outDir);
        }
        // 拷贝输入的.h 文件到输出目录
        foreach(var f in Directory.EnumerateFiles(apiFolder, "*.h"))
        {
            var fileName = Path.Combine(outDir, Path.GetFileName(f));
            if (File.Exists(fileName)) File.Delete(fileName);
            File.Copy(f, fileName);
        }
        
        GenerateDataType(input: dataTypeFile, outDir: outDir);
        GenerateStructs(input: structFile, outDir: outDir);
        GenerateTradeApi(
            input: tdFile, 
            outCpp: "CTPTd.cpp",
            outDir: outDir);
        GenerateTradeApi(
            input: mdFile,
            outCpp: "CTPMd.cpp",
            outDir: outDir);
    }

    private static void GenerateStructs(string input, string outDir)
    {
        using var reader = new StreamReader(input);
        var content = reader.ReadToEnd();
        var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);

        var writer = new StreamWriter(Path.Combine(outDir, "ThostFtdcUserApiStruct.cs"));
        writer.WriteLine("//由 generator生成的文件，不要手工修改");
        writer.WriteLine();
        writer.WriteLine("using System.Runtime.InteropServices;");
        writer.WriteLine("namespace XP.CTPSharp;");

        var blockBegin = 0;
        var blockEnd = 0;
        
        for (var i = 0; i < lines.Length; i++)
        {
            var line = lines[i];
            var match = StuctDefRegex().Match(line);
            if (match.Success)
            {
                blockBegin = i;
                continue;
            }

            if(blockEnd < blockBegin && lines[i]=="};")
            {
                blockEnd = i;
                var block = new List<string>();
                for(var n=blockBegin -1; n < blockEnd; ++n)
                {
                    block.Add(lines[n].Trim(' ', '\t'));
                }
                blockBegin = blockEnd;
                HandleStructBlock(block, writer);
            }
        }

        writer.Flush();
    }

    private static void HandleStructBlock(List<string> block, StreamWriter writer)
    {
        var match = StuctDefRegex().Match(block[1]);
        var name = match.Groups[1].Value;
        var comment = block[0].Substring(3);
        writer.WriteLine("/// <summary>");
        writer.WriteLine($"/// {comment}");
        writer.WriteLine("/// </summary>");
        writer.WriteLine("[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]");
        writer.WriteLine($"public struct {name}");
        writer.WriteLine("{");
        writer.WriteLine($"    public {name}()" + " {}");
        if ("CThostFtdcRspInfoField" == name)
        {
            writer.WriteLine("    public bool NoError => ErrorID == 0;");
        }
        for (var i = 4; i < block.Count; ++i)
        {
            match = StuctFieldDefRegex().Match(block[i]);
            if (match.Success)
            {
                var fieldType = match.Groups[1].Value;
                var fieldName = match.Groups[2].Value;
                comment = block[i - 1].Substring(3);
                
                if (CharArrayTypes.TryGetValue(fieldType, out var attr))
                {
                    var mm = MarshalBytesRegex().Match(attr);
                    var size = mm.Groups[1].Value;
                    writer.WriteLine($"    {attr}");
                    writer.WriteLine($"    public readonly byte[] _{fieldName} = new byte[{size}];");
                    writer.WriteLine("    /// <summary>");
                    writer.WriteLine($"    /// {comment}");
                    writer.WriteLine("    /// </summary>");
                    writer.WriteLine($"    public string {fieldName}");
                    writer.WriteLine("    {");
                    writer.WriteLine($"        get{{ return GBKConvert.Instance.GetString(_{fieldName}); }}");
                    writer.WriteLine($"        set{{ GBKConvert.Instance.GetBytes(value, _{fieldName}); }}");
                    writer.WriteLine("    }");
                }
                else if (AliasTypes.TryGetValue(fieldType, out var alias))
                {
                    writer.WriteLine("    /// <summary>");
                    writer.WriteLine($"    /// {comment}");
                    writer.WriteLine("    /// </summary>");
                    writer.WriteLine($"    public {alias} {fieldName};");
                }
                else
                {
                    Debug.Assert(Enums.Contains(fieldType));
                    writer.WriteLine($"    public {fieldType} {fieldName};");
                }
            }
        }
        writer.WriteLine("}");
        Structs.Add(name);
    }

    private static void GenerateDataType(string input, string outDir)
    {
        using var reader = new StreamReader(input);
        var content = reader.ReadToEnd();
        var lines = content.Split(new char[] {'\r', '\n'}, StringSplitOptions.RemoveEmptyEntries);

        var writer = new StreamWriter(Path.Combine(outDir, "ThostFtdcUserApiDataType.cs"));
        writer.WriteLine("//由 generator生成的文件，不要手工修改");
        writer.WriteLine();
        writer.WriteLine("namespace XP.CTPSharp;");

        int lineNum = 0;

        // 跳过文件头
        for (var i=0; i<lines.Length; i++)
        {
            if (lines[i] == "#define THOST_FTDCDATATYPE_H")
            {
                lineNum = i;
                break;
            }
        }

        var blockBegin = lineNum;
        var blockEnd = lineNum;
        for (; lineNum< lines.Length; lineNum++)
        {
            var line = lines[lineNum];
            if (line.StartsWith("enum"))
            {
                blockBegin = lineNum;
                continue;
            }
            
            if (blockEnd < blockBegin) // blockBegin 已经找到
            {
                if (line.EndsWith("};") || line.StartsWith("typedef"))
                {
                    blockEnd = lineNum;
                    var block = new List<string>();
                    for (var i= blockBegin; i<= blockEnd; ++i)
                    {
                        block.Add(lines[i]);
                    }
                    blockBegin = blockEnd;
                    HandleDataTypeBlock(block, writer);
                }
            }
            else if (line.StartsWith("///"))
            {
                blockBegin = lineNum;
                continue;
            }
        }

        writer.Flush();

        AliasTypes["double"] = "double";
        AliasTypes["int"] = "int";
        AliasTypes["short"] = "int";
        AliasTypes["long"] = "int";
        AliasTypes["long long"] = "long";
    }

    private static void HandleDataTypeBlock(List<string> block, StreamWriter writer)
    {
        if (block[0].StartsWith("enum"))
        {
            writer.WriteLine($"public {block[0]}");
            writer.WriteLine("{");
            for (var i = 1; i < block.Count; ++i)
            {
                var line = block[i];
                if (line != "{" && line != "};")
                {
                    writer.WriteLine(block[i]);
                }
            }
            writer.WriteLine("}");
            writer.WriteLine();
        }
        else if (block.Find(x => x.StartsWith("#define")) != null)
        {
            var last = block.Last();
            var match = EnumCharTypedefRegex().Match(last);
            Debug.Assert(match.Success);
            var name = match.Groups[1].Value;
            Enums.Add(name);
            writer.WriteLine("/// <summary>");
            var comment = block[1].Substring(block[1].IndexOf("是一个") + 3);
            writer.WriteLine($"/// {comment}");
            writer.WriteLine("/// </summary>");
            writer.WriteLine($"public enum {name}: byte");
            writer.WriteLine("{");
            for (var i = 1; i<block.Count -1; ++i)
            {
                match = EnumCaseTypedefRegex().Match(block[i]);
                if (match.Success)
                {
                    var caseName = match.Groups[1].Value;
                    var caseValue = match.Groups[2].Value;
                    comment = block[i - 1];
                    Debug.Assert(comment.StartsWith("///"));
                    comment = comment.Substring(3);
                    writer.WriteLine( "    /// <summary>");
                    writer.WriteLine($"    /// {comment}");
                    writer.WriteLine( "    /// </summary>");
                    writer.WriteLine($"    {caseName} = (byte){caseValue},");
                }
            }
            writer.WriteLine("}");            
        } 
        else 
        {
            var match = EnumDoubleTypedefRegex().Match(block.Last());
            if (match.Success)
            {
                var def = match.Groups[1].Value;
                AliasTypes[def] = "double";
                return;
            }
            match = EnumIntTypedefRegex().Match(block.Last());
            if (match.Success)
            {
                var def = match.Groups[1].Value;
                AliasTypes[def] = "int";
                return;
            }
            match = EnumShortTypedefRegex().Match(block.Last());
            if (match.Success)
            {
                var def = match.Groups[1].Value;
                AliasTypes[def] = "short";
                return;
            }
            match = EnumCharTypedefRegex().Match(block.Last());
            if (match.Success)
            {
                var def = match.Groups[1].Value;
                AliasTypes[def] = "byte";
                return;
            }
            {
                match = CharArrayTypedefRegex().Match(block.Last());
                Debug.Assert(match.Success);
                var def = match.Groups[1].Value;
                var num = match.Groups[2].Value;
                CharArrayTypes[def] = $"[MarshalAs(UnmanagedType.ByValArray, SizeConst={num})]";
            }
        }
    }

    private static void GenerateTradeApi(
        string input, 
        string outCpp,
        string outDir)
    {
         using var reader = new StreamReader(input);
        var content = reader.ReadToEnd();
        var lines = content.Split(new char[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);


        var writer = new StreamWriter(Path.Combine(outDir, outCpp));        
        writer.WriteLine("//由 generator生成的文件，不要手工修改");
        writer.WriteLine();
        writer.WriteLine($"#include \"{Path.GetFileName(input)}\"");
        writer.WriteLine();
        writer.WriteLine(StdCallDef);
        writer.WriteLine();
        writer.WriteLine(ExportDef);
        writer.WriteLine();

        var classBegin = 0;
        var classEnd = 0;
        var blockSpi = new List<string>();
        var blockApi = new List<string>();
        for (var i=0; i<lines.Length; ++i)
        {
            if (lines[i].StartsWith("class"))
            {
                classBegin = i;
            }
            else if (lines[i] == "};")
            {
                classEnd = i;
                if (lines[classBegin].Contains("API_EXPORT"))
                {
                    for (var n = classBegin; n <= classEnd; ++n)
                    {
                        blockApi.Add(lines[n]);
                    }
                }
                else
                {
                    for (var n = classBegin; n <= classEnd; ++n)
                    {
                        blockSpi.Add(lines[n]);
                    }
                }
            }
        }
        var spiMethods = HandleSpi(blockSpi, writer, outDir);
        HandleApi(blockApi, writer, outDir, spiMethods);
        writer.WriteLine();
        writer.Flush();
    }

    private static List<MethodInfo> HandleSpi(List<string> block, StreamWriter writer, string outDir)
    {
        var match = ClassDefRegex().Match(block[0]);
        var className = match.Groups[1].Value;
        var methods = ParseMethods(block);

        // 创建一个新的 struct，其中放置 c 形式 callback
        var structName = $"CTPSharp_{className}";
        writer.WriteLine($"struct {structName}");
        writer.WriteLine("{");
        foreach (var m in methods)
        {
            writer.WriteLine($"    {FuncPtrDeclare(m)}");
        }
        writer.WriteLine("};");

        // 创建一个派生类来调用 
        var extClass = $"{className}_Ex";
        writer.WriteLine($"class {extClass}: public {className}");
        writer.WriteLine("{");
        writer.WriteLine($"    {structName} _callbacks;");
        writer.WriteLine("public:");
        writer.WriteLine($"    {extClass}(const {structName}* callbacks)" + "{ _callbacks = *callbacks; }");
        writer.WriteLine($"    virtual ~{extClass}()" + " {}");
        foreach (var m in methods)
        {
            writer.WriteLine(FuncCallback(m));
        }
        writer.WriteLine("};");

        // 创建 C 形式构建和删除函数
        writer.WriteLine("extern \"C\"");
        writer.WriteLine($"CTPSHARP_EXPORT void* CTPSHARP_STDCALL {className}_New(const {structName}* callbacks)");
        writer.WriteLine("{");
        writer.WriteLine($"    return new {extClass}(callbacks);");
        writer.WriteLine("}");
        writer.WriteLine("extern \"C\"");
        writer.WriteLine($"CTPSHARP_EXPORT void CTPSHARP_STDCALL {className}_Delete(void* spi)");
        writer.WriteLine("{");
        writer.WriteLine($"    delete ({extClass}*)spi;");
        writer.WriteLine("}");

        GenerateManagedSpi(outDir, className, methods, structName);

        return methods;
    }

    private static void GenerateManagedSpi(string outDir, string className, 
        List<MethodInfo> methods, string structName)
    {
        // cs文件
        var pinvokeFile = Path.Combine(outDir, $"PInvoke{className}.cs");
        using var writer = new StreamWriter(pinvokeFile);
        writer.WriteLine("using System.Runtime.InteropServices;");
        writer.WriteLine("namespace XP.CTPSharp;");
        writer.WriteLine("");
        // 创建 callback cs结构
        writer.WriteLine("[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]");
        writer.WriteLine($"internal struct {structName}");
        writer.WriteLine("{");
        foreach (var m in methods)
        {
            writer.WriteLine(ManagedFuncDeclare(m));
        }
        writer.WriteLine("}");
        // 创建 PInvoke方法        
        writer.WriteLine("internal partial class CTPSharpPInvoke");
        writer.WriteLine("{");
        writer.WriteLine($"    [DllImport(\"CTPInvoke\", EntryPoint=\"{className}_New\", CharSet=CharSet.Ansi)]");
        writer.WriteLine($"   public extern static IntPtr {className}_New(ref {structName} callback);");
        writer.WriteLine("");
        writer.WriteLine($"    [DllImport(\"CTPInvoke\", EntryPoint=\"{className}_Delete\", CharSet=CharSet.Ansi)]");
        writer.WriteLine($"   public extern static void {className}_Delete(IntPtr spi);");
        writer.WriteLine("}");
        // 创建 SPI class
        writer.WriteLine($"public class {className}: IDisposable");
        writer.WriteLine("{");
        writer.WriteLine($"    {structName} _spi = new();");
        writer.WriteLine("    IntPtr _handle;");
        writer.WriteLine("    internal IntPtr Handle => _handle;");
        writer.WriteLine($"    public {className}()");
        writer.WriteLine("    {");
        foreach (var m in methods)
        {
            writer.WriteLine($"        _spi.{m.Name} = this.{m.Name};");
        }
        writer.WriteLine($"        _handle = CTPSharpPInvoke.{className}_New(ref _spi);");
        writer.WriteLine("    }");
        foreach (var m in methods)
        {
            writer.WriteLine(ManagedFuncEmpty(m));
        }
        writer.WriteLine("    private void Close()");
        writer.WriteLine("    {");
        writer.WriteLine($"        CTPSharpPInvoke.{className}_Delete(_handle);");
        writer.WriteLine("        _handle = 0;");
        writer.WriteLine("    }");
        writer.WriteLine(DisposingTemplate);
        writer.WriteLine("}");
        writer.Flush();

        GenerateAsyncSPI(outDir, className, methods);
    }

    const string DisposingTemplate = """
        private bool disposedValue = false;
        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    Close();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }

        """;

    private static void GenerateAsyncSPI(string outDir, string className,
        List<MethodInfo> methods)
    {
        if (className == "CThostFtdcMdSpi") return; //只生成TdSPI, MdSPI手写即可
        // 分类函数，区分主动上报和请求应答
        var listEvents = new List<MethodInfo>();
        var listResp =  new List<MethodInfo>();
        foreach(var m in methods)
        {
            if(m.Name.StartsWith("OnRsp"))
                listResp.Add(m);
            else
                listEvents.Add(m);
        }
        // 创建 cs文件
        var fileName = Path.Combine(outDir, $"{className}_gen.cs");
        using var writer = new StreamWriter(fileName);
        writer.WriteLine("using System.Diagnostics;");
        writer.WriteLine("namespace XP.CTPSharp;");
        writer.WriteLine($"internal partial class TdSPI");
        writer.WriteLine("{");
        foreach(var m in listEvents)
        {
            writer.WriteLine(EventDeclare(m, isPublic: false));
        }
        foreach (var m in listEvents)
        {
            writer.WriteLine($"    public sealed override void {m.Name}({ManagedParamDeclare(m)})");
            writer.WriteLine("    {");
            if (m.Params.Count == 0)
            {
                writer.WriteLine($"        {m.Name[2..]}?.Invoke();");
            }
            else if (m.Params.Count == 1)
            { 
                writer.WriteLine($"        {m.Name[2..]}?.Invoke({m.Params[0].Name});");
            }
            else
            {
                var p = m.Params[0];
                var eventParm = $"ErrorReturn<{p.CType.ManagedDeclare(asParam: false)}>";
                writer.WriteLine($"        {m.Name[2..]}?.Invoke(new {eventParm}({p.Name}, {m.Params[1].Name}));");
            }
            writer.WriteLine("    }");
        }

        foreach(var m in listResp)
        {
            Debug.Assert(m.Params.Count == 4 || m.Name == "OnRspError");
            if (m.Name == "OnRspError") continue; // 错误应答不知如何处理，忽略掉
            writer.WriteLine($"    public sealed override void {m.Name}({ManagedParamDeclare(m)})");
            writer.WriteLine("    {");
            writer.WriteLine($"        CompleteListPending({m.Params[0].Name},{m.Params[1].Name},{m.Params[2].Name},{m.Params[3].Name});");
            writer.WriteLine("    }");
        }
            
        writer.WriteLine("}");
        writer.Flush();
    }

    private static string EventDeclare(MethodInfo m, bool isPublic)
    {
        Debug.Assert(m.Name.StartsWith("On"));
        var access = isPublic ? "public" : "internal";
        if (m.Params.Count == 0)
        {            
            return $"    {access} event Action? {m.Name[2..]};";
        }
        else if(m.Params.Count == 1)
        {
            var p = m.Params[0];
            return $"    {access} event Action<{p.CType.ManagedDeclare(asParam: false)}>? {m.Name[2..]};";
        }
        else
        {
            Debug.Assert(m.Params.Count == 2 && m.Params[1].CType.Name == "CThostFtdcRspInfoField");
            var p = m.Params[0];
            var eventParm = $"ErrorReturn<{p.CType.ManagedDeclare(asParam: false)}>";
            return $"    {access} event Action<{eventParm}>? {m.Name[2..]};";
        }
    }

    private static string ManagedFuncDeclare(MethodInfo m)
    {
        var builder = new StringBuilder();
        builder.AppendLine($"    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]");
        builder.AppendLine($"    internal delegate {m.Return.CType.ManagedDeclare(asParam:false)} Del{m.Name}({ManagedParamDeclare(m)});");
        builder.AppendLine($"    internal Del{m.Name} {m.Name};");
        return builder.ToString();
    }

    private static string ManagedFuncEmpty(MethodInfo m)
    {
        var builder = new StringBuilder();
        if (!string.IsNullOrEmpty(m.Comment))
        {
            builder.AppendLine("    /// <summary>");
            builder.AppendLine($"    /// {m.Comment}");
            builder.AppendLine("    /// </summary>");
            foreach (var p in m.Params)
            {
                if (!string.IsNullOrEmpty(p.Comment))
                {
                    builder.AppendLine($"    /// <param name=\"{p.Name}\">{p.Comment}</param>");
                }
            }            
        }
        builder.AppendLine($"    public virtual {m.Return.CType.ManagedDeclare(asParam: false)} {m.Name}({ManagedParamDeclare(m)})" + "{}");
        return builder.ToString();
    }

    private static string ManagedParamDeclare(MethodInfo m)
    {
        var builder = new StringBuilder();
        foreach (var p in m.Params)
        {
            builder.Append(p.ManagedDeclare);
        }
        var parm = builder.ToString().Trim(',');
        return parm;
    }

    private static string ManagedParamDeclareNoAttr(MethodInfo m)
    {
        var builder = new StringBuilder();
        foreach (var p in m.Params)
        {
            builder.Append(p.ManagedDeclare);
        }
        var parm = builder.ToString().Trim(',');
        return parm;
    }

    private static string FuncCallback(MethodInfo m)
    {
        Debug.Assert(m.IsVirtual);
        var builder = new StringBuilder();
        builder.AppendLine($"    virtual {m.Return.CDeclare} {m.Name}({ParamDeclare(m)})");
        builder.AppendLine( "    {");
        var pRspInfo = m.Params.Find(x => x.CType.Name == "CThostFtdcRspInfoField");

        if (m.Params.Count >= 1)
        {
            for (var i = 0; i < m.Params.Count; ++i)
            {
                var parm = m.Params[i];
                if (Structs.Contains(parm.CType.Name) && (parm.CType.Pointer == "*"))
                {
                    builder.AppendLine($"        //{parm.Name} 回调 C# 参数 不能为 NULL");
                    builder.AppendLine($"        {parm.CType.Name} zero{i} = " + "{0};");
                    builder.AppendLine($"        if (!{parm.Name}) {parm.Name} = &zero{i};");
                }
            }
        }
        builder.AppendLine($"        _callbacks.{m.Name}({ParamCall(m)});");
        builder.AppendLine( "    }");
        return builder.ToString();
    }

    private static string FuncPtrDeclare(MethodInfo m)
    {
        string parm = ParamDeclare(m);
        return $"{m.Return.CDeclare} (CTPSHARP_STDCALL *{m.Name})({parm});";
    }

    private static string ParamCall(MethodInfo m)
    {
        var builder = new StringBuilder();
        foreach (var p in m.Params)
        {
            builder.Append($"{p.Name},");
        }
        var parm = builder.ToString().Trim(',');
        return parm;
    }

    private static string ParamCallManaged(MethodInfo m)
    {
        var builder = new StringBuilder();
        foreach (var p in m.Params)
        {
            builder.Append(p.ManagedFill);
        }
        var parm = builder.ToString().Trim(',');
        return parm;
    }

    private static string ParamDeclare(MethodInfo m)
    {
        var builder = new StringBuilder();
        foreach (var p in m.Params)
        {
            builder.Append($"{p.CDeclare},");
        }
        var parm = builder.ToString().Trim(',');
        return parm;
    }

    private static List<MethodInfo> ParseMethods(List<string> block)
    {
        List<MethodInfo> methods = new();
        for (var i = 2; i < block.Count; ++i)
        {
            var line = block[i].Trim('\t', ' ');
            if (line.Length == 0 || line == "public:" || line == "protected:") continue;
            if (line.StartsWith("virtual") || line.StartsWith("static"))
            {
                var a = line.IndexOf('(');
                var b = line.IndexOf(")");
                var declare = line[..a].Trim();
                var isConst = declare.Contains("const");
                if (isConst) declare = declare.Replace("const", "");
                var match = VirtualFunctionDefRegex().Match(declare);
                if (!match.Success) match = StaticFunctionDefRegex().Match(declare);
                var ret = match.Groups[1].Value;
                var retStar = match.Groups[2].Value;
                var name = match.Groups[3].Value;
                var pars = line.Substring(a + 1, b - a - 1);

                var cType = new CType { IsConst=isConst, Name=ret, Pointer = retStar };
                var method = new MethodInfo(name, new ReturnInfo { CType = cType })
                {
                    IsVirtual = line.Contains("virtual"),
                    IsStatic = line.Contains("static"),
                };
                methods.Add(method);
                if (!string.IsNullOrEmpty(pars))
                {
                    method.Params.AddRange(ParseParams(pars));
                }
                var commentBegin = i;
                var commentEnd = i;
                for(var j=i-1; j>=0; --j)
                {
                    if (block[j].Contains("///"))
                    {
                        commentBegin = j;
                    }
                    else
                    {
                        break;
                    }
                }
                var comments = new List<string>();
                for(var j= commentBegin; j< commentEnd; ++j)
                {
                    comments.Add(block[j].Trim(' ', '\t'));
                }
                if(comments.Count >0)
                {
                    ParseComments(comments, method);
                }
            }
            else
            {
                Debug.Assert(line.StartsWith("//") || line=="};" || line.StartsWith("~"));
            }
        }

        return methods;
    }

    private static void ParseComments(List<string> comments, MethodInfo method)
    {
        method.Comment = comments[0].Replace("///", "");
        foreach(var c in comments)
        {
            if (c.Contains("@param"))
            {
                var match = ParamCommentRegex().Match(c);
                Debug.Assert(match.Success);
                var paramName = match.Groups[1].Value;
                var param = method.Params.Find(x => x.Name == paramName);
                if(param != null)
                {
                    var content = c.Substring(match.Groups[0].Value.Length).Trim(':', ' ', '：');
                    param.Comment= content;
                }
            }
        }
    }

    private static List<ParamInfo> ParseParams(string pars)
    {
        var result = new List<ParamInfo>();
        var items= pars.Split(',', StringSplitOptions.RemoveEmptyEntries);
        foreach(var item in items)
        {
            var v = item.Trim();
            var splitted = v.Split('=', StringSplitOptions.RemoveEmptyEntries);
            v = splitted[0].Trim();
            var isConst = v.Contains("const");
            if (isConst) v = v.Replace("const", "");
            var match = ParamDefRegex().Match(v);
            Debug.Assert(match.Success);
            var cType = new CType
            {
                IsConst = isConst,
                Name = match.Groups[1].Value,
                Pointer= match.Groups[2].Value,
            };
            Debug.Assert(match.Groups.Count == 5);
            if (match.Groups[4].Value == "[]")
            {
                cType.Pointer += "*";
            }
            var param = new ParamInfo
            {
                CType= cType,
                Name = match.Groups[3].Value
            };
            if (splitted.Length > 1)
            {
                param.DefaultValue= splitted[1].Trim();
            }
            result.Add(param);
        }
        return result;
    }

    private static void HandleApi(List<string> block, StreamWriter writer, string outDir, List<MethodInfo> spiMethods)
    {
        var match = ExportClassDefRegex().Match(block[0]);
        var className = match.Groups[1].Value;
        var methods = ParseMethods(block);

        // 创建 PInvoke C 形式导出函数
        ExportApi(writer, className, methods);
        GenerateManagedApi(className, methods, outDir, spiMethods);
    }

    private static void GenerateManagedApi(string className, 
        List<MethodInfo> methods, 
        string outDir, List<MethodInfo> spiMethods)
    {
        // 创建PInvoke cs文件
        var pinvokeFile = Path.Combine(outDir, $"PInvoke{className}.cs");
        using var writer = new StreamWriter(pinvokeFile);
        writer.WriteLine("using System.Runtime.InteropServices;");
        writer.WriteLine("namespace XP.CTPSharp;");
        writer.WriteLine("");
        // 创建 PInvoke方法        
        writer.WriteLine("internal partial class CTPSharpPInvoke");
        writer.WriteLine("{");
        foreach(var m in methods)
        {
            var exportFuncName = $"{className}_{m.Name}";
            if (m.Name.StartsWith("Create") && m.Name.EndsWith("Api"))
            {
                exportFuncName = $"{className}_Create";
            }
            writer.WriteLine($"    [DllImport(\"CTPInvoke\", EntryPoint=\"{exportFuncName}\", CharSet=CharSet.Ansi)]");
            writer.WriteLine($"{ManagedDeclare(m, className, exportFuncName)}");
        }
        writer.WriteLine("}");

        // 创建 API class
        writer.WriteLine($"public sealed class {className}");
        writer.WriteLine("{");
        writer.WriteLine("    IntPtr _handle;");
        writer.WriteLine($"    public {className}(string flowPath)");
        writer.WriteLine("    {");
        writer.WriteLine($"        _handle = CTPSharpPInvoke.{className}_Create(flowPath);");
        writer.WriteLine("    }");

        foreach(var m in methods)
        {
            writer.WriteLine($"{ManagedFuncCall(m, className)}");
        }

        writer.WriteLine("    public void Dispose()");
        writer.WriteLine("    {");
        writer.WriteLine("        if (_handle == 0) return;");
        writer.WriteLine($"        CTPSharpPInvoke.{className}_Release(_handle);");
        writer.WriteLine($"        //CTPSharpPInvoke.{className}_Join(_handle);");
        writer.WriteLine("        _handle = 0;");
        writer.WriteLine("    }");
        writer.WriteLine("}");
        writer.Flush();

        GenerateManagedAsyncApi(className, methods, outDir, spiMethods);
    }

    private static void GenerateManagedAsyncApi(
        string className, List<MethodInfo> methods, string outDir, 
        List<MethodInfo> spiMethods)
    {
        if (className != "CThostFtdcTraderApi") return;
        // 分类函数，区分主动上报和请求应答
        var listEvents = new List<MethodInfo>();
        var listResp = new List<MethodInfo>();
        foreach (var m in spiMethods)
        {
            if (m.Name.StartsWith("OnRsp"))
                listResp.Add(m);
            else
                listEvents.Add(m);
        }

        var fileName = Path.Combine(outDir, $"{className}_gen.cs");
        var reqMethods = methods.Where(x => x.Name.StartsWith("Req")).ToList();
        using var writer = new StreamWriter(fileName);
        writer.WriteLine("using System.Diagnostics;");
        writer.WriteLine("namespace XP.CTPSharp;");
        writer.WriteLine("");              
        writer.WriteLine("public partial class TdAPI");
        writer.WriteLine("{");
        foreach (var m in listEvents)
        {
            if (!string.IsNullOrEmpty(m.Comment))
            {
                writer.WriteLine("    /// <summary>");
                writer.WriteLine($"    /// {m.Comment}");
                writer.WriteLine("    /// </summary>");
            }
            writer.WriteLine(EventDeclare(m, isPublic: true));
        }
        writer.WriteLine("");
        writer.WriteLine("    private void SubscribeSPI()");
        writer.WriteLine("    {");
        foreach(var m in listEvents)
        {
            var eventName = m.Name[2..];
            if (m.Params.Count == 0)
            {                
                writer.WriteLine($"        _spi.{eventName} += () => {eventName}?.Invoke();");
            }
            else if (m.Params.Count == 1)
            {
                writer.WriteLine($"        _spi.{eventName} += (_1) => {eventName}?.Invoke(_1);");
            }
            else if (m.Params.Count == 2)
            {
                writer.WriteLine($"        _spi.{eventName} += (_1) => {eventName}?.Invoke(_1);");
            }
            else
            {
                Debug.Assert(false);
            }
        }
        writer.WriteLine("    }");
        writer.WriteLine("");
        foreach (var m in reqMethods)
        {
            var respFile = FindRspParamType(m, listResp);
            writer.WriteLine("");
            if (!string.IsNullOrEmpty(m.Comment))
            {
                writer.WriteLine("    /// <summary>");
                writer.WriteLine($"    /// {m.Comment}");
                writer.WriteLine("    /// </summary>");
                var p = m.Params[0];
                if (!string.IsNullOrEmpty(p.Comment))
                {
                    writer.WriteLine($"    /// <param name=\"{p.Name}\">{p.Comment}</param>");
                }
            }
            writer.WriteLine($"    public async Task<CTPResponse<List<{respFile}>>>");
            writer.WriteLine($"    {m.Name}Async({m.Params[0].CType.Name} {m.Params[0].Name})");
            writer.WriteLine("    {");
            writer.WriteLine($"        var pending = new PendingRequest<List<{respFile}>> (_requestId.Next());");
            writer.WriteLine("        _spi.CachePendingRequest(pending);");
            writer.WriteLine($"        while (_api.{m.Name}(ref {m.Params[0].Name}, pending.RequestId) != 0) await Task.Delay(1000);");
            writer.WriteLine("        return await pending.Task.ConfigureAwait(false);");
            writer.WriteLine("    }");
        }
        writer.WriteLine("}");
    }

    private static string FindRspParamType(MethodInfo apiMethod, List<MethodInfo> spiMthods)
    {
        var name = apiMethod.Name.Replace("Req", "");
        if (name.Contains("UserLogin")) return "CThostFtdcRspUserLoginField";
        var m = spiMthods.First(x => x.Name.EndsWith(name));
        return m.Params[0].CType.ManagedDeclare(asParam: false);
    }

    private static string ManagedFuncCall(MethodInfo m, string className)
    {
        if (m.Name.StartsWith("Create") && m.Name.EndsWith("Api")) return "";

        var builder = new StringBuilder();
        if (!string.IsNullOrEmpty(m.Comment))
        {
            builder.AppendLine("    /// <summary>");
            builder.AppendLine($"    /// {m.Comment}");
            builder.AppendLine("    /// </summary>");
            foreach (var p in m.Params)
            {
                if (!string.IsNullOrEmpty(p.Comment))
                {
                    builder.AppendLine($"    /// <param name=\"{p.Name}\">{p.Comment}</param>");
                }
            }
        }
        builder.AppendLine($"    public {m.Return.ManagedDeclare} {m.Name}({ManagedParamDeclareNoAttr(m)})");
        builder.AppendLine("    {");

        var pinvokeFunc = $"CTPSharpPInvoke.{className}_{m.Name}";
        if (m.Return.IsVoid)
        {                       
            if  (m.IsStatic)
            {
                builder.AppendLine($"        {pinvokeFunc}({ParamCallManaged(m)});");
            }
            else
            {
                var fillParam = m.Params.Count == 0 ? "" : $", {ParamCallManaged(m)}";
                builder.AppendLine($"        {pinvokeFunc}(_handle{fillParam});");
            }
        }
        else
        {
            if (m.IsStatic)
            {
                var call = $"{pinvokeFunc}({ParamCallManaged(m)})";
                if (m.Return.IsString)
                    builder.AppendLine($"        return GBKConvert.Instance.GetString({call});");
                else
                    builder.AppendLine($"        return {call};");
            }
            else
            {
                var fillParam = m.Params.Count == 0 ? "" : $", {ParamCallManaged(m)}";
                var call = $"{pinvokeFunc}(_handle{fillParam})";
                if (m.Return.IsString)
                    builder.AppendLine($"        return GBKConvert.Instance.GetString({call});");
                else
                    builder.AppendLine($"        return {call};");
            }
        }
        builder.AppendLine("    }");
        return builder.ToString();
    }

    internal static string ManagedDeclare(MethodInfo m, string className, string exportFuncName)
    {
        var builder = new StringBuilder();
        if (m.IsStatic)
        {
            builder.AppendLine($"   public extern static {m.Return.CType.ManagedDeclare(asParam: false)} {exportFuncName}({ManagedParamDeclare(m)});");
        }
        else
        {
            if (m.Params.Count == 0)
                builder.AppendLine($"   public extern static {m.Return.CType.ManagedDeclare(asParam: false)} {exportFuncName}(IntPtr handle);");
            else
                builder.AppendLine($"   public extern static {m.Return.CType.ManagedDeclare(asParam: false)} {exportFuncName}(IntPtr handle, {ManagedParamDeclare(m)});");
        }
        return builder.ToString();
    }


    private static void ExportApi(StreamWriter writer, string className, List<MethodInfo> methods)
    {
        foreach (var m in methods)
        {
            var exportFuncName = $"{className}_{m.Name}";
            if (m.Name.StartsWith("Create") && m.Name.EndsWith("Api"))
            {
                exportFuncName = $"{className}_Create";
            }
            if (m.IsStatic)
            {
                writer.WriteLine("extern \"C\"");
                writer.WriteLine($"CTPSHARP_EXPORT {m.Return.CDeclare} CTPSHARP_STDCALL {exportFuncName}({ParamDeclare(m)})");
                writer.WriteLine("{");
                if (m.Return.IsVoid)
                {
                    writer.WriteLine($"    {className}::{m.Name}({ParamCall(m)});");
                }
                else
                {
                    writer.WriteLine($"    return {className}::{m.Name}({ParamCall(m)});");
                }
                writer.WriteLine("}");
            }
            else
            {
                if (m.Params.Count == 0)
                {
                    writer.WriteLine("extern \"C\"");
                    writer.WriteLine($"CTPSHARP_EXPORT {m.Return.CDeclare} CTPSHARP_STDCALL {exportFuncName}({className}* api)");
                }
                else
                {
                    writer.WriteLine("extern \"C\"");
                    writer.WriteLine($"CTPSHARP_EXPORT {m.Return.CDeclare} CTPSHARP_STDCALL {exportFuncName}({className} * api,{ParamDeclare(m)})");
                }
                writer.WriteLine("{");
                if (m.Return.IsVoid)
                {
                    writer.WriteLine($"    api->{m.Name}({ParamCall(m)});");
                }
                else
                {
                    writer.WriteLine($"    return api->{m.Name}({ParamCall(m)});");
                }
                writer.WriteLine("}");
            }
        }
    }

    private static string? FindAPIFolder(string path)
    {
        foreach (var dir in Directory.EnumerateDirectories(path))
        {
            var dirName = Path.GetFileName(dir.Trim(Path.DirectorySeparatorChar));
            if (dirName.ToUpper().StartsWith("CTPAPI"))
            {
                var file = Path.Combine(path, dirName, "ThostFtdcTraderApi.h");
                if (File.Exists(file))
                    return dir;
            }
        }

        var parent = Path.GetDirectoryName(path);
        if (parent == null || parent.Length <= 1) return null;
        return FindAPIFolder(parent);
    }

    [GeneratedRegex(@"typedef char (\w+)\[(\d+)\];")]
    private static partial Regex CharArrayTypedefRegex();

    [GeneratedRegex(@"typedef char (\w+);")]
    private static partial Regex EnumCharTypedefRegex();

    [GeneratedRegex(@"typedef int (\w+);")]
    private static partial Regex EnumIntTypedefRegex();

    [GeneratedRegex(@"typedef double (\w+);")]
    private static partial Regex EnumDoubleTypedefRegex();

    [GeneratedRegex(@"typedef short (\w+);")]
    private static partial Regex EnumShortTypedefRegex();

    [GeneratedRegex(@"#define ([\w|_]+) ('[\w|\d]')")]
    private static partial Regex EnumCaseTypedefRegex();

    [GeneratedRegex(@"^struct ([\w|_]+)$")]
    private static partial Regex StuctDefRegex();

    [GeneratedRegex(@"([\w|_]+)\s+([\w|_]+);")]
    private static partial Regex StuctFieldDefRegex();

    [GeneratedRegex(@"^class ([\w|_]+)$")]
    private static partial Regex ClassDefRegex();

    [GeneratedRegex(@"^class \w+_API_EXPORT ([\w|_]+)$")]
    private static partial Regex ExportClassDefRegex();

    [GeneratedRegex(@"virtual\s+([\w|_]+)\s*([\*]*)\s*([\w|_]+)")]
    private static partial Regex VirtualFunctionDefRegex();

    [GeneratedRegex(@"static\s+([\w|_]+)\s*([\*]*)\s*([\w|_]+)")]
    private static partial Regex StaticFunctionDefRegex();

    [GeneratedRegex(@"([\w|_]+)\s*([\*]*)\s*([\w|_]+)([\[\]]*)")]
    private static partial Regex ParamDefRegex();

    [GeneratedRegex(@"///@param\s+([\w\d_]+)")]
    private static partial Regex ParamCommentRegex();

    [GeneratedRegex(@"SizeConst=(\d+)")]
    private static partial Regex MarshalBytesRegex();

    const string ExportDef = """
        #ifndef CTPSHARP_EXPORT
        # if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
        #   if defined(STATIC_LINKED)
        #     define CTPSHARP_EXPORT
        #   else
        #     define CTPSHARP_EXPORT __declspec(dllexport)
        #   endif
        # else
        #   if defined(__GNUC__) && defined(GCC_HASCLASSVISIBILITY)
        #     define CTPSHARP_EXPORT __attribute__ ((visibility("default")))
        #   else
        #     define CTPSHARP_EXPORT
        #   endif
        # endif
        #endif
        """;

    const string StdCallDef = """
        #ifndef CTPSHARP_STDCALL
        # if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
        #   define CTPSHARP_STDCALL __stdcall
        # else
        #   define CTPSHARP_STDCALL
        # endif
        #endif
        """;
}

class MethodInfo
{
    public string Name;
    public string Comment = string.Empty;
    public ReturnInfo Return;
    public bool IsStatic = false;
    public bool IsVirtual = true;
    public List<ParamInfo> Params = new();

    public MethodInfo(string name, ReturnInfo @return)
    {
        Name = name;
        Return = @return;
    }
}

class ReturnInfo
{
    public CType CType = new();
    public string Comment = string.Empty;

    public string CDeclare => CType.CDeclare;
    public string ManagedDeclare => IsString ? "string" : CType.ManagedDeclare(asParam: false);
    public bool IsVoid => CType.IsVoid;
    public bool IsString => CType.CDeclare == "const char*";
}

class ParamInfo
{
    public CType CType;
    public string Name = string.Empty;
    public string Comment = string.Empty;
    public string DefaultValue = string.Empty;

    public string CDeclare => $"{CType.CDeclare} {Name}";    

    public string ManagedFill
    {
        get
        {
            if (Program.CharArrayTypes.TryGetValue(CType.Name, out var attr))
            {
               return $"{Name},";
            }
            if (CType.Name == "char" && CType.Pointer == "*")
            {
                return $"{Name},";
            }
            if (CType.Pointer == "*" && CType.ManagedDeclare(asParam:true) != "IntPtr")
            {
                return $"ref {Name},";
            }

            return $"{Name},";
        }
    }

    public string CFill => $"{Name},";

    public string ManagedDeclare
    {
        get
        {
            if (string.IsNullOrEmpty(DefaultValue))
            {
                return $"{CType.ManagedDeclare(asParam:true)} {Name},";
            }
            return $"{CType.ManagedDeclare(asParam: true)} {Name}={DefaultValue},";
        }
    }
    public bool IsVoid => CType.IsVoid;
}

struct CType
{
    public bool IsConst;
    public string Name;
    public string Pointer;

    public bool IsVoid => Name == "void";

    public string CDeclare
    {
        get
        {
            var ss = IsConst ? "const " : "";

            return $"{ss}{Name}{Pointer}";
        }
    }

    public string ManagedDeclare(bool asParam)
    {
        if (Name == "void") return "void";
        if (Pointer == "**") return "IntPtr";
        if (Name == "char" && Pointer == "*")
        {
            return asParam ? "[MarshalAs(UnmanagedType.LPStr)] string" : "IntPtr";
        }
        if (Program.AliasTypes.TryGetValue(Name, out var alias))
        {
            return alias;
        }
        if (Program.CharArrayTypes.TryGetValue(Name, out var attr))
        {
            return $"{attr}string";
        }
        if (Pointer == "*")
        {
            if (Program.Structs.Contains(Name)) return asParam ? $"ref {Name}" : Name;
            return "IntPtr";
        }
        return Name;
    }
}