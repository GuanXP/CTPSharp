using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

public sealed class CTPResponse<TResp> where TResp : new()
{
    public CTPResponse(TResp? reponse, CThostFtdcRspInfoField info)
    {
        Response= reponse;
        InfoField= info;
    }

    public TResp? Response { get; }
    public CThostFtdcRspInfoField InfoField { get; }
    public bool NoError => InfoField.NoError;
}

internal interface ICancelable
{
    void SetCanceled();
}
internal class PendingRequest<TResp>: ICancelable where TResp : new()
{
    public int RequestId { get; }
    internal TResp? Response { get; private set; }

    private readonly TaskCompletionSource<CTPResponse<TResp>> _taskCompletionSource = new();
    public Task<CTPResponse<TResp>> Task => _taskCompletionSource.Task;

    public PendingRequest(int requestId)
    {
        Response = new();
        RequestId = requestId;
    }

    public void SetResponseComplete(TResp resp, CThostFtdcRspInfoField rspInfoField)
    {
        if (rspInfoField.NoError)
        {
            Response = resp;
            _taskCompletionSource.SetResult(new(Response, rspInfoField));
        }
        else
        {
            _taskCompletionSource.SetResult(new(default, rspInfoField));
        }
    }

    public void SetResponseComplete(CThostFtdcRspInfoField rspInfoField)
    {
        if (rspInfoField.NoError)
        {
            _taskCompletionSource.SetResult(new(Response, rspInfoField));
            Response = default;
        }
        else
        {
            _taskCompletionSource.SetResult(new(default, rspInfoField));
        }
    }

    public void SetCanceled()
    {
        _taskCompletionSource.SetCanceled();
    }
}
