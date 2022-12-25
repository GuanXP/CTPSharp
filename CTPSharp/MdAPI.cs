using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace XP.CTPSharp;

public sealed class MdAPI: IDisposable
{
    private readonly CThostFtdcMdApi _api;
    private MdSPI _spi = new();
    private readonly RequestId _requestId = new(201);

    public event Action? FrontConnected;
    public event Action<int>? FrontDisconnected;

    /// <summary>
    /// 行情接收事件
    /// </summary>
    public event Action<CThostFtdcDepthMarketDataField>? DepthMarketDataArrived;

    public MdAPI(string flowPath)
    {
        _spi.FrontConnected += () => FrontConnected?.Invoke();
        _spi.FrontDisconnected += (e) => FrontDisconnected?.Invoke(e);
        _spi.DepthMarketDataArrived += (e) => DepthMarketDataArrived?.Invoke(e);

        _api = new(flowPath);
        _api.RegisterSpi(_spi.Handle);
    }

    public void Dispose()
    {
        _api.RegisterSpi(0);
        _api.Dispose();
    }

    public string GetVersion() => _api.GetApiVersion();

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
        _api.RegisterFensUserInfo(ref pFensUserInfo);
    }

    public async Task<CTPResponse<CThostFtdcSpecificInstrumentField>>
        SubscribeMarketDataAsync(string[] instrumentsIds)
    {        
        _spi.SubscribeReq = new PendingRequest<CThostFtdcSpecificInstrumentField>(_requestId.Next());
        
        using var strArray = new StringArray(instrumentsIds);
        while (_api.SubscribeMarketData(strArray.Handle, strArray.Count) != 0)
        {
            await Task.Delay(1000);
        }

        return await _spi.SubscribeReq.Task.ConfigureAwait(false);        
    }

    public async Task<CTPResponse<CThostFtdcSpecificInstrumentField>>
        UnSubscribeMarketDataAsync(string[] instrumentsIds)
    {
        _spi.UnsubscribeReq = new PendingRequest<CThostFtdcSpecificInstrumentField>(_requestId.Next());
        using var strArray = new StringArray(instrumentsIds);
        while (_api.UnSubscribeMarketData(strArray.Handle, strArray.Count) != 0)
        {
            await Task.Delay(1000);
        }

        return await _spi.UnsubscribeReq.Task.ConfigureAwait(false);
    }

    public async Task<CTPResponse<CThostFtdcRspUserLoginField>>
        ReqUserLoginAsync(CThostFtdcReqUserLoginField pReqUserLoginField)
    {
        _spi.LoginReq = new PendingRequest<CThostFtdcRspUserLoginField>(_requestId.Next());
        while (_api.ReqUserLogin(ref pReqUserLoginField, _spi.LoginReq.RequestId) != 0)
        {
            await Task.Delay(1000);
        }

        return await _spi.LoginReq.Task.ConfigureAwait(false);
    }
}
