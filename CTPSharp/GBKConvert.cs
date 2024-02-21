using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

internal class GBKConvert
{
    private readonly Encoding _GBKEncoding = System.Text.CodePagesEncodingProvider.Instance.GetEncoding("GBK")!;
    public static GBKConvert Instance { get; } = new GBKConvert();

    public string GetString(byte[] bytes)
    {
        if (bytes == null || bytes[0] == 0) return string.Empty;
        return _GBKEncoding.GetString(bytes).Trim('\0');
    }

    public unsafe string GetString(IntPtr ptr)
    {
        if (ptr == IntPtr.Zero) return string.Empty;
        int nbBytes = 0;
        for (byte* p = (byte*)ptr; *p != 0; p += 1, nbBytes += 1) ;
        return _GBKEncoding.GetString((byte*)ptr, nbBytes);
    }

    public void GetBytes(string str, byte[] bytes)
    {
        _GBKEncoding.GetBytes(str, bytes);
    }

    public byte[] GetBytes(string str)
    {
        return _GBKEncoding.GetBytes(str);
    }
}
