using System.Diagnostics;
namespace XP.CTPSharp;

public partial class TdAPI
{
    /// <summary>
    /// 当客户端与交易后台建立起通信连接时（还未登录前），该方法被调用。
    /// </summary>
    public event Action? FrontConnected;
    /// <summary>
    /// 当客户端与交易后台通信连接断开时，该方法被调用。当发生这个情况后，API会自动重新连接，客户端可不做处理。
    /// </summary>
    public event Action<int>? FrontDisconnected;
    /// <summary>
    /// 心跳超时警告。当长时间未收到报文时，该方法被调用。
    /// </summary>
    public event Action<int>? HeartBeatWarning;
    /// <summary>
    /// 报单通知
    /// </summary>
    public event Action<CThostFtdcOrderField>? RtnOrder;
    /// <summary>
    /// 成交通知
    /// </summary>
    public event Action<CThostFtdcTradeField>? RtnTrade;
    /// <summary>
    /// 报单录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputOrderField>>? ErrRtnOrderInsert;
    /// <summary>
    /// 报单操作错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcOrderActionField>>? ErrRtnOrderAction;
    /// <summary>
    /// 合约交易状态通知
    /// </summary>
    public event Action<CThostFtdcInstrumentStatusField>? RtnInstrumentStatus;
    /// <summary>
    /// 交易所公告通知
    /// </summary>
    public event Action<CThostFtdcBulletinField>? RtnBulletin;
    /// <summary>
    /// 交易通知
    /// </summary>
    public event Action<CThostFtdcTradingNoticeInfoField>? RtnTradingNotice;
    /// <summary>
    /// 提示条件单校验错误
    /// </summary>
    public event Action<CThostFtdcErrorConditionalOrderField>? RtnErrorConditionalOrder;
    /// <summary>
    /// 执行宣告通知
    /// </summary>
    public event Action<CThostFtdcExecOrderField>? RtnExecOrder;
    /// <summary>
    /// 执行宣告录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputExecOrderField>>? ErrRtnExecOrderInsert;
    /// <summary>
    /// 执行宣告操作错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcExecOrderActionField>>? ErrRtnExecOrderAction;
    /// <summary>
    /// 询价录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputForQuoteField>>? ErrRtnForQuoteInsert;
    /// <summary>
    /// 报价通知
    /// </summary>
    public event Action<CThostFtdcQuoteField>? RtnQuote;
    /// <summary>
    /// 报价录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputQuoteField>>? ErrRtnQuoteInsert;
    /// <summary>
    /// 报价操作错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcQuoteActionField>>? ErrRtnQuoteAction;
    /// <summary>
    /// 询价通知
    /// </summary>
    public event Action<CThostFtdcForQuoteRspField>? RtnForQuoteRsp;
    /// <summary>
    /// 保证金监控中心用户令牌
    /// </summary>
    public event Action<CThostFtdcCFMMCTradingAccountTokenField>? RtnCFMMCTradingAccountToken;
    /// <summary>
    /// 批量报单操作错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcBatchOrderActionField>>? ErrRtnBatchOrderAction;
    /// <summary>
    /// 期权自对冲通知
    /// </summary>
    public event Action<CThostFtdcOptionSelfCloseField>? RtnOptionSelfClose;
    /// <summary>
    /// 期权自对冲录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputOptionSelfCloseField>>? ErrRtnOptionSelfCloseInsert;
    /// <summary>
    /// 期权自对冲操作错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcOptionSelfCloseActionField>>? ErrRtnOptionSelfCloseAction;
    /// <summary>
    /// 申请组合通知
    /// </summary>
    public event Action<CThostFtdcCombActionField>? RtnCombAction;
    /// <summary>
    /// 申请组合录入错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcInputCombActionField>>? ErrRtnCombActionInsert;
    /// <summary>
    /// 银行发起银行资金转期货通知
    /// </summary>
    public event Action<CThostFtdcRspTransferField>? RtnFromBankToFutureByBank;
    /// <summary>
    /// 银行发起期货资金转银行通知
    /// </summary>
    public event Action<CThostFtdcRspTransferField>? RtnFromFutureToBankByBank;
    /// <summary>
    /// 银行发起冲正银行转期货通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByBank;
    /// <summary>
    /// 银行发起冲正期货转银行通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByBank;
    /// <summary>
    /// 期货发起银行资金转期货通知
    /// </summary>
    public event Action<CThostFtdcRspTransferField>? RtnFromBankToFutureByFuture;
    /// <summary>
    /// 期货发起期货资金转银行通知
    /// </summary>
    public event Action<CThostFtdcRspTransferField>? RtnFromFutureToBankByFuture;
    /// <summary>
    /// 系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByFutureManual;
    /// <summary>
    /// 系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByFutureManual;
    /// <summary>
    /// 期货发起查询银行余额通知
    /// </summary>
    public event Action<CThostFtdcNotifyQueryAccountField>? RtnQueryBankBalanceByFuture;
    /// <summary>
    /// 期货发起银行资金转期货错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcReqTransferField>>? ErrRtnBankToFutureByFuture;
    /// <summary>
    /// 期货发起期货资金转银行错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcReqTransferField>>? ErrRtnFutureToBankByFuture;
    /// <summary>
    /// 系统运行时期货端手工发起冲正银行转期货错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcReqRepealField>>? ErrRtnRepealBankToFutureByFutureManual;
    /// <summary>
    /// 系统运行时期货端手工发起冲正期货转银行错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcReqRepealField>>? ErrRtnRepealFutureToBankByFutureManual;
    /// <summary>
    /// 期货发起查询银行余额错误回报
    /// </summary>
    public event Action<ErrorReturn<CThostFtdcReqQueryAccountField>>? ErrRtnQueryBankBalanceByFuture;
    /// <summary>
    /// 期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByFuture;
    /// <summary>
    /// 期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByFuture;
    /// <summary>
    /// 银行发起银期开户通知
    /// </summary>
    public event Action<CThostFtdcOpenAccountField>? RtnOpenAccountByBank;
    /// <summary>
    /// 银行发起银期销户通知
    /// </summary>
    public event Action<CThostFtdcCancelAccountField>? RtnCancelAccountByBank;
    /// <summary>
    /// 银行发起变更银行账号通知
    /// </summary>
    public event Action<CThostFtdcChangeAccountField>? RtnChangeAccountByBank;

