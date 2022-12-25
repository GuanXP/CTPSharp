using System.Runtime.InteropServices;
namespace XP.CTPSharp;

internal partial class CTPSharpPInvoke
{
    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_Create", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcMdApi_Create([MarshalAs(UnmanagedType.LPStr)] string pszFlowPath="",bool bIsUsingUdp=false,bool bIsMulticast=false);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_GetApiVersion", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcMdApi_GetApiVersion();

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_Release", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_Release(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_Init", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_Init(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_Join", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_Join(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_GetTradingDay", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcMdApi_GetTradingDay(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_RegisterFront", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_RegisterFront(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_RegisterNameServer", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_RegisterNameServer(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string pszNsAddress);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_RegisterFensUserInfo", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_RegisterFensUserInfo(IntPtr handle, ref CThostFtdcFensUserInfoField pFensUserInfo);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_RegisterSpi", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdApi_RegisterSpi(IntPtr handle, IntPtr pSpi);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_SubscribeMarketData", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_SubscribeMarketData(IntPtr handle, IntPtr ppInstrumentID,int nCount);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_UnSubscribeMarketData", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_UnSubscribeMarketData(IntPtr handle, IntPtr ppInstrumentID,int nCount);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_SubscribeForQuoteRsp", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_SubscribeForQuoteRsp(IntPtr handle, IntPtr ppInstrumentID,int nCount);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_UnSubscribeForQuoteRsp", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_UnSubscribeForQuoteRsp(IntPtr handle, IntPtr ppInstrumentID,int nCount);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_ReqUserLogin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_ReqUserLogin(IntPtr handle, ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_ReqUserLogout", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_ReqUserLogout(IntPtr handle, ref CThostFtdcUserLogoutField pUserLogout,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdApi_ReqQryMulticastInstrument", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcMdApi_ReqQryMulticastInstrument(IntPtr handle, ref CThostFtdcQryMulticastInstrumentField pQryMulticastInstrument,int nRequestID);

}
public sealed class CThostFtdcMdApi
{
    IntPtr _handle;
    public CThostFtdcMdApi(string flowPath)
    {
        _handle = CTPSharpPInvoke.CThostFtdcMdApi_Create(flowPath);
    }

    /// <summary>
    /// 获取API的版本信息
    /// </summary>
    public string GetApiVersion()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcMdApi_GetApiVersion());
    }

    /// <summary>
    /// 删除接口对象本身
    /// </summary>
    public void Release()
    {
        CTPSharpPInvoke.CThostFtdcMdApi_Release(_handle);
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public void Init()
    {
        CTPSharpPInvoke.CThostFtdcMdApi_Init(_handle);
    }

    /// <summary>
    /// 等待接口线程结束运行
    /// </summary>
    public int Join()
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_Join(_handle);
    }

    /// <summary>
    /// 获取当前交易日
    /// </summary>
    public string GetTradingDay()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcMdApi_GetTradingDay(_handle));
    }

    /// <summary>
    /// 注册前置机网络地址
    /// </summary>
    /// <param name="pszFrontAddress">前置机网络地址。</param>
    public void RegisterFront([MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterFront(_handle, pszFrontAddress);
    }

    /// <summary>
    /// 注册名字服务器网络地址
    /// </summary>
    /// <param name="pszNsAddress">名字服务器网络地址。</param>
    public void RegisterNameServer([MarshalAs(UnmanagedType.LPStr)] string pszNsAddress)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterNameServer(_handle, pszNsAddress);
    }

    /// <summary>
    /// 注册名字服务器用户信息
    /// </summary>
    /// <param name="pFensUserInfo">用户信息。</param>
    public void RegisterFensUserInfo(ref CThostFtdcFensUserInfoField pFensUserInfo)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterFensUserInfo(_handle, ref pFensUserInfo);
    }

    /// <summary>
    /// 注册回调接口
    /// </summary>
    /// <param name="pSpi">派生自回调接口类的实例</param>
    public void RegisterSpi(IntPtr pSpi)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterSpi(_handle, pSpi);
    }

    /// <summary>
    /// 订阅行情。
    /// </summary>
    /// <param name="ppInstrumentID">合约ID</param>
    /// <param name="nCount">要订阅/退订行情的合约个数</param>
    public int SubscribeMarketData(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_SubscribeMarketData(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// 退订行情。
    /// </summary>
    /// <param name="ppInstrumentID">合约ID</param>
    /// <param name="nCount">要订阅/退订行情的合约个数</param>
    public int UnSubscribeMarketData(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_UnSubscribeMarketData(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// 订阅询价。
    /// </summary>
    /// <param name="ppInstrumentID">合约ID</param>
    /// <param name="nCount">要订阅/退订行情的合约个数</param>
    public int SubscribeForQuoteRsp(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_SubscribeForQuoteRsp(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// 退订询价。
    /// </summary>
    /// <param name="ppInstrumentID">合约ID</param>
    /// <param name="nCount">要订阅/退订行情的合约个数</param>
    public int UnSubscribeForQuoteRsp(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_UnSubscribeForQuoteRsp(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// 用户登录请求
    /// </summary>
    public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_ReqUserLogin(_handle, ref pReqUserLoginField,nRequestID);
    }

    /// <summary>
    /// 登出请求
    /// </summary>
    public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_ReqUserLogout(_handle, ref pUserLogout,nRequestID);
    }

    /// <summary>
    /// 请求查询组播合约
    /// </summary>
    public int ReqQryMulticastInstrument(ref CThostFtdcQryMulticastInstrumentField pQryMulticastInstrument,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_ReqQryMulticastInstrument(_handle, ref pQryMulticastInstrument,nRequestID);
    }

    public void Dispose()
    {
        if (_handle == 0) return;
        CTPSharpPInvoke.CThostFtdcMdApi_Release(_handle);
        //CTPSharpPInvoke.CThostFtdcMdApi_Join(_handle);
        _handle = 0;
    }
}
