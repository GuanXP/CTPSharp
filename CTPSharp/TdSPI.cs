using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

internal partial class TdSPI: CThostFtdcTraderSpi
{
    private readonly ConcurrentDictionary<int, ICancelable> _pendingRequests = new();
    internal void CachePendingRequest<T>(PendingRequest<T> pending) where T : new()
    {
        _pendingRequests[pending.RequestId] = pending;
    }

    private void CompleteListPending<TResponse>(
        TResponse resp,
        CThostFtdcRspInfoField pRspInfo,
        int nRequestID,
        bool bIsLast) where TResponse : new()
    {
        var exist = bIsLast ? _pendingRequests.TryRemove(nRequestID, out var req)
            : _pendingRequests.TryGetValue(nRequestID, out req);
        Debug.Assert(exist);
        if (exist && req is PendingRequest<List<TResponse>> pending)
        {
            if (pRspInfo.NoError)
            {
                pending.Response?.Add(resp);
            }
            if (bIsLast)
            {
                // 不要在PInvoke的回调里设置Complete
                Task.Run(() => { pending.SetResponseComplete(pRspInfo); });
            }
        }
    }
}
