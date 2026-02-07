using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

internal class StringArray : IDisposable
{
    internal int Count => _strPtrs.Length;
    private IntPtr _ppStr;    
    private readonly IntPtr[] _strPtrs;
    public IntPtr Handle => _ppStr;
    public StringArray(string[] strings)
    {
        _strPtrs = new IntPtr[strings.Length];
        var ptrSize = Marshal.SizeOf(typeof(IntPtr));
        _ppStr = Marshal.AllocHGlobal(ptrSize * Count);
        var ptr = _ppStr;
        for (int i = 0; i < Count; ++i, ptr += ptrSize)
        {
            var gbkBytes = GBKConvert.Instance.GetBytes(strings[i]);
            var strBuff = Marshal.AllocHGlobal(gbkBytes.Length + 1);
            _strPtrs[i] = strBuff;
            Marshal.WriteIntPtr(ptr, strBuff);
            Marshal.Copy(gbkBytes, 0, _strPtrs[i], gbkBytes.Length);
            Marshal.WriteByte(_strPtrs[i] + gbkBytes.Length, 0); // null-terminate the string
        }
    }

    public void Dispose()
    {
        if (_ppStr == 0) return;

        Marshal.FreeHGlobal( _ppStr );
        _ppStr = 0;

        for (var i=0; i< _strPtrs.Length; ++i)
        {
            Marshal.FreeHGlobal(_strPtrs[i]);
        }
    }
}
