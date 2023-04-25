using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

public sealed partial class TdAPI: IDisposable
{
    private readonly CThostFtdcTraderApi _api;
    private readonly TdSPI _spi = new();
    private readonly RequestId _requestId = new(101);
    private readonly bool _holdApi;

    public CThostFtdcTraderApi RawApi { get { return _api; } }

    public TdAPI(CThostFtdcTraderApi rawApi, bool needDisposeRawApi)
    {
        _api = rawApi;
        _holdApi = needDisposeRawApi;

        SubscribeSPI();
        _api.RegisterSpi(_spi.Handle);
    }

    public TdAPI(string flowPath)
    {        
        _api = new(flowPath);
        _holdApi = true;

        SubscribeSPI();
        _api.RegisterSpi(_spi.Handle);
    }

    public void Dispose()
    {
        _api.RegisterSpi(0); 
        if (_holdApi) _api.Dispose();
    }

    public void RegisterFront(string pszFrontAddress)
    {
        _api.RegisterFront(pszFrontAddress);
    }

    public void Init()
    {
        _api.Init();
    }

    public void RegisterNameServer(string pszNsAddress)
    {
        _api.RegisterNameServer(pszNsAddress);
    }

    public void RegisterFensUserInfo(ref CThostFtdcFensUserInfoField pFensUserInfo)
    {
        var p = pFensUserInfo;
        _api.RegisterFensUserInfo(ref p);
    }

    public void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        _api.SubscribePrivateTopic(nResumeType);
    }

    public void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        _api.SubscribePublicTopic(nResumeType);
    }
}
