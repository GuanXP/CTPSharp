using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

internal sealed class MdSPI : CThostFtdcMdSpi
{
    public PendingRequest<CThostFtdcRspUserLoginField>? LoginReq;
    public PendingRequest<CThostFtdcSpecificInstrumentField>? SubscribeReq;
    public PendingRequest<CThostFtdcSpecificInstrumentField>? UnsubscribeReq;

    public event Action? FrontConnected;
    public event Action<int>? FrontDisconnected;
    public event Action<CThostFtdcDepthMarketDataField>? DepthMarketDataArrived;

    public MdSPI()
    {
    }

    public sealed override void OnFrontConnected()
    {
        FrontConnected?.Invoke();
    }

    public sealed override void OnFrontDisconnected(int nReason)
    {
        LoginReq = null;
        SubscribeReq = null;
        UnsubscribeReq = null;
        FrontDisconnected?.Invoke(nReason);
    }

    public sealed override void OnRspSubMarketData(
        ref CThostFtdcSpecificInstrumentField pSpecificInstrument,
        ref CThostFtdcRspInfoField pRspInfo,
        int nRequestID, bool bIsLast)
    {
        // MD API 的callback并不带回发送时的 request id，所以总是当作最后一个请求的应答
        SubscribeReq?.SetResponseComplete(pSpecificInstrument, pRspInfo);
        SubscribeReq = null;
    }

    public sealed override void OnRspUnSubMarketData(
        ref CThostFtdcSpecificInstrumentField pSpecificInstrument,
        ref CThostFtdcRspInfoField pRspInfo,
        int nRequestID, bool bIsLast)
    {
        UnsubscribeReq?.SetResponseComplete(pSpecificInstrument, pRspInfo);
        UnsubscribeReq = null;
    }

    public sealed override void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData)
    {
        DepthMarketDataArrived?.Invoke(pDepthMarketData);
    }

    public sealed override void OnRspUserLogin(
        ref CThostFtdcRspUserLoginField pRspUserLogin,
        ref CThostFtdcRspInfoField pRspInfo,
        int nRequestID, bool bIsLast)
    {
        Debug.Assert(bIsLast); // 一次请求应该只有一个callback
        LoginReq?.SetResponseComplete(pRspUserLogin, pRspInfo);
        LoginReq = null;
    }
}
