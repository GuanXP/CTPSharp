using System.Diagnostics;
namespace XP.CTPSharp;
internal partial class TdSPI
{
    internal event Action? FrontConnected;
    internal event Action<int>? FrontDisconnected;
    internal event Action<int>? HeartBeatWarning;
    internal event Action<CThostFtdcOrderField>? RtnOrder;
    internal event Action<CThostFtdcTradeField>? RtnTrade;
    internal event Action<ErrorReturn<CThostFtdcInputOrderField>>? ErrRtnOrderInsert;
    internal event Action<ErrorReturn<CThostFtdcOrderActionField>>? ErrRtnOrderAction;
    internal event Action<CThostFtdcInstrumentStatusField>? RtnInstrumentStatus;
    internal event Action<CThostFtdcBulletinField>? RtnBulletin;
    internal event Action<CThostFtdcTradingNoticeInfoField>? RtnTradingNotice;
    internal event Action<CThostFtdcErrorConditionalOrderField>? RtnErrorConditionalOrder;
    internal event Action<CThostFtdcExecOrderField>? RtnExecOrder;
    internal event Action<ErrorReturn<CThostFtdcInputExecOrderField>>? ErrRtnExecOrderInsert;
    internal event Action<ErrorReturn<CThostFtdcExecOrderActionField>>? ErrRtnExecOrderAction;
    internal event Action<ErrorReturn<CThostFtdcInputForQuoteField>>? ErrRtnForQuoteInsert;
    internal event Action<CThostFtdcQuoteField>? RtnQuote;
    internal event Action<ErrorReturn<CThostFtdcInputQuoteField>>? ErrRtnQuoteInsert;
    internal event Action<ErrorReturn<CThostFtdcQuoteActionField>>? ErrRtnQuoteAction;
    internal event Action<CThostFtdcForQuoteRspField>? RtnForQuoteRsp;
    internal event Action<CThostFtdcCFMMCTradingAccountTokenField>? RtnCFMMCTradingAccountToken;
    internal event Action<ErrorReturn<CThostFtdcBatchOrderActionField>>? ErrRtnBatchOrderAction;
    internal event Action<CThostFtdcOptionSelfCloseField>? RtnOptionSelfClose;
    internal event Action<ErrorReturn<CThostFtdcInputOptionSelfCloseField>>? ErrRtnOptionSelfCloseInsert;
    internal event Action<ErrorReturn<CThostFtdcOptionSelfCloseActionField>>? ErrRtnOptionSelfCloseAction;
    internal event Action<CThostFtdcCombActionField>? RtnCombAction;
    internal event Action<ErrorReturn<CThostFtdcInputCombActionField>>? ErrRtnCombActionInsert;
    internal event Action<CThostFtdcRspTransferField>? RtnFromBankToFutureByBank;
    internal event Action<CThostFtdcRspTransferField>? RtnFromFutureToBankByBank;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByBank;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByBank;
    internal event Action<CThostFtdcRspTransferField>? RtnFromBankToFutureByFuture;
    internal event Action<CThostFtdcRspTransferField>? RtnFromFutureToBankByFuture;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByFutureManual;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByFutureManual;
    internal event Action<CThostFtdcNotifyQueryAccountField>? RtnQueryBankBalanceByFuture;
    internal event Action<ErrorReturn<CThostFtdcReqTransferField>>? ErrRtnBankToFutureByFuture;
    internal event Action<ErrorReturn<CThostFtdcReqTransferField>>? ErrRtnFutureToBankByFuture;
    internal event Action<ErrorReturn<CThostFtdcReqRepealField>>? ErrRtnRepealBankToFutureByFutureManual;
    internal event Action<ErrorReturn<CThostFtdcReqRepealField>>? ErrRtnRepealFutureToBankByFutureManual;
    internal event Action<ErrorReturn<CThostFtdcReqQueryAccountField>>? ErrRtnQueryBankBalanceByFuture;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromBankToFutureByFuture;
    internal event Action<CThostFtdcRspRepealField>? RtnRepealFromFutureToBankByFuture;
    internal event Action<CThostFtdcOpenAccountField>? RtnOpenAccountByBank;
    internal event Action<CThostFtdcCancelAccountField>? RtnCancelAccountByBank;
    internal event Action<CThostFtdcChangeAccountField>? RtnChangeAccountByBank;
    public sealed override void OnFrontConnected()
    {
        FrontConnected?.Invoke();
    }
    public sealed override void OnFrontDisconnected(int nReason)
    {
        FrontDisconnected?.Invoke(nReason);
    }
    public sealed override void OnHeartBeatWarning(int nTimeLapse)
    {
        HeartBeatWarning?.Invoke(nTimeLapse);
    }
    public sealed override void OnRtnOrder(ref CThostFtdcOrderField pOrder)
    {
        RtnOrder?.Invoke(pOrder);
    }
    public sealed override void OnRtnTrade(ref CThostFtdcTradeField pTrade)
    {
        RtnTrade?.Invoke(pTrade);
    }
    public sealed override void OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnOrderInsert?.Invoke(new ErrorReturn<CThostFtdcInputOrderField>(pInputOrder, pRspInfo));
    }
    public sealed override void OnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnOrderAction?.Invoke(new ErrorReturn<CThostFtdcOrderActionField>(pOrderAction, pRspInfo));
    }
    public sealed override void OnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus)
    {
        RtnInstrumentStatus?.Invoke(pInstrumentStatus);
    }
    public sealed override void OnRtnBulletin(ref CThostFtdcBulletinField pBulletin)
    {
        RtnBulletin?.Invoke(pBulletin);
    }
    public sealed override void OnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo)
    {
        RtnTradingNotice?.Invoke(pTradingNoticeInfo);
    }
    public sealed override void OnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder)
    {
        RtnErrorConditionalOrder?.Invoke(pErrorConditionalOrder);
    }
    public sealed override void OnRtnExecOrder(ref CThostFtdcExecOrderField pExecOrder)
    {
        RtnExecOrder?.Invoke(pExecOrder);
    }
    public sealed override void OnErrRtnExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnExecOrderInsert?.Invoke(new ErrorReturn<CThostFtdcInputExecOrderField>(pInputExecOrder, pRspInfo));
    }
    public sealed override void OnErrRtnExecOrderAction(ref CThostFtdcExecOrderActionField pExecOrderAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnExecOrderAction?.Invoke(new ErrorReturn<CThostFtdcExecOrderActionField>(pExecOrderAction, pRspInfo));
    }
    public sealed override void OnErrRtnForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnForQuoteInsert?.Invoke(new ErrorReturn<CThostFtdcInputForQuoteField>(pInputForQuote, pRspInfo));
    }
    public sealed override void OnRtnQuote(ref CThostFtdcQuoteField pQuote)
    {
        RtnQuote?.Invoke(pQuote);
    }
    public sealed override void OnErrRtnQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnQuoteInsert?.Invoke(new ErrorReturn<CThostFtdcInputQuoteField>(pInputQuote, pRspInfo));
    }
    public sealed override void OnErrRtnQuoteAction(ref CThostFtdcQuoteActionField pQuoteAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnQuoteAction?.Invoke(new ErrorReturn<CThostFtdcQuoteActionField>(pQuoteAction, pRspInfo));
    }
    public sealed override void OnRtnForQuoteRsp(ref CThostFtdcForQuoteRspField pForQuoteRsp)
    {
        RtnForQuoteRsp?.Invoke(pForQuoteRsp);
    }
    public sealed override void OnRtnCFMMCTradingAccountToken(ref CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken)
    {
        RtnCFMMCTradingAccountToken?.Invoke(pCFMMCTradingAccountToken);
    }
    public sealed override void OnErrRtnBatchOrderAction(ref CThostFtdcBatchOrderActionField pBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnBatchOrderAction?.Invoke(new ErrorReturn<CThostFtdcBatchOrderActionField>(pBatchOrderAction, pRspInfo));
    }
    public sealed override void OnRtnOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose)
    {
        RtnOptionSelfClose?.Invoke(pOptionSelfClose);
    }
    public sealed override void OnErrRtnOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnOptionSelfCloseInsert?.Invoke(new ErrorReturn<CThostFtdcInputOptionSelfCloseField>(pInputOptionSelfClose, pRspInfo));
    }
    public sealed override void OnErrRtnOptionSelfCloseAction(ref CThostFtdcOptionSelfCloseActionField pOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnOptionSelfCloseAction?.Invoke(new ErrorReturn<CThostFtdcOptionSelfCloseActionField>(pOptionSelfCloseAction, pRspInfo));
    }
    public sealed override void OnRtnCombAction(ref CThostFtdcCombActionField pCombAction)
    {
        RtnCombAction?.Invoke(pCombAction);
    }
    public sealed override void OnErrRtnCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnCombActionInsert?.Invoke(new ErrorReturn<CThostFtdcInputCombActionField>(pInputCombAction, pRspInfo));
    }
    public sealed override void OnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer)
    {
        RtnFromBankToFutureByBank?.Invoke(pRspTransfer);
    }
    public sealed override void OnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer)
    {
        RtnFromFutureToBankByBank?.Invoke(pRspTransfer);
    }
    public sealed override void OnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromBankToFutureByBank?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromFutureToBankByBank?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer)
    {
        RtnFromBankToFutureByFuture?.Invoke(pRspTransfer);
    }
    public sealed override void OnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer)
    {
        RtnFromFutureToBankByFuture?.Invoke(pRspTransfer);
    }
    public sealed override void OnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromBankToFutureByFutureManual?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromFutureToBankByFutureManual?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount)
    {
        RtnQueryBankBalanceByFuture?.Invoke(pNotifyQueryAccount);
    }
    public sealed override void OnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnBankToFutureByFuture?.Invoke(new ErrorReturn<CThostFtdcReqTransferField>(pReqTransfer, pRspInfo));
    }
    public sealed override void OnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnFutureToBankByFuture?.Invoke(new ErrorReturn<CThostFtdcReqTransferField>(pReqTransfer, pRspInfo));
    }
    public sealed override void OnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnRepealBankToFutureByFutureManual?.Invoke(new ErrorReturn<CThostFtdcReqRepealField>(pReqRepeal, pRspInfo));
    }
    public sealed override void OnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnRepealFutureToBankByFutureManual?.Invoke(new ErrorReturn<CThostFtdcReqRepealField>(pReqRepeal, pRspInfo));
    }
    public sealed override void OnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo)
    {
        ErrRtnQueryBankBalanceByFuture?.Invoke(new ErrorReturn<CThostFtdcReqQueryAccountField>(pReqQueryAccount, pRspInfo));
    }
    public sealed override void OnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromBankToFutureByFuture?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal)
    {
        RtnRepealFromFutureToBankByFuture?.Invoke(pRspRepeal);
    }
    public sealed override void OnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount)
    {
        RtnOpenAccountByBank?.Invoke(pOpenAccount);
    }
    public sealed override void OnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount)
    {
        RtnCancelAccountByBank?.Invoke(pCancelAccount);
    }
    public sealed override void OnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount)
    {
        RtnChangeAccountByBank?.Invoke(pChangeAccount);
    }
    public sealed override void OnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRspAuthenticateField,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRspUserLogin,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pUserLogout,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pUserPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTradingAccountPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspUserAuthMethod(ref CThostFtdcRspUserAuthMethodField pRspUserAuthMethod,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRspUserAuthMethod,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspGenUserCaptcha(ref CThostFtdcRspGenUserCaptchaField pRspGenUserCaptcha,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRspGenUserCaptcha,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspGenUserText(ref CThostFtdcRspGenUserTextField pRspGenUserText,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRspGenUserText,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryMaxOrderVolume(ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pQryMaxOrderVolume,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRemoveParkedOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRemoveParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputExecOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspExecOrderAction(ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputExecOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputForQuote,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputQuote,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQuoteAction(ref CThostFtdcInputQuoteActionField pInputQuoteAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputQuoteAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspBatchOrderAction(ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputBatchOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspOptionSelfCloseAction(ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputOptionSelfCloseAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInputCombAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryOrder(ref CThostFtdcOrderField pOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTrade(ref CThostFtdcTradeField pTrade,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTrade,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorPosition,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestor(ref CThostFtdcInvestorField pInvestor,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestor,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTradingCode,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInstrumentMarginRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryExchange(ref CThostFtdcExchangeField pExchange,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pExchange,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryProduct(ref CThostFtdcProductField pProduct,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pProduct,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInstrument,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pDepthMarketData,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTraderOffer(ref CThostFtdcTraderOfferField pTraderOffer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTraderOffer,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSettlementInfo,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTransferBank,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorPositionDetail,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryNotice(ref CThostFtdcNoticeField pNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pNotice,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorPositionCombineDetail,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pCFMMCTradingAccountKey,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pEWarrantOffset,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorProductGroupMargin(ref CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorProductGroupMargin,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryExchangeMarginRate(ref CThostFtdcExchangeMarginRateField pExchangeMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pExchangeMarginRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryExchangeMarginRateAdjust(ref CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pExchangeMarginRateAdjust,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryExchangeRate(ref CThostFtdcExchangeRateField pExchangeRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pExchangeRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySecAgentACIDMap(ref CThostFtdcSecAgentACIDMapField pSecAgentACIDMap,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSecAgentACIDMap,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryProductExchRate(ref CThostFtdcProductExchRateField pProductExchRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pProductExchRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryProductGroup(ref CThostFtdcProductGroupField pProductGroup,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pProductGroup,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryMMInstrumentCommissionRate(ref CThostFtdcMMInstrumentCommissionRateField pMMInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pMMInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryMMOptionInstrCommRate(ref CThostFtdcMMOptionInstrCommRateField pMMOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pMMOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInstrumentOrderCommRate(ref CThostFtdcInstrumentOrderCommRateField pInstrumentOrderCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInstrumentOrderCommRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySecAgentTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySecAgentCheckMode(ref CThostFtdcSecAgentCheckModeField pSecAgentCheckMode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSecAgentCheckMode,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySecAgentTradeInfo(ref CThostFtdcSecAgentTradeInfoField pSecAgentTradeInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSecAgentTradeInfo,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryOptionInstrTradeCost(ref CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pOptionInstrTradeCost,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryOptionInstrCommRate(ref CThostFtdcOptionInstrCommRateField pOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryExecOrder(ref CThostFtdcExecOrderField pExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pExecOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryForQuote(ref CThostFtdcForQuoteField pForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pForQuote,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryQuote(ref CThostFtdcQuoteField pQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pQuote,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestUnit(ref CThostFtdcInvestUnitField pInvestUnit,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestUnit,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryCombInstrumentGuard(ref CThostFtdcCombInstrumentGuardField pCombInstrumentGuard,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pCombInstrumentGuard,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryCombAction(ref CThostFtdcCombActionField pCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pCombAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTransferSerial,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pAccountregister,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryContractBank(ref CThostFtdcContractBankField pContractBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pContractBank,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pTradingNotice,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pBrokerTradingParams,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pBrokerTradingAlgos,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQueryCFMMCTradingAccountToken(ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pQueryCFMMCTradingAccountToken,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pReqQueryAccount,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryClassifiedInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInstrument,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryCombPromotionParam(ref CThostFtdcCombPromotionParamField pCombPromotionParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pCombPromotionParam,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRiskSettleInvstPosition(ref CThostFtdcRiskSettleInvstPositionField pRiskSettleInvstPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRiskSettleInvstPosition,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRiskSettleProductStatus(ref CThostFtdcRiskSettleProductStatusField pRiskSettleProductStatus,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRiskSettleProductStatus,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMFutureParameter(ref CThostFtdcSPBMFutureParameterField pSPBMFutureParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMFutureParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMOptionParameter(ref CThostFtdcSPBMOptionParameterField pSPBMOptionParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMOptionParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMIntraParameter(ref CThostFtdcSPBMIntraParameterField pSPBMIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMIntraParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMInterParameter(ref CThostFtdcSPBMInterParameterField pSPBMInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMInterParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMPortfDefinition(ref CThostFtdcSPBMPortfDefinitionField pSPBMPortfDefinition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMPortfDefinition,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMInvestorPortfDef(ref CThostFtdcSPBMInvestorPortfDefField pSPBMInvestorPortfDef,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMInvestorPortfDef,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorPortfMarginRatio(ref CThostFtdcInvestorPortfMarginRatioField pInvestorPortfMarginRatio,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorPortfMarginRatio,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorProdSPBMDetail(ref CThostFtdcInvestorProdSPBMDetailField pInvestorProdSPBMDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorProdSPBMDetail,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorCommoditySPMMMargin(ref CThostFtdcInvestorCommoditySPMMMarginField pInvestorCommoditySPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorCommoditySPMMMargin,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorCommodityGroupSPMMMargin(ref CThostFtdcInvestorCommodityGroupSPMMMarginField pInvestorCommodityGroupSPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorCommodityGroupSPMMMargin,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPMMInstParam(ref CThostFtdcSPMMInstParamField pSPMMInstParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPMMInstParam,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPMMProductParam(ref CThostFtdcSPMMProductParamField pSPMMProductParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPMMProductParam,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQrySPBMAddOnInterParameter(ref CThostFtdcSPBMAddOnInterParameterField pSPBMAddOnInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pSPBMAddOnInterParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSCombProductInfo(ref CThostFtdcRCAMSCombProductInfoField pRCAMSCombProductInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSCombProductInfo,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSInstrParameter(ref CThostFtdcRCAMSInstrParameterField pRCAMSInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSInstrParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSIntraParameter(ref CThostFtdcRCAMSIntraParameterField pRCAMSIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSIntraParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSInterParameter(ref CThostFtdcRCAMSInterParameterField pRCAMSInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSInterParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSShortOptAdjustParam(ref CThostFtdcRCAMSShortOptAdjustParamField pRCAMSShortOptAdjustParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSShortOptAdjustParam,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRCAMSInvestorCombPosition(ref CThostFtdcRCAMSInvestorCombPositionField pRCAMSInvestorCombPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRCAMSInvestorCombPosition,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorProdRCAMSMargin(ref CThostFtdcInvestorProdRCAMSMarginField pInvestorProdRCAMSMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorProdRCAMSMargin,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRULEInstrParameter(ref CThostFtdcRULEInstrParameterField pRULEInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRULEInstrParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRULEIntraParameter(ref CThostFtdcRULEIntraParameterField pRULEIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRULEIntraParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryRULEInterParameter(ref CThostFtdcRULEInterParameterField pRULEInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pRULEInterParameter,pRspInfo,nRequestID,bIsLast);
    }
    public sealed override void OnRspQryInvestorProdRULEMargin(ref CThostFtdcInvestorProdRULEMarginField pInvestorProdRULEMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast)
    {
        CompleteListPending(pInvestorProdRULEMargin,pRspInfo,nRequestID,bIsLast);
    }
}
