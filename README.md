# CTPSharp
期货CTP接口API的C#绑定，基于代码生成的Window X64版本。
当前CTP版本为6.6.9

相较于其他一些封装库，本项目有以下优势：
* 完全的原始SDK命名兼容
* 增加了对原始callback形式的API的C#封装，可使用 Task和 event
* 字符串使用GBK编码与SDK沟通，没有乱码
* 最大限度避免了PInvoke调用过程中的内存问题

# 特别声明
此项目代码不得用于任何商业目的，若需要，请和我联系: 929968367@qq.com

## 项目结构：

### CTPAPI6.6.9 目录
此目录为原始 X64 C++ API，含动态库 .dll 和 连接库 .lib


### Generator 目录
此项目为代码生成工具，用于将【CTPAPI6.6.9】目录下的 .h文件分析后转换成CTPInvoke所需的CPP代码以及CTPSharp项目所需的C#代码。

得益于CTP SDK头文件的良好格式化，此工具不做任何词法语法分析，仅做字符串解析。

输出文件存放在 【CTPAPI6.6.9/generated】目录下

后续CTP SDK 版本更新，可直接放在【CTPAPIX.X.X】平行的目录下，重新生成

### CTPInvoke 目录
此目录为 C# 代码需要调用的 PInvoke库， 其输出文件名需要是 CTPInvoke.dll(Linux下则需要命名为.so)
此项目的源代码为 generated 目录下的生成的 .cpp文件. 链接库需要加入 CTPAPI6.6.9 中的两个 .lib。 

### CTPSharp
此目录为可被 .NET 程序引用的动态库项目。其源码是 generated 目录下的全部 .cs文件
此项目为纯 .NET 项目，生成一个 CTPSharp.dll

## 客户.NET代码引用此绑定库的方法
1. 拷贝CTPInvoke.dll、CTPSharp.dll和CTPAPI6.6.9 目录下的两个原始 _se.dll
2. 客户.NET 项目添加对 CTPSharp.dll的引用
3. 可完全参照原始 C++ API来使用CTPSharp.dll，所有类、方法的名称都和 C++ 版本保持一致
4. 也可选择使用封装的两个类：XP.CTPSharp.TdAPI和XP.CTPSharp.MdAPI
5. 注意使用 IDisposable 来管理对象生命周期

## Linux版本
目前不支持，但实际操作是完全类似的.
1. 将生成的 generated 目录下的那几个 .h 和 .cpp 文件编译成 CTPInvoke.so
2. CTPSharp.dll本身可以跨平台使用
3. 原始 CTP API 动态库使用官方的 Linux 版本的 .so 文件

## 预制版本
如果不想编译，可以直接使用publish目录下的预制版本.
当前CTPInvoke及两个原生dll为 X64架构，CTPSharp.dll目标平台为 .NET 7

## 使用代码样例
```
class MDClient: IDisposable
{
    private MdAPI _api;
    private Config _config;
    public MDClient(string flowPath, Config config)
    {
        _config = config;
        _api = new(flowPath);
        _api.FrontConnected += OnFrontConnected;
        _api.FrontDisconnected += OnFrontDisconnected;
        _api.DepthMarketDataArrived += OnDepthMarketData;
        _api.RegisterFront(_config.DataServer);
         // 连接行情服务器;
        _api.Init();
    }

    public void Dispose()
    {
        _api.Dispose();
    }

    private void OnFrontConnected()
    {
        LogDebug("服务器连接成功");
        ReqLoginAsync();
    }

    private async void ReqLoginAsync()
    {
        var req = new CThostFtdcReqUserLoginField
        {
            UserID = _config.User,
            Password = _config.Password,
            BrokerID = _config.Broker
        };
        var resp = await _api.ReqUserLoginAsync(req);
        if (resp.NoError)
        {
            LogWarning("登录成功");
        }
        else
        {
            LogWarning($"登录失败，{resp.InfoField.ErrorMsg}, code={resp.InfoField.ErrorID}");
        }
    }

    private void OnFrontDisconnected(int nReason)
    {
        LogDebug($"连接断开，代码{nReason}");
    }

    private void LogDebug(string msg) {}
    private void LogWarning(string msg) {}
}

class Config
{
    public string User { get; }
    public string Password { get; }
    public string Broker { get; }
    public string DataServer { get; }
    public string TradeServer { get; }
    public string AuthCode { get; }
    public string AppId { get; }
    public string ProductInfo { get; }
}
```
