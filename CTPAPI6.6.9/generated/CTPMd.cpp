//由 generator生成的文件，不要手工修改

#include "ThostFtdcMdApi.h"

#ifndef CTPSHARP_STDCALL
# if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
#   define CTPSHARP_STDCALL __stdcall
# else
#   define CTPSHARP_STDCALL
# endif
#endif

#ifndef CTPSHARP_EXPORT
# if defined(_WIN32) || defined(__WIN32__) || defined(__CYGWIN__)
#   if defined(STATIC_LINKED)
#     define CTPSHARP_EXPORT
#   else
#     define CTPSHARP_EXPORT __declspec(dllexport)
#   endif
# else
#   if defined(__GNUC__) && defined(GCC_HASCLASSVISIBILITY)
#     define CTPSHARP_EXPORT __attribute__ ((visibility("default")))
#   else
#     define CTPSHARP_EXPORT
#   endif
# endif
#endif

struct CTPSharp_CThostFtdcMdSpi
{
    void (CTPSHARP_STDCALL *OnFrontConnected)();
    void (CTPSHARP_STDCALL *OnFrontDisconnected)(int nReason);
    void (CTPSHARP_STDCALL *OnHeartBeatWarning)(int nTimeLapse);
    void (CTPSHARP_STDCALL *OnRspUserLogin)(CThostFtdcRspUserLoginField* pRspUserLogin,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogout)(CThostFtdcUserLogoutField* pUserLogout,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMulticastInstrument)(CThostFtdcMulticastInstrumentField* pMulticastInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspError)(CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSubMarketData)(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUnSubMarketData)(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSubForQuoteRsp)(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUnSubForQuoteRsp)(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnDepthMarketData)(CThostFtdcDepthMarketDataField* pDepthMarketData);
    void (CTPSHARP_STDCALL *OnRtnForQuoteRsp)(CThostFtdcForQuoteRspField* pForQuoteRsp);
};
class CThostFtdcMdSpi_Ex: public CThostFtdcMdSpi
{
    CTPSharp_CThostFtdcMdSpi _callbacks;
public:
    CThostFtdcMdSpi_Ex(const CTPSharp_CThostFtdcMdSpi* callbacks){ _callbacks = *callbacks; }
    virtual void OnFrontConnected()
    {
        _callbacks.OnFrontConnected();
    }

    virtual void OnFrontDisconnected(int nReason)
    {
        _callbacks.OnFrontDisconnected(nReason);
    }

    virtual void OnHeartBeatWarning(int nTimeLapse)
    {
        _callbacks.OnHeartBeatWarning(nTimeLapse);
    }

    virtual void OnRspUserLogin(CThostFtdcRspUserLoginField* pRspUserLogin,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspUserLogin 回调 C# 参数 不能为 NULL
        CThostFtdcRspUserLoginField zero0 = {0};
        if (!pRspUserLogin) pRspUserLogin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserLogin(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUserLogout(CThostFtdcUserLogoutField* pUserLogout,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pUserLogout 回调 C# 参数 不能为 NULL
        CThostFtdcUserLogoutField zero0 = {0};
        if (!pUserLogout) pUserLogout = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserLogout(pUserLogout,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMulticastInstrument(CThostFtdcMulticastInstrumentField* pMulticastInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMulticastInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcMulticastInstrumentField zero0 = {0};
        if (!pMulticastInstrument) pMulticastInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMulticastInstrument(pMulticastInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspError(CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero0 = {0};
        if (!pRspInfo) pRspInfo = &zero0;
        _callbacks.OnRspError(pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUnSubMarketData(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUnSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSubForQuoteRsp(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUnSubForQuoteRsp(CThostFtdcSpecificInstrumentField* pSpecificInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUnSubForQuoteRsp(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData)
    {
        //pDepthMarketData 回调 C# 参数 不能为 NULL
        CThostFtdcDepthMarketDataField zero0 = {0};
        if (!pDepthMarketData) pDepthMarketData = &zero0;
        _callbacks.OnRtnDepthMarketData(pDepthMarketData);
    }

    virtual void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp)
    {
        //pForQuoteRsp 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteRspField zero0 = {0};
        if (!pForQuoteRsp) pForQuoteRsp = &zero0;
        _callbacks.OnRtnForQuoteRsp(pForQuoteRsp);
    }

};
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcMdSpi_New(const CTPSharp_CThostFtdcMdSpi* callbacks)
{
    return new CThostFtdcMdSpi_Ex(callbacks);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdSpi_Delete(void* spi)
{
    delete (CThostFtdcMdSpi_Ex*)spi;
}
extern "C"
CTPSHARP_EXPORT CThostFtdcMdApi* CTPSHARP_STDCALL CThostFtdcMdApi_Create(const char* pszFlowPath,const bool bIsUsingUdp,const bool bIsMulticast)
{
    return CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath,bIsUsingUdp,bIsMulticast);
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcMdApi_GetApiVersion()
{
    return CThostFtdcMdApi::GetApiVersion();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_Release(CThostFtdcMdApi* api)
{
    api->Release();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_Init(CThostFtdcMdApi* api)
{
    api->Init();
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_Join(CThostFtdcMdApi* api)
{
    return api->Join();
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcMdApi_GetTradingDay(CThostFtdcMdApi* api)
{
    return api->GetTradingDay();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterFront(CThostFtdcMdApi * api,char* pszFrontAddress)
{
    api->RegisterFront(pszFrontAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterNameServer(CThostFtdcMdApi * api,char* pszNsAddress)
{
    api->RegisterNameServer(pszNsAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterFensUserInfo(CThostFtdcMdApi * api,CThostFtdcFensUserInfoField* pFensUserInfo)
{
    api->RegisterFensUserInfo(pFensUserInfo);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterSpi(CThostFtdcMdApi * api,CThostFtdcMdSpi* pSpi)
{
    api->RegisterSpi(pSpi);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_SubscribeMarketData(CThostFtdcMdApi * api,char** ppInstrumentID,int nCount)
{
    return api->SubscribeMarketData(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_UnSubscribeMarketData(CThostFtdcMdApi * api,char** ppInstrumentID,int nCount)
{
    return api->UnSubscribeMarketData(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_SubscribeForQuoteRsp(CThostFtdcMdApi * api,char** ppInstrumentID,int nCount)
{
    return api->SubscribeForQuoteRsp(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_UnSubscribeForQuoteRsp(CThostFtdcMdApi * api,char** ppInstrumentID,int nCount)
{
    return api->UnSubscribeForQuoteRsp(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqUserLogin(CThostFtdcMdApi * api,CThostFtdcReqUserLoginField* pReqUserLoginField,int nRequestID)
{
    return api->ReqUserLogin(pReqUserLoginField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqUserLogout(CThostFtdcMdApi * api,CThostFtdcUserLogoutField* pUserLogout,int nRequestID)
{
    return api->ReqUserLogout(pUserLogout,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqQryMulticastInstrument(CThostFtdcMdApi * api,CThostFtdcQryMulticastInstrumentField* pQryMulticastInstrument,int nRequestID)
{
    return api->ReqQryMulticastInstrument(pQryMulticastInstrument,nRequestID);
}

