using System.Runtime.InteropServices;
namespace XP.CTPSharp;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct CTPSharp_CThostFtdcMdSpi
{
    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnFrontConnected();
    internal DelOnFrontConnected OnFrontConnected;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnFrontDisconnected(int nReason);
    internal DelOnFrontDisconnected OnFrontDisconnected;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnHeartBeatWarning(int nTimeLapse);
    internal DelOnHeartBeatWarning OnHeartBeatWarning;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserLogin OnRspUserLogin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserLogout OnRspUserLogout;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryMulticastInstrument(ref CThostFtdcMulticastInstrumentField pMulticastInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryMulticastInstrument OnRspQryMulticastInstrument;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspError(ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspError OnRspError;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspSubMarketData OnRspSubMarketData;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUnSubMarketData OnRspUnSubMarketData;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspSubForQuoteRsp(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspSubForQuoteRsp OnRspSubForQuoteRsp;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUnSubForQuoteRsp(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUnSubForQuoteRsp OnRspUnSubForQuoteRsp;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData);
    internal DelOnRtnDepthMarketData OnRtnDepthMarketData;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnForQuoteRsp(ref CThostFtdcForQuoteRspField pForQuoteRsp);
    internal DelOnRtnForQuoteRsp OnRtnForQuoteRsp;

}
internal partial class CTPSharpPInvoke
{
    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdSpi_New", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcMdSpi_New(ref CTPSharp_CThostFtdcMdSpi callback);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcMdSpi_Delete", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcMdSpi_Delete(IntPtr spi);
}
public class CThostFtdcMdSpi: IDisposable
{
    CTPSharp_CThostFtdcMdSpi _spi = new();
    IntPtr _handle;
    internal IntPtr Handle => _handle;
    public CThostFtdcMdSpi()
    {
        _spi.OnFrontConnected = this.OnFrontConnected;
        _spi.OnFrontDisconnected = this.OnFrontDisconnected;
        _spi.OnHeartBeatWarning = this.OnHeartBeatWarning;
        _spi.OnRspUserLogin = this.OnRspUserLogin;
        _spi.OnRspUserLogout = this.OnRspUserLogout;
        _spi.OnRspQryMulticastInstrument = this.OnRspQryMulticastInstrument;
        _spi.OnRspError = this.OnRspError;
        _spi.OnRspSubMarketData = this.OnRspSubMarketData;
        _spi.OnRspUnSubMarketData = this.OnRspUnSubMarketData;
        _spi.OnRspSubForQuoteRsp = this.OnRspSubForQuoteRsp;
        _spi.OnRspUnSubForQuoteRsp = this.OnRspUnSubForQuoteRsp;
        _spi.OnRtnDepthMarketData = this.OnRtnDepthMarketData;
        _spi.OnRtnForQuoteRsp = this.OnRtnForQuoteRsp;
        _handle = CTPSharpPInvoke.CThostFtdcMdSpi_New(ref _spi);
    }
    /// <summary>
    /// 当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
    /// </summary>
    public virtual void OnFrontConnected(){}

    /// <summary>
    /// 当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
    /// </summary>
    /// <param name="nReason">错误原因</param>
    public virtual void OnFrontDisconnected(int nReason){}

    /// <summary>
    /// 心跳超时警告。当长时间未收到报文时，该方法被调用。
    /// </summary>
    /// <param name="nTimeLapse">距离上次接收报文的时间</param>
    public virtual void OnHeartBeatWarning(int nTimeLapse){}

    /// <summary>
    /// 登录请求响应
    /// </summary>
    public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 登出请求响应
    /// </summary>
    public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询组播合约响应
    /// </summary>
    public virtual void OnRspQryMulticastInstrument(ref CThostFtdcMulticastInstrumentField pMulticastInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 错误应答
    /// </summary>
    public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 订阅行情应答
    /// </summary>
    public virtual void OnRspSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 取消订阅行情应答
    /// </summary>
    public virtual void OnRspUnSubMarketData(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 订阅询价应答
    /// </summary>
    public virtual void OnRspSubForQuoteRsp(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 取消订阅询价应答
    /// </summary>
    public virtual void OnRspUnSubForQuoteRsp(ref CThostFtdcSpecificInstrumentField pSpecificInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 深度行情通知
    /// </summary>
    public virtual void OnRtnDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData){}

    /// <summary>
    /// 询价通知
    /// </summary>
    public virtual void OnRtnForQuoteRsp(ref CThostFtdcForQuoteRspField pForQuoteRsp){}

    private void Close()
    {
        CTPSharpPInvoke.CThostFtdcMdSpi_Delete(_handle);
        _handle = 0;
    }
private bool disposedValue = false;
protected virtual void Dispose(bool disposing)
{
    if (!disposedValue)
    {
        if (disposing)
        {
            Close();
        }
        disposedValue = true;
    }
}

public void Dispose()
{
    Dispose(disposing: true);
    GC.SuppressFinalize(this);
}

}
