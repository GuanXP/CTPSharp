using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

public class ErrorReturn<T>
{
    public T Field { get; }
    public CThostFtdcRspInfoField RspInfo { get; }

    internal ErrorReturn(T field, CThostFtdcRspInfoField rspInfo)
    {
        Field = field;
        RspInfo = rspInfo;
    }
}
