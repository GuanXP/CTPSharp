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
    void (CTPSHARP_STDCALL *OnRspUserLogin)(struct CThostFtdcRspUserLoginField* pRspUserLogin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogout)(struct CThostFtdcUserLogoutField* pUserLogout,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMulticastInstrument)(struct CThostFtdcMulticastInstrumentField* pMulticastInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspError)(struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSubMarketData)(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUnSubMarketData)(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSubForQuoteRsp)(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUnSubForQuoteRsp)(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnDepthMarketData)(struct CThostFtdcDepthMarketDataField* pDepthMarketData);
    void (CTPSHARP_STDCALL *OnRtnForQuoteRsp)(struct CThostFtdcForQuoteRspField* pForQuoteRsp);
};
class CThostFtdcMdSpi_Ex: public CThostFtdcMdSpi
{
    CTPSharp_CThostFtdcMdSpi _callbacks;
public:
    CThostFtdcMdSpi_Ex(const CTPSharp_CThostFtdcMdSpi* callbacks){ _callbacks = *callbacks; }
    virtual ~CThostFtdcMdSpi_Ex() {}
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

    virtual void OnRspUserLogin(struct CThostFtdcRspUserLoginField* pRspUserLogin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspUserLogin 回调 C# 参数 不能为 NULL
        CThostFtdcRspUserLoginField zero0 = {0};
        if (!pRspUserLogin) pRspUserLogin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserLogin(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUserLogout(struct CThostFtdcUserLogoutField* pUserLogout,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pUserLogout 回调 C# 参数 不能为 NULL
        CThostFtdcUserLogoutField zero0 = {0};
        if (!pUserLogout) pUserLogout = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserLogout(pUserLogout,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMulticastInstrument(struct CThostFtdcMulticastInstrumentField* pMulticastInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMulticastInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcMulticastInstrumentField zero0 = {0};
        if (!pMulticastInstrument) pMulticastInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMulticastInstrument(pMulticastInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspError(struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero0 = {0};
        if (!pRspInfo) pRspInfo = &zero0;
        _callbacks.OnRspError(pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSubMarketData(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUnSubMarketData(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUnSubMarketData(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSubForQuoteRsp(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSubForQuoteRsp(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUnSubForQuoteRsp(struct CThostFtdcSpecificInstrumentField* pSpecificInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSpecificInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcSpecificInstrumentField zero0 = {0};
        if (!pSpecificInstrument) pSpecificInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUnSubForQuoteRsp(pSpecificInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnDepthMarketData(struct CThostFtdcDepthMarketDataField* pDepthMarketData)
    {
        //pDepthMarketData 回调 C# 参数 不能为 NULL
        CThostFtdcDepthMarketDataField zero0 = {0};
        if (!pDepthMarketData) pDepthMarketData = &zero0;
        _callbacks.OnRtnDepthMarketData(pDepthMarketData);
    }

    virtual void OnRtnForQuoteRsp(struct CThostFtdcForQuoteRspField* pForQuoteRsp)
    {
        //pForQuoteRsp 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteRspField zero0 = {0};
        if (!pForQuoteRsp) pForQuoteRsp = &zero0;
        _callbacks.OnRtnForQuoteRsp(pForQuoteRsp);
    }

};
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcMdSpi_New(const struct CTPSharp_CThostFtdcMdSpi* callbacks)
{
    return new CThostFtdcMdSpi_Ex(callbacks);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdSpi_Delete(void* spi)
{
    delete static_cast<CThostFtdcMdSpi_Ex*>(spi);
}
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcMdApi_Create(const char* pszFlowPath,const bool bIsUsingUdp,const bool bIsMulticast)
{
    return CThostFtdcMdApi::CreateFtdcMdApi(pszFlowPath,bIsUsingUdp,bIsMulticast);
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcMdApi_GetApiVersion()
{
    return CThostFtdcMdApi::GetApiVersion();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_Release(void* api)
{
    static_cast<CThostFtdcMdApi*>(api)->Release();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_Init(void* api)
{
    static_cast<CThostFtdcMdApi*>(api)->Init();
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_Join(void* api)
{
    return static_cast<CThostFtdcMdApi*>(api)->Join();
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcMdApi_GetTradingDay(void* api)
{
    return static_cast<CThostFtdcMdApi*>(api)->GetTradingDay();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterFront(void* api, char* pszFrontAddress)
{
    static_cast<CThostFtdcMdApi*>(api)->RegisterFront(pszFrontAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterNameServer(void* api, char* pszNsAddress)
{
    static_cast<CThostFtdcMdApi*>(api)->RegisterNameServer(pszNsAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterFensUserInfo(void* api, struct CThostFtdcFensUserInfoField* pFensUserInfo)
{
    static_cast<CThostFtdcMdApi*>(api)->RegisterFensUserInfo(pFensUserInfo);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcMdApi_RegisterSpi(void* api, void* pSpi)
{
    static_cast<CThostFtdcMdApi*>(api)->RegisterSpi(static_cast<CThostFtdcMdSpi*>(pSpi));
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_SubscribeMarketData(void* api, char** ppInstrumentID,int nCount)
{
    return static_cast<CThostFtdcMdApi*>(api)->SubscribeMarketData(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_UnSubscribeMarketData(void* api, char** ppInstrumentID,int nCount)
{
    return static_cast<CThostFtdcMdApi*>(api)->UnSubscribeMarketData(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_SubscribeForQuoteRsp(void* api, char** ppInstrumentID,int nCount)
{
    return static_cast<CThostFtdcMdApi*>(api)->SubscribeForQuoteRsp(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_UnSubscribeForQuoteRsp(void* api, char** ppInstrumentID,int nCount)
{
    return static_cast<CThostFtdcMdApi*>(api)->UnSubscribeForQuoteRsp(ppInstrumentID,nCount);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqUserLogin(void* api, struct CThostFtdcReqUserLoginField* pReqUserLoginField,int nRequestID)
{
    return static_cast<CThostFtdcMdApi*>(api)->ReqUserLogin(pReqUserLoginField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqUserLogout(void* api, struct CThostFtdcUserLogoutField* pUserLogout,int nRequestID)
{
    return static_cast<CThostFtdcMdApi*>(api)->ReqUserLogout(pUserLogout,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcMdApi_ReqQryMulticastInstrument(void* api, struct CThostFtdcQryMulticastInstrumentField* pQryMulticastInstrument,int nRequestID)
{
    return static_cast<CThostFtdcMdApi*>(api)->ReqQryMulticastInstrument(pQryMulticastInstrument,nRequestID);
}