    private void SubscribeSPI()
    {
        _spi.FrontConnected += () => FrontConnected?.Invoke();
        _spi.FrontDisconnected += (_1) => FrontDisconnected?.Invoke(_1);
        _spi.HeartBeatWarning += (_1) => HeartBeatWarning?.Invoke(_1);
        _spi.RtnOrder += (_1) => RtnOrder?.Invoke(_1);
        _spi.RtnTrade += (_1) => RtnTrade?.Invoke(_1);
        _spi.ErrRtnOrderInsert += (_1) => ErrRtnOrderInsert?.Invoke(_1);
        _spi.ErrRtnOrderAction += (_1) => ErrRtnOrderAction?.Invoke(_1);
        _spi.RtnInstrumentStatus += (_1) => RtnInstrumentStatus?.Invoke(_1);
        _spi.RtnBulletin += (_1) => RtnBulletin?.Invoke(_1);
        _spi.RtnTradingNotice += (_1) => RtnTradingNotice?.Invoke(_1);
        _spi.RtnErrorConditionalOrder += (_1) => RtnErrorConditionalOrder?.Invoke(_1);
        _spi.RtnExecOrder += (_1) => RtnExecOrder?.Invoke(_1);
        _spi.ErrRtnExecOrderInsert += (_1) => ErrRtnExecOrderInsert?.Invoke(_1);
        _spi.ErrRtnExecOrderAction += (_1) => ErrRtnExecOrderAction?.Invoke(_1);
        _spi.ErrRtnForQuoteInsert += (_1) => ErrRtnForQuoteInsert?.Invoke(_1);
        _spi.RtnQuote += (_1) => RtnQuote?.Invoke(_1);
        _spi.ErrRtnQuoteInsert += (_1) => ErrRtnQuoteInsert?.Invoke(_1);
        _spi.ErrRtnQuoteAction += (_1) => ErrRtnQuoteAction?.Invoke(_1);
        _spi.RtnForQuoteRsp += (_1) => RtnForQuoteRsp?.Invoke(_1);
        _spi.RtnCFMMCTradingAccountToken += (_1) => RtnCFMMCTradingAccountToken?.Invoke(_1);
        _spi.ErrRtnBatchOrderAction += (_1) => ErrRtnBatchOrderAction?.Invoke(_1);
        _spi.RtnOptionSelfClose += (_1) => RtnOptionSelfClose?.Invoke(_1);
        _spi.ErrRtnOptionSelfCloseInsert += (_1) => ErrRtnOptionSelfCloseInsert?.Invoke(_1);
        _spi.ErrRtnOptionSelfCloseAction += (_1) => ErrRtnOptionSelfCloseAction?.Invoke(_1);
        _spi.RtnCombAction += (_1) => RtnCombAction?.Invoke(_1);
        _spi.ErrRtnCombActionInsert += (_1) => ErrRtnCombActionInsert?.Invoke(_1);
        _spi.RtnFromBankToFutureByBank += (_1) => RtnFromBankToFutureByBank?.Invoke(_1);
        _spi.RtnFromFutureToBankByBank += (_1) => RtnFromFutureToBankByBank?.Invoke(_1);
        _spi.RtnRepealFromBankToFutureByBank += (_1) => RtnRepealFromBankToFutureByBank?.Invoke(_1);
        _spi.RtnRepealFromFutureToBankByBank += (_1) => RtnRepealFromFutureToBankByBank?.Invoke(_1);
        _spi.RtnFromBankToFutureByFuture += (_1) => RtnFromBankToFutureByFuture?.Invoke(_1);
        _spi.RtnFromFutureToBankByFuture += (_1) => RtnFromFutureToBankByFuture?.Invoke(_1);
        _spi.RtnRepealFromBankToFutureByFutureManual += (_1) => RtnRepealFromBankToFutureByFutureManual?.Invoke(_1);
        _spi.RtnRepealFromFutureToBankByFutureManual += (_1) => RtnRepealFromFutureToBankByFutureManual?.Invoke(_1);
        _spi.RtnQueryBankBalanceByFuture += (_1) => RtnQueryBankBalanceByFuture?.Invoke(_1);
        _spi.ErrRtnBankToFutureByFuture += (_1) => ErrRtnBankToFutureByFuture?.Invoke(_1);
        _spi.ErrRtnFutureToBankByFuture += (_1) => ErrRtnFutureToBankByFuture?.Invoke(_1);
        _spi.ErrRtnRepealBankToFutureByFutureManual += (_1) => ErrRtnRepealBankToFutureByFutureManual?.Invoke(_1);
        _spi.ErrRtnRepealFutureToBankByFutureManual += (_1) => ErrRtnRepealFutureToBankByFutureManual?.Invoke(_1);
        _spi.ErrRtnQueryBankBalanceByFuture += (_1) => ErrRtnQueryBankBalanceByFuture?.Invoke(_1);
        _spi.RtnRepealFromBankToFutureByFuture += (_1) => RtnRepealFromBankToFutureByFuture?.Invoke(_1);
        _spi.RtnRepealFromFutureToBankByFuture += (_1) => RtnRepealFromFutureToBankByFuture?.Invoke(_1);
        _spi.RtnOpenAccountByBank += (_1) => RtnOpenAccountByBank?.Invoke(_1);
        _spi.RtnCancelAccountByBank += (_1) => RtnCancelAccountByBank?.Invoke(_1);
        _spi.RtnChangeAccountByBank += (_1) => RtnChangeAccountByBank?.Invoke(_1);
    }


