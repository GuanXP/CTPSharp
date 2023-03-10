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
    /// ??????API???????????????
    /// </summary>
    public string GetApiVersion()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcMdApi_GetApiVersion());
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public void Release()
    {
        CTPSharpPInvoke.CThostFtdcMdApi_Release(_handle);
    }

    /// <summary>
    /// ?????????
    /// </summary>
    public void Init()
    {
        CTPSharpPInvoke.CThostFtdcMdApi_Init(_handle);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int Join()
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_Join(_handle);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public string GetTradingDay()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcMdApi_GetTradingDay(_handle));
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    /// <param name="pszFrontAddress">????????????????????????</param>
    public void RegisterFront([MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterFront(_handle, pszFrontAddress);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    /// <param name="pszNsAddress">??????????????????????????????</param>
    public void RegisterNameServer([MarshalAs(UnmanagedType.LPStr)] string pszNsAddress)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterNameServer(_handle, pszNsAddress);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    /// <param name="pFensUserInfo">???????????????</param>
    public void RegisterFensUserInfo(ref CThostFtdcFensUserInfoField pFensUserInfo)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterFensUserInfo(_handle, ref pFensUserInfo);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    /// <param name="pSpi">?????????????????????????????????</param>
    public void RegisterSpi(IntPtr pSpi)
    {
        CTPSharpPInvoke.CThostFtdcMdApi_RegisterSpi(_handle, pSpi);
    }

    /// <summary>
    /// ???????????????
    /// </summary>
    /// <param name="ppInstrumentID">??????ID</param>
    /// <param name="nCount">?????????/???????????????????????????</param>
    public int SubscribeMarketData(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_SubscribeMarketData(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// ???????????????
    /// </summary>
    /// <param name="ppInstrumentID">??????ID</param>
    /// <param name="nCount">?????????/???????????????????????????</param>
    public int UnSubscribeMarketData(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_UnSubscribeMarketData(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// ???????????????
    /// </summary>
    /// <param name="ppInstrumentID">??????ID</param>
    /// <param name="nCount">?????????/???????????????????????????</param>
    public int SubscribeForQuoteRsp(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_SubscribeForQuoteRsp(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// ???????????????
    /// </summary>
    /// <param name="ppInstrumentID">??????ID</param>
    /// <param name="nCount">?????????/???????????????????????????</param>
    public int UnSubscribeForQuoteRsp(IntPtr ppInstrumentID,int nCount)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_UnSubscribeForQuoteRsp(_handle, ppInstrumentID,nCount);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_ReqUserLogin(_handle, ref pReqUserLoginField,nRequestID);
    }

    /// <summary>
    /// ????????????
    /// </summary>
    public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcMdApi_ReqUserLogout(_handle, ref pUserLogout,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
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
