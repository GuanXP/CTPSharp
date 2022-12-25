using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

internal class RequestId
{
    int _value;
    public RequestId(int value)
    {
        _value = value;
    }

    public int Next()
    {
        return Interlocked.Add(ref _value, 1);
    }
}