    /// <summary>
    /// 客户端认证请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspAuthenticateField>>>
    ReqAuthenticateAsync(CThostFtdcReqAuthenticateField pReqAuthenticateField)
    {
        var pending = new PendingRequest<List<CThostFtdcRspAuthenticateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqAuthenticate(ref pReqAuthenticateField, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户登录请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspUserLoginField>>>
    ReqUserLoginAsync(CThostFtdcReqUserLoginField pReqUserLoginField)
    {
        var pending = new PendingRequest<List<CThostFtdcRspUserLoginField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserLogin(ref pReqUserLoginField, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 登出请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcUserLogoutField>>>
    ReqUserLogoutAsync(CThostFtdcUserLogoutField pUserLogout)
    {
        var pending = new PendingRequest<List<CThostFtdcUserLogoutField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserLogout(ref pUserLogout, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户口令更新请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcUserPasswordUpdateField>>>
    ReqUserPasswordUpdateAsync(CThostFtdcUserPasswordUpdateField pUserPasswordUpdate)
    {
        var pending = new PendingRequest<List<CThostFtdcUserPasswordUpdateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserPasswordUpdate(ref pUserPasswordUpdate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 资金账户口令更新请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradingAccountPasswordUpdateField>>>
    ReqTradingAccountPasswordUpdateAsync(CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate)
    {
        var pending = new PendingRequest<List<CThostFtdcTradingAccountPasswordUpdateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqTradingAccountPasswordUpdate(ref pTradingAccountPasswordUpdate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 查询用户当前支持的认证模式
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspUserAuthMethodField>>>
    ReqUserAuthMethodAsync(CThostFtdcReqUserAuthMethodField pReqUserAuthMethod)
    {
        var pending = new PendingRequest<List<CThostFtdcRspUserAuthMethodField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserAuthMethod(ref pReqUserAuthMethod, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户发出获取图形验证码请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspGenUserCaptchaField>>>
    ReqGenUserCaptchaAsync(CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha)
    {
        var pending = new PendingRequest<List<CThostFtdcRspGenUserCaptchaField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqGenUserCaptcha(ref pReqGenUserCaptcha, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户发出获取短信验证码请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspGenUserTextField>>>
    ReqGenUserTextAsync(CThostFtdcReqGenUserTextField pReqGenUserText)
    {
        var pending = new PendingRequest<List<CThostFtdcRspGenUserTextField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqGenUserText(ref pReqGenUserText, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户发出带有图片验证码的登陆请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspUserLoginField>>>
    ReqUserLoginWithCaptchaAsync(CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha)
    {
        var pending = new PendingRequest<List<CThostFtdcRspUserLoginField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserLoginWithCaptcha(ref pReqUserLoginWithCaptcha, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户发出带有短信验证码的登陆请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspUserLoginField>>>
    ReqUserLoginWithTextAsync(CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText)
    {
        var pending = new PendingRequest<List<CThostFtdcRspUserLoginField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserLoginWithText(ref pReqUserLoginWithText, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 用户发出带有动态口令的登陆请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRspUserLoginField>>>
    ReqUserLoginWithOTPAsync(CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP)
    {
        var pending = new PendingRequest<List<CThostFtdcRspUserLoginField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqUserLoginWithOTP(ref pReqUserLoginWithOTP, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 报单录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputOrderField>>>
    ReqOrderInsertAsync(CThostFtdcInputOrderField pInputOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcInputOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqOrderInsert(ref pInputOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 预埋单录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcParkedOrderField>>>
    ReqParkedOrderInsertAsync(CThostFtdcParkedOrderField pParkedOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcParkedOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqParkedOrderInsert(ref pParkedOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 预埋撤单录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcParkedOrderActionField>>>
    ReqParkedOrderActionAsync(CThostFtdcParkedOrderActionField pParkedOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcParkedOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqParkedOrderAction(ref pParkedOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 报单操作请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcParkedOrderActionField>>>
    ReqOrderActionAsync(CThostFtdcInputOrderActionField pInputOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcParkedOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqOrderAction(ref pInputOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 查询最大报单数量请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcQryMaxOrderVolumeField>>>
    ReqQryMaxOrderVolumeAsync(CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume)
    {
        var pending = new PendingRequest<List<CThostFtdcQryMaxOrderVolumeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryMaxOrderVolume(ref pQryMaxOrderVolume, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 投资者结算结果确认
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSettlementInfoConfirmField>>>
    ReqSettlementInfoConfirmAsync(CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm)
    {
        var pending = new PendingRequest<List<CThostFtdcSettlementInfoConfirmField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqSettlementInfoConfirm(ref pSettlementInfoConfirm, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求删除预埋单
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRemoveParkedOrderField>>>
    ReqRemoveParkedOrderAsync(CThostFtdcRemoveParkedOrderField pRemoveParkedOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcRemoveParkedOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqRemoveParkedOrder(ref pRemoveParkedOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求删除预埋撤单
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRemoveParkedOrderActionField>>>
    ReqRemoveParkedOrderActionAsync(CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcRemoveParkedOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqRemoveParkedOrderAction(ref pRemoveParkedOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 执行宣告录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputExecOrderField>>>
    ReqExecOrderInsertAsync(CThostFtdcInputExecOrderField pInputExecOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcInputExecOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqExecOrderInsert(ref pInputExecOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 执行宣告操作请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputExecOrderActionField>>>
    ReqExecOrderActionAsync(CThostFtdcInputExecOrderActionField pInputExecOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcInputExecOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqExecOrderAction(ref pInputExecOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 询价录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputForQuoteField>>>
    ReqForQuoteInsertAsync(CThostFtdcInputForQuoteField pInputForQuote)
    {
        var pending = new PendingRequest<List<CThostFtdcInputForQuoteField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqForQuoteInsert(ref pInputForQuote, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 报价录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputForQuoteField>>>
    ReqQuoteInsertAsync(CThostFtdcInputQuoteField pInputQuote)
    {
        var pending = new PendingRequest<List<CThostFtdcInputForQuoteField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQuoteInsert(ref pInputQuote, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 报价操作请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputQuoteActionField>>>
    ReqQuoteActionAsync(CThostFtdcInputQuoteActionField pInputQuoteAction)
    {
        var pending = new PendingRequest<List<CThostFtdcInputQuoteActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQuoteAction(ref pInputQuoteAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 批量报单操作请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputBatchOrderActionField>>>
    ReqBatchOrderActionAsync(CThostFtdcInputBatchOrderActionField pInputBatchOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcInputBatchOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqBatchOrderAction(ref pInputBatchOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 期权自对冲录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputOptionSelfCloseField>>>
    ReqOptionSelfCloseInsertAsync(CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose)
    {
        var pending = new PendingRequest<List<CThostFtdcInputOptionSelfCloseField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqOptionSelfCloseInsert(ref pInputOptionSelfClose, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 期权自对冲操作请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputOptionSelfCloseActionField>>>
    ReqOptionSelfCloseActionAsync(CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction)
    {
        var pending = new PendingRequest<List<CThostFtdcInputOptionSelfCloseActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqOptionSelfCloseAction(ref pInputOptionSelfCloseAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 申请组合录入请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInputCombActionField>>>
    ReqCombActionInsertAsync(CThostFtdcInputCombActionField pInputCombAction)
    {
        var pending = new PendingRequest<List<CThostFtdcInputCombActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqCombActionInsert(ref pInputCombAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询报单
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcOrderField>>>
    ReqQryOrderAsync(CThostFtdcQryOrderField pQryOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryOrder(ref pQryOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询成交
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradeField>>>
    ReqQryTradeAsync(CThostFtdcQryTradeField pQryTrade)
    {
        var pending = new PendingRequest<List<CThostFtdcTradeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTrade(ref pQryTrade, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者持仓
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorPositionField>>>
    ReqQryInvestorPositionAsync(CThostFtdcQryInvestorPositionField pQryInvestorPosition)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorPositionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorPosition(ref pQryInvestorPosition, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询资金账户
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradingAccountField>>>
    ReqQryTradingAccountAsync(CThostFtdcQryTradingAccountField pQryTradingAccount)
    {
        var pending = new PendingRequest<List<CThostFtdcTradingAccountField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTradingAccount(ref pQryTradingAccount, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorField>>>
    ReqQryInvestorAsync(CThostFtdcQryInvestorField pQryInvestor)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestor(ref pQryInvestor, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易编码
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradingCodeField>>>
    ReqQryTradingCodeAsync(CThostFtdcQryTradingCodeField pQryTradingCode)
    {
        var pending = new PendingRequest<List<CThostFtdcTradingCodeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTradingCode(ref pQryTradingCode, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询合约保证金率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInstrumentMarginRateField>>>
    ReqQryInstrumentMarginRateAsync(CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate)
    {
        var pending = new PendingRequest<List<CThostFtdcInstrumentMarginRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInstrumentMarginRate(ref pQryInstrumentMarginRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询合约手续费率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInstrumentCommissionRateField>>>
    ReqQryInstrumentCommissionRateAsync(CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate)
    {
        var pending = new PendingRequest<List<CThostFtdcInstrumentCommissionRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInstrumentCommissionRate(ref pQryInstrumentCommissionRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易所
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcExchangeField>>>
    ReqQryExchangeAsync(CThostFtdcQryExchangeField pQryExchange)
    {
        var pending = new PendingRequest<List<CThostFtdcExchangeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryExchange(ref pQryExchange, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询产品
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcProductField>>>
    ReqQryProductAsync(CThostFtdcQryProductField pQryProduct)
    {
        var pending = new PendingRequest<List<CThostFtdcProductField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryProduct(ref pQryProduct, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询合约
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInstrumentField>>>
    ReqQryInstrumentAsync(CThostFtdcQryInstrumentField pQryInstrument)
    {
        var pending = new PendingRequest<List<CThostFtdcInstrumentField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInstrument(ref pQryInstrument, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询行情
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcDepthMarketDataField>>>
    ReqQryDepthMarketDataAsync(CThostFtdcQryDepthMarketDataField pQryDepthMarketData)
    {
        var pending = new PendingRequest<List<CThostFtdcDepthMarketDataField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryDepthMarketData(ref pQryDepthMarketData, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易员报盘机
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTraderOfferField>>>
    ReqQryTraderOfferAsync(CThostFtdcQryTraderOfferField pQryTraderOffer)
    {
        var pending = new PendingRequest<List<CThostFtdcTraderOfferField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTraderOffer(ref pQryTraderOffer, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者结算结果
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSettlementInfoField>>>
    ReqQrySettlementInfoAsync(CThostFtdcQrySettlementInfoField pQrySettlementInfo)
    {
        var pending = new PendingRequest<List<CThostFtdcSettlementInfoField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySettlementInfo(ref pQrySettlementInfo, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询转帐银行
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTransferBankField>>>
    ReqQryTransferBankAsync(CThostFtdcQryTransferBankField pQryTransferBank)
    {
        var pending = new PendingRequest<List<CThostFtdcTransferBankField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTransferBank(ref pQryTransferBank, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者持仓明细
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorPositionDetailField>>>
    ReqQryInvestorPositionDetailAsync(CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorPositionDetailField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorPositionDetail(ref pQryInvestorPositionDetail, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询客户通知
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcNoticeField>>>
    ReqQryNoticeAsync(CThostFtdcQryNoticeField pQryNotice)
    {
        var pending = new PendingRequest<List<CThostFtdcNoticeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryNotice(ref pQryNotice, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询结算信息确认
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSettlementInfoConfirmField>>>
    ReqQrySettlementInfoConfirmAsync(CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm)
    {
        var pending = new PendingRequest<List<CThostFtdcSettlementInfoConfirmField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySettlementInfoConfirm(ref pQrySettlementInfoConfirm, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者持仓明细
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorPositionCombineDetailField>>>
    ReqQryInvestorPositionCombineDetailAsync(CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorPositionCombineDetailField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorPositionCombineDetail(ref pQryInvestorPositionCombineDetail, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询保证金监管系统经纪公司资金账户密钥
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcCFMMCTradingAccountKeyField>>>
    ReqQryCFMMCTradingAccountKeyAsync(CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey)
    {
        var pending = new PendingRequest<List<CThostFtdcCFMMCTradingAccountKeyField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryCFMMCTradingAccountKey(ref pQryCFMMCTradingAccountKey, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询仓单折抵信息
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcEWarrantOffsetField>>>
    ReqQryEWarrantOffsetAsync(CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset)
    {
        var pending = new PendingRequest<List<CThostFtdcEWarrantOffsetField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryEWarrantOffset(ref pQryEWarrantOffset, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资者品种/跨品种保证金
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorProductGroupMarginField>>>
    ReqQryInvestorProductGroupMarginAsync(CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorProductGroupMarginField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorProductGroupMargin(ref pQryInvestorProductGroupMargin, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易所保证金率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcExchangeMarginRateField>>>
    ReqQryExchangeMarginRateAsync(CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate)
    {
        var pending = new PendingRequest<List<CThostFtdcExchangeMarginRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryExchangeMarginRate(ref pQryExchangeMarginRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易所调整保证金率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcExchangeMarginRateAdjustField>>>
    ReqQryExchangeMarginRateAdjustAsync(CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust)
    {
        var pending = new PendingRequest<List<CThostFtdcExchangeMarginRateAdjustField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryExchangeMarginRateAdjust(ref pQryExchangeMarginRateAdjust, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询汇率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcExchangeRateField>>>
    ReqQryExchangeRateAsync(CThostFtdcQryExchangeRateField pQryExchangeRate)
    {
        var pending = new PendingRequest<List<CThostFtdcExchangeRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryExchangeRate(ref pQryExchangeRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询二级代理操作员银期权限
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSecAgentACIDMapField>>>
    ReqQrySecAgentACIDMapAsync(CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap)
    {
        var pending = new PendingRequest<List<CThostFtdcSecAgentACIDMapField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySecAgentACIDMap(ref pQrySecAgentACIDMap, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询产品报价汇率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcProductExchRateField>>>
    ReqQryProductExchRateAsync(CThostFtdcQryProductExchRateField pQryProductExchRate)
    {
        var pending = new PendingRequest<List<CThostFtdcProductExchRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryProductExchRate(ref pQryProductExchRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询产品组
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcProductGroupField>>>
    ReqQryProductGroupAsync(CThostFtdcQryProductGroupField pQryProductGroup)
    {
        var pending = new PendingRequest<List<CThostFtdcProductGroupField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryProductGroup(ref pQryProductGroup, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询做市商合约手续费率
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcMMInstrumentCommissionRateField>>>
    ReqQryMMInstrumentCommissionRateAsync(CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate)
    {
        var pending = new PendingRequest<List<CThostFtdcMMInstrumentCommissionRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryMMInstrumentCommissionRate(ref pQryMMInstrumentCommissionRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询做市商期权合约手续费
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcMMOptionInstrCommRateField>>>
    ReqQryMMOptionInstrCommRateAsync(CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate)
    {
        var pending = new PendingRequest<List<CThostFtdcMMOptionInstrCommRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryMMOptionInstrCommRate(ref pQryMMOptionInstrCommRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询报单手续费
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInstrumentOrderCommRateField>>>
    ReqQryInstrumentOrderCommRateAsync(CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate)
    {
        var pending = new PendingRequest<List<CThostFtdcInstrumentOrderCommRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInstrumentOrderCommRate(ref pQryInstrumentOrderCommRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询资金账户
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradingAccountField>>>
    ReqQrySecAgentTradingAccountAsync(CThostFtdcQryTradingAccountField pQryTradingAccount)
    {
        var pending = new PendingRequest<List<CThostFtdcTradingAccountField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySecAgentTradingAccount(ref pQryTradingAccount, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询二级代理商资金校验模式
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSecAgentCheckModeField>>>
    ReqQrySecAgentCheckModeAsync(CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode)
    {
        var pending = new PendingRequest<List<CThostFtdcSecAgentCheckModeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySecAgentCheckMode(ref pQrySecAgentCheckMode, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询二级代理商信息
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSecAgentTradeInfoField>>>
    ReqQrySecAgentTradeInfoAsync(CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo)
    {
        var pending = new PendingRequest<List<CThostFtdcSecAgentTradeInfoField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySecAgentTradeInfo(ref pQrySecAgentTradeInfo, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询期权交易成本
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcOptionInstrTradeCostField>>>
    ReqQryOptionInstrTradeCostAsync(CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost)
    {
        var pending = new PendingRequest<List<CThostFtdcOptionInstrTradeCostField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryOptionInstrTradeCost(ref pQryOptionInstrTradeCost, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询期权合约手续费
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcOptionInstrCommRateField>>>
    ReqQryOptionInstrCommRateAsync(CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate)
    {
        var pending = new PendingRequest<List<CThostFtdcOptionInstrCommRateField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryOptionInstrCommRate(ref pQryOptionInstrCommRate, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询执行宣告
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcExecOrderField>>>
    ReqQryExecOrderAsync(CThostFtdcQryExecOrderField pQryExecOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcExecOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryExecOrder(ref pQryExecOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询询价
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcForQuoteField>>>
    ReqQryForQuoteAsync(CThostFtdcQryForQuoteField pQryForQuote)
    {
        var pending = new PendingRequest<List<CThostFtdcForQuoteField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryForQuote(ref pQryForQuote, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询报价
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcQuoteField>>>
    ReqQryQuoteAsync(CThostFtdcQryQuoteField pQryQuote)
    {
        var pending = new PendingRequest<List<CThostFtdcQuoteField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryQuote(ref pQryQuote, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询期权自对冲
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcOptionSelfCloseField>>>
    ReqQryOptionSelfCloseAsync(CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose)
    {
        var pending = new PendingRequest<List<CThostFtdcOptionSelfCloseField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryOptionSelfClose(ref pQryOptionSelfClose, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询投资单元
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestUnitField>>>
    ReqQryInvestUnitAsync(CThostFtdcQryInvestUnitField pQryInvestUnit)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestUnitField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestUnit(ref pQryInvestUnit, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询组合合约安全系数
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcCombInstrumentGuardField>>>
    ReqQryCombInstrumentGuardAsync(CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard)
    {
        var pending = new PendingRequest<List<CThostFtdcCombInstrumentGuardField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryCombInstrumentGuard(ref pQryCombInstrumentGuard, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询申请组合
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcCombActionField>>>
    ReqQryCombActionAsync(CThostFtdcQryCombActionField pQryCombAction)
    {
        var pending = new PendingRequest<List<CThostFtdcCombActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryCombAction(ref pQryCombAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询转帐流水
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTransferSerialField>>>
    ReqQryTransferSerialAsync(CThostFtdcQryTransferSerialField pQryTransferSerial)
    {
        var pending = new PendingRequest<List<CThostFtdcTransferSerialField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTransferSerial(ref pQryTransferSerial, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询银期签约关系
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcAccountregisterField>>>
    ReqQryAccountregisterAsync(CThostFtdcQryAccountregisterField pQryAccountregister)
    {
        var pending = new PendingRequest<List<CThostFtdcAccountregisterField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryAccountregister(ref pQryAccountregister, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询签约银行
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcContractBankField>>>
    ReqQryContractBankAsync(CThostFtdcQryContractBankField pQryContractBank)
    {
        var pending = new PendingRequest<List<CThostFtdcContractBankField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryContractBank(ref pQryContractBank, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询预埋单
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcParkedOrderField>>>
    ReqQryParkedOrderAsync(CThostFtdcQryParkedOrderField pQryParkedOrder)
    {
        var pending = new PendingRequest<List<CThostFtdcParkedOrderField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryParkedOrder(ref pQryParkedOrder, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询预埋撤单
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcParkedOrderActionField>>>
    ReqQryParkedOrderActionAsync(CThostFtdcQryParkedOrderActionField pQryParkedOrderAction)
    {
        var pending = new PendingRequest<List<CThostFtdcParkedOrderActionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryParkedOrderAction(ref pQryParkedOrderAction, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询交易通知
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcTradingNoticeField>>>
    ReqQryTradingNoticeAsync(CThostFtdcQryTradingNoticeField pQryTradingNotice)
    {
        var pending = new PendingRequest<List<CThostFtdcTradingNoticeField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryTradingNotice(ref pQryTradingNotice, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询经纪公司交易参数
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcBrokerTradingParamsField>>>
    ReqQryBrokerTradingParamsAsync(CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams)
    {
        var pending = new PendingRequest<List<CThostFtdcBrokerTradingParamsField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryBrokerTradingParams(ref pQryBrokerTradingParams, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询经纪公司交易算法
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcBrokerTradingAlgosField>>>
    ReqQryBrokerTradingAlgosAsync(CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos)
    {
        var pending = new PendingRequest<List<CThostFtdcBrokerTradingAlgosField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryBrokerTradingAlgos(ref pQryBrokerTradingAlgos, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询监控中心用户令牌
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcQueryCFMMCTradingAccountTokenField>>>
    ReqQueryCFMMCTradingAccountTokenAsync(CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken)
    {
        var pending = new PendingRequest<List<CThostFtdcQueryCFMMCTradingAccountTokenField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQueryCFMMCTradingAccountToken(ref pQueryCFMMCTradingAccountToken, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 期货发起银行资金转期货请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcReqTransferField>>>
    ReqFromBankToFutureByFutureAsync(CThostFtdcReqTransferField pReqTransfer)
    {
        var pending = new PendingRequest<List<CThostFtdcReqTransferField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqFromBankToFutureByFuture(ref pReqTransfer, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 期货发起期货资金转银行请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcReqTransferField>>>
    ReqFromFutureToBankByFutureAsync(CThostFtdcReqTransferField pReqTransfer)
    {
        var pending = new PendingRequest<List<CThostFtdcReqTransferField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqFromFutureToBankByFuture(ref pReqTransfer, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 期货发起查询银行余额请求
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcReqQueryAccountField>>>
    ReqQueryBankAccountMoneyByFutureAsync(CThostFtdcReqQueryAccountField pReqQueryAccount)
    {
        var pending = new PendingRequest<List<CThostFtdcReqQueryAccountField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQueryBankAccountMoneyByFuture(ref pReqQueryAccount, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求查询分类合约
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInstrumentField>>>
    ReqQryClassifiedInstrumentAsync(CThostFtdcQryClassifiedInstrumentField pQryClassifiedInstrument)
    {
        var pending = new PendingRequest<List<CThostFtdcInstrumentField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryClassifiedInstrument(ref pQryClassifiedInstrument, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 请求组合优惠比例
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcCombPromotionParamField>>>
    ReqQryCombPromotionParamAsync(CThostFtdcQryCombPromotionParamField pQryCombPromotionParam)
    {
        var pending = new PendingRequest<List<CThostFtdcCombPromotionParamField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryCombPromotionParam(ref pQryCombPromotionParam, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 投资者风险结算持仓查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRiskSettleInvstPositionField>>>
    ReqQryRiskSettleInvstPositionAsync(CThostFtdcQryRiskSettleInvstPositionField pQryRiskSettleInvstPosition)
    {
        var pending = new PendingRequest<List<CThostFtdcRiskSettleInvstPositionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryRiskSettleInvstPosition(ref pQryRiskSettleInvstPosition, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 风险结算产品查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcRiskSettleProductStatusField>>>
    ReqQryRiskSettleProductStatusAsync(CThostFtdcQryRiskSettleProductStatusField pQryRiskSettleProductStatus)
    {
        var pending = new PendingRequest<List<CThostFtdcRiskSettleProductStatusField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryRiskSettleProductStatus(ref pQryRiskSettleProductStatus, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// SPBM期货合约参数查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMFutureParameterField>>>
    ReqQrySPBMFutureParameterAsync(CThostFtdcQrySPBMFutureParameterField pQrySPBMFutureParameter)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMFutureParameterField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMFutureParameter(ref pQrySPBMFutureParameter, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// SPBM期权合约参数查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMOptionParameterField>>>
    ReqQrySPBMOptionParameterAsync(CThostFtdcQrySPBMOptionParameterField pQrySPBMOptionParameter)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMOptionParameterField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMOptionParameter(ref pQrySPBMOptionParameter, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// SPBM品种内对锁仓折扣参数查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMIntraParameterField>>>
    ReqQrySPBMIntraParameterAsync(CThostFtdcQrySPBMIntraParameterField pQrySPBMIntraParameter)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMIntraParameterField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMIntraParameter(ref pQrySPBMIntraParameter, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// SPBM跨品种抵扣参数查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMInterParameterField>>>
    ReqQrySPBMInterParameterAsync(CThostFtdcQrySPBMInterParameterField pQrySPBMInterParameter)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMInterParameterField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMInterParameter(ref pQrySPBMInterParameter, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// SPBM组合保证金套餐查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMPortfDefinitionField>>>
    ReqQrySPBMPortfDefinitionAsync(CThostFtdcQrySPBMPortfDefinitionField pQrySPBMPortfDefinition)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMPortfDefinitionField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMPortfDefinition(ref pQrySPBMPortfDefinition, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 投资者SPBM套餐选择查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcSPBMInvestorPortfDefField>>>
    ReqQrySPBMInvestorPortfDefAsync(CThostFtdcQrySPBMInvestorPortfDefField pQrySPBMInvestorPortfDef)
    {
        var pending = new PendingRequest<List<CThostFtdcSPBMInvestorPortfDefField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQrySPBMInvestorPortfDef(ref pQrySPBMInvestorPortfDef, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 投资者新型组合保证金系数查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorPortfMarginRatioField>>>
    ReqQryInvestorPortfMarginRatioAsync(CThostFtdcQryInvestorPortfMarginRatioField pQryInvestorPortfMarginRatio)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorPortfMarginRatioField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorPortfMarginRatio(ref pQryInvestorPortfMarginRatio, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }

    /// <summary>
    /// 投资者产品SPBM明细查询
    /// </summary>
    public async Task<CTPResponse<List<CThostFtdcInvestorProdSPBMDetailField>>>
    ReqQryInvestorProdSPBMDetailAsync(CThostFtdcQryInvestorProdSPBMDetailField pQryInvestorProdSPBMDetail)
    {
        var pending = new PendingRequest<List<CThostFtdcInvestorProdSPBMDetailField>> (_requestId.Next());
        _spi.CachePendingRequest(pending);
        while (_api.ReqQryInvestorProdSPBMDetail(ref pQryInvestorProdSPBMDetail, pending.RequestId) != 0) await Task.Delay(1000);
        return await pending.Task.ConfigureAwait(false);
    }
}
