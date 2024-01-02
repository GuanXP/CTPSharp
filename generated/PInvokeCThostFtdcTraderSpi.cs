using System.Runtime.InteropServices;
namespace XP.CTPSharp;

[StructLayout(LayoutKind.Sequential, CharSet = CharSet.Ansi)]
internal struct CTPSharp_CThostFtdcTraderSpi
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
    internal delegate void DelOnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspAuthenticate OnRspAuthenticate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserLogin OnRspUserLogin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserLogout OnRspUserLogout;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserPasswordUpdate OnRspUserPasswordUpdate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspTradingAccountPasswordUpdate OnRspTradingAccountPasswordUpdate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspUserAuthMethod(ref CThostFtdcRspUserAuthMethodField pRspUserAuthMethod,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspUserAuthMethod OnRspUserAuthMethod;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspGenUserCaptcha(ref CThostFtdcRspGenUserCaptchaField pRspGenUserCaptcha,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspGenUserCaptcha OnRspGenUserCaptcha;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspGenUserText(ref CThostFtdcRspGenUserTextField pRspGenUserText,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspGenUserText OnRspGenUserText;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspOrderInsert OnRspOrderInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspParkedOrderInsert OnRspParkedOrderInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspParkedOrderAction OnRspParkedOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspOrderAction OnRspOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryMaxOrderVolume(ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryMaxOrderVolume OnRspQryMaxOrderVolume;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspSettlementInfoConfirm OnRspSettlementInfoConfirm;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspRemoveParkedOrder OnRspRemoveParkedOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspRemoveParkedOrderAction OnRspRemoveParkedOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspExecOrderInsert OnRspExecOrderInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspExecOrderAction(ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspExecOrderAction OnRspExecOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspForQuoteInsert OnRspForQuoteInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQuoteInsert OnRspQuoteInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQuoteAction(ref CThostFtdcInputQuoteActionField pInputQuoteAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQuoteAction OnRspQuoteAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspBatchOrderAction(ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspBatchOrderAction OnRspBatchOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspOptionSelfCloseInsert OnRspOptionSelfCloseInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspOptionSelfCloseAction(ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspOptionSelfCloseAction OnRspOptionSelfCloseAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspCombActionInsert OnRspCombActionInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryOrder(ref CThostFtdcOrderField pOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryOrder OnRspQryOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTrade(ref CThostFtdcTradeField pTrade,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTrade OnRspQryTrade;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorPosition OnRspQryInvestorPosition;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTradingAccount OnRspQryTradingAccount;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestor(ref CThostFtdcInvestorField pInvestor,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestor OnRspQryInvestor;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTradingCode OnRspQryTradingCode;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInstrumentMarginRate OnRspQryInstrumentMarginRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInstrumentCommissionRate OnRspQryInstrumentCommissionRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryExchange(ref CThostFtdcExchangeField pExchange,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryExchange OnRspQryExchange;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryProduct(ref CThostFtdcProductField pProduct,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryProduct OnRspQryProduct;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInstrument OnRspQryInstrument;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryDepthMarketData OnRspQryDepthMarketData;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTraderOffer(ref CThostFtdcTraderOfferField pTraderOffer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTraderOffer OnRspQryTraderOffer;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySettlementInfo OnRspQrySettlementInfo;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTransferBank OnRspQryTransferBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorPositionDetail OnRspQryInvestorPositionDetail;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryNotice(ref CThostFtdcNoticeField pNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryNotice OnRspQryNotice;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySettlementInfoConfirm OnRspQrySettlementInfoConfirm;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorPositionCombineDetail OnRspQryInvestorPositionCombineDetail;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryCFMMCTradingAccountKey OnRspQryCFMMCTradingAccountKey;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryEWarrantOffset OnRspQryEWarrantOffset;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorProductGroupMargin(ref CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorProductGroupMargin OnRspQryInvestorProductGroupMargin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryExchangeMarginRate(ref CThostFtdcExchangeMarginRateField pExchangeMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryExchangeMarginRate OnRspQryExchangeMarginRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryExchangeMarginRateAdjust(ref CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryExchangeMarginRateAdjust OnRspQryExchangeMarginRateAdjust;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryExchangeRate(ref CThostFtdcExchangeRateField pExchangeRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryExchangeRate OnRspQryExchangeRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySecAgentACIDMap(ref CThostFtdcSecAgentACIDMapField pSecAgentACIDMap,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySecAgentACIDMap OnRspQrySecAgentACIDMap;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryProductExchRate(ref CThostFtdcProductExchRateField pProductExchRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryProductExchRate OnRspQryProductExchRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryProductGroup(ref CThostFtdcProductGroupField pProductGroup,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryProductGroup OnRspQryProductGroup;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryMMInstrumentCommissionRate(ref CThostFtdcMMInstrumentCommissionRateField pMMInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryMMInstrumentCommissionRate OnRspQryMMInstrumentCommissionRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryMMOptionInstrCommRate(ref CThostFtdcMMOptionInstrCommRateField pMMOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryMMOptionInstrCommRate OnRspQryMMOptionInstrCommRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInstrumentOrderCommRate(ref CThostFtdcInstrumentOrderCommRateField pInstrumentOrderCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInstrumentOrderCommRate OnRspQryInstrumentOrderCommRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySecAgentTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySecAgentTradingAccount OnRspQrySecAgentTradingAccount;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySecAgentCheckMode(ref CThostFtdcSecAgentCheckModeField pSecAgentCheckMode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySecAgentCheckMode OnRspQrySecAgentCheckMode;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySecAgentTradeInfo(ref CThostFtdcSecAgentTradeInfoField pSecAgentTradeInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySecAgentTradeInfo OnRspQrySecAgentTradeInfo;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryOptionInstrTradeCost(ref CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryOptionInstrTradeCost OnRspQryOptionInstrTradeCost;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryOptionInstrCommRate(ref CThostFtdcOptionInstrCommRateField pOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryOptionInstrCommRate OnRspQryOptionInstrCommRate;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryExecOrder(ref CThostFtdcExecOrderField pExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryExecOrder OnRspQryExecOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryForQuote(ref CThostFtdcForQuoteField pForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryForQuote OnRspQryForQuote;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryQuote(ref CThostFtdcQuoteField pQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryQuote OnRspQryQuote;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryOptionSelfClose OnRspQryOptionSelfClose;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestUnit(ref CThostFtdcInvestUnitField pInvestUnit,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestUnit OnRspQryInvestUnit;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryCombInstrumentGuard(ref CThostFtdcCombInstrumentGuardField pCombInstrumentGuard,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryCombInstrumentGuard OnRspQryCombInstrumentGuard;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryCombAction(ref CThostFtdcCombActionField pCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryCombAction OnRspQryCombAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTransferSerial OnRspQryTransferSerial;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryAccountregister OnRspQryAccountregister;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspError(ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspError OnRspError;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnOrder(ref CThostFtdcOrderField pOrder);
    internal DelOnRtnOrder OnRtnOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnTrade(ref CThostFtdcTradeField pTrade);
    internal DelOnRtnTrade OnRtnTrade;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnOrderInsert OnErrRtnOrderInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnOrderAction OnErrRtnOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus);
    internal DelOnRtnInstrumentStatus OnRtnInstrumentStatus;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnBulletin(ref CThostFtdcBulletinField pBulletin);
    internal DelOnRtnBulletin OnRtnBulletin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo);
    internal DelOnRtnTradingNotice OnRtnTradingNotice;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder);
    internal DelOnRtnErrorConditionalOrder OnRtnErrorConditionalOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnExecOrder(ref CThostFtdcExecOrderField pExecOrder);
    internal DelOnRtnExecOrder OnRtnExecOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnExecOrderInsert OnErrRtnExecOrderInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnExecOrderAction(ref CThostFtdcExecOrderActionField pExecOrderAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnExecOrderAction OnErrRtnExecOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnForQuoteInsert OnErrRtnForQuoteInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnQuote(ref CThostFtdcQuoteField pQuote);
    internal DelOnRtnQuote OnRtnQuote;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnQuoteInsert OnErrRtnQuoteInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnQuoteAction(ref CThostFtdcQuoteActionField pQuoteAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnQuoteAction OnErrRtnQuoteAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnForQuoteRsp(ref CThostFtdcForQuoteRspField pForQuoteRsp);
    internal DelOnRtnForQuoteRsp OnRtnForQuoteRsp;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnCFMMCTradingAccountToken(ref CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken);
    internal DelOnRtnCFMMCTradingAccountToken OnRtnCFMMCTradingAccountToken;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnBatchOrderAction(ref CThostFtdcBatchOrderActionField pBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnBatchOrderAction OnErrRtnBatchOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose);
    internal DelOnRtnOptionSelfClose OnRtnOptionSelfClose;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnOptionSelfCloseInsert OnErrRtnOptionSelfCloseInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnOptionSelfCloseAction(ref CThostFtdcOptionSelfCloseActionField pOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnOptionSelfCloseAction OnErrRtnOptionSelfCloseAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnCombAction(ref CThostFtdcCombActionField pCombAction);
    internal DelOnRtnCombAction OnRtnCombAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnCombActionInsert OnErrRtnCombActionInsert;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryContractBank(ref CThostFtdcContractBankField pContractBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryContractBank OnRspQryContractBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryParkedOrder OnRspQryParkedOrder;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryParkedOrderAction OnRspQryParkedOrderAction;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryTradingNotice OnRspQryTradingNotice;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryBrokerTradingParams OnRspQryBrokerTradingParams;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryBrokerTradingAlgos OnRspQryBrokerTradingAlgos;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQueryCFMMCTradingAccountToken(ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQueryCFMMCTradingAccountToken OnRspQueryCFMMCTradingAccountToken;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer);
    internal DelOnRtnFromBankToFutureByBank OnRtnFromBankToFutureByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer);
    internal DelOnRtnFromFutureToBankByBank OnRtnFromFutureToBankByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromBankToFutureByBank OnRtnRepealFromBankToFutureByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromFutureToBankByBank OnRtnRepealFromFutureToBankByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer);
    internal DelOnRtnFromBankToFutureByFuture OnRtnFromBankToFutureByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer);
    internal DelOnRtnFromFutureToBankByFuture OnRtnFromFutureToBankByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromBankToFutureByFutureManual OnRtnRepealFromBankToFutureByFutureManual;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromFutureToBankByFutureManual OnRtnRepealFromFutureToBankByFutureManual;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount);
    internal DelOnRtnQueryBankBalanceByFuture OnRtnQueryBankBalanceByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnBankToFutureByFuture OnErrRtnBankToFutureByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnFutureToBankByFuture OnErrRtnFutureToBankByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnRepealBankToFutureByFutureManual OnErrRtnRepealBankToFutureByFutureManual;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnRepealFutureToBankByFutureManual OnErrRtnRepealFutureToBankByFutureManual;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo);
    internal DelOnErrRtnQueryBankBalanceByFuture OnErrRtnQueryBankBalanceByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromBankToFutureByFuture OnRtnRepealFromBankToFutureByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal);
    internal DelOnRtnRepealFromFutureToBankByFuture OnRtnRepealFromFutureToBankByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspFromBankToFutureByFuture OnRspFromBankToFutureByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspFromFutureToBankByFuture OnRspFromFutureToBankByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQueryBankAccountMoneyByFuture OnRspQueryBankAccountMoneyByFuture;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount);
    internal DelOnRtnOpenAccountByBank OnRtnOpenAccountByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount);
    internal DelOnRtnCancelAccountByBank OnRtnCancelAccountByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount);
    internal DelOnRtnChangeAccountByBank OnRtnChangeAccountByBank;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryClassifiedInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryClassifiedInstrument OnRspQryClassifiedInstrument;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryCombPromotionParam(ref CThostFtdcCombPromotionParamField pCombPromotionParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryCombPromotionParam OnRspQryCombPromotionParam;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRiskSettleInvstPosition(ref CThostFtdcRiskSettleInvstPositionField pRiskSettleInvstPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRiskSettleInvstPosition OnRspQryRiskSettleInvstPosition;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRiskSettleProductStatus(ref CThostFtdcRiskSettleProductStatusField pRiskSettleProductStatus,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRiskSettleProductStatus OnRspQryRiskSettleProductStatus;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMFutureParameter(ref CThostFtdcSPBMFutureParameterField pSPBMFutureParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMFutureParameter OnRspQrySPBMFutureParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMOptionParameter(ref CThostFtdcSPBMOptionParameterField pSPBMOptionParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMOptionParameter OnRspQrySPBMOptionParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMIntraParameter(ref CThostFtdcSPBMIntraParameterField pSPBMIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMIntraParameter OnRspQrySPBMIntraParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMInterParameter(ref CThostFtdcSPBMInterParameterField pSPBMInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMInterParameter OnRspQrySPBMInterParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMPortfDefinition(ref CThostFtdcSPBMPortfDefinitionField pSPBMPortfDefinition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMPortfDefinition OnRspQrySPBMPortfDefinition;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMInvestorPortfDef(ref CThostFtdcSPBMInvestorPortfDefField pSPBMInvestorPortfDef,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMInvestorPortfDef OnRspQrySPBMInvestorPortfDef;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorPortfMarginRatio(ref CThostFtdcInvestorPortfMarginRatioField pInvestorPortfMarginRatio,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorPortfMarginRatio OnRspQryInvestorPortfMarginRatio;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorProdSPBMDetail(ref CThostFtdcInvestorProdSPBMDetailField pInvestorProdSPBMDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorProdSPBMDetail OnRspQryInvestorProdSPBMDetail;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorCommoditySPMMMargin(ref CThostFtdcInvestorCommoditySPMMMarginField pInvestorCommoditySPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorCommoditySPMMMargin OnRspQryInvestorCommoditySPMMMargin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorCommodityGroupSPMMMargin(ref CThostFtdcInvestorCommodityGroupSPMMMarginField pInvestorCommodityGroupSPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorCommodityGroupSPMMMargin OnRspQryInvestorCommodityGroupSPMMMargin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPMMInstParam(ref CThostFtdcSPMMInstParamField pSPMMInstParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPMMInstParam OnRspQrySPMMInstParam;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPMMProductParam(ref CThostFtdcSPMMProductParamField pSPMMProductParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPMMProductParam OnRspQrySPMMProductParam;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQrySPBMAddOnInterParameter(ref CThostFtdcSPBMAddOnInterParameterField pSPBMAddOnInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQrySPBMAddOnInterParameter OnRspQrySPBMAddOnInterParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSCombProductInfo(ref CThostFtdcRCAMSCombProductInfoField pRCAMSCombProductInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSCombProductInfo OnRspQryRCAMSCombProductInfo;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSInstrParameter(ref CThostFtdcRCAMSInstrParameterField pRCAMSInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSInstrParameter OnRspQryRCAMSInstrParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSIntraParameter(ref CThostFtdcRCAMSIntraParameterField pRCAMSIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSIntraParameter OnRspQryRCAMSIntraParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSInterParameter(ref CThostFtdcRCAMSInterParameterField pRCAMSInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSInterParameter OnRspQryRCAMSInterParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSShortOptAdjustParam(ref CThostFtdcRCAMSShortOptAdjustParamField pRCAMSShortOptAdjustParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSShortOptAdjustParam OnRspQryRCAMSShortOptAdjustParam;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRCAMSInvestorCombPosition(ref CThostFtdcRCAMSInvestorCombPositionField pRCAMSInvestorCombPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRCAMSInvestorCombPosition OnRspQryRCAMSInvestorCombPosition;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorProdRCAMSMargin(ref CThostFtdcInvestorProdRCAMSMarginField pInvestorProdRCAMSMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorProdRCAMSMargin OnRspQryInvestorProdRCAMSMargin;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRULEInstrParameter(ref CThostFtdcRULEInstrParameterField pRULEInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRULEInstrParameter OnRspQryRULEInstrParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRULEIntraParameter(ref CThostFtdcRULEIntraParameterField pRULEIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRULEIntraParameter OnRspQryRULEIntraParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryRULEInterParameter(ref CThostFtdcRULEInterParameterField pRULEInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryRULEInterParameter OnRspQryRULEInterParameter;

    [UnmanagedFunctionPointer(CallingConvention.StdCall, CharSet = CharSet.Ansi, SetLastError = true)]
    internal delegate void DelOnRspQryInvestorProdRULEMargin(ref CThostFtdcInvestorProdRULEMarginField pInvestorProdRULEMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast);
    internal DelOnRspQryInvestorProdRULEMargin OnRspQryInvestorProdRULEMargin;

}
internal partial class CTPSharpPInvoke
{
    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderSpi_New", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcTraderSpi_New(ref CTPSharp_CThostFtdcTraderSpi callback);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderSpi_Delete", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderSpi_Delete(IntPtr spi);
}
public class CThostFtdcTraderSpi: IDisposable
{
    CTPSharp_CThostFtdcTraderSpi _spi = new();
    IntPtr _handle;
    internal IntPtr Handle => _handle;
    public CThostFtdcTraderSpi()
    {
        _spi.OnFrontConnected = this.OnFrontConnected;
        _spi.OnFrontDisconnected = this.OnFrontDisconnected;
        _spi.OnHeartBeatWarning = this.OnHeartBeatWarning;
        _spi.OnRspAuthenticate = this.OnRspAuthenticate;
        _spi.OnRspUserLogin = this.OnRspUserLogin;
        _spi.OnRspUserLogout = this.OnRspUserLogout;
        _spi.OnRspUserPasswordUpdate = this.OnRspUserPasswordUpdate;
        _spi.OnRspTradingAccountPasswordUpdate = this.OnRspTradingAccountPasswordUpdate;
        _spi.OnRspUserAuthMethod = this.OnRspUserAuthMethod;
        _spi.OnRspGenUserCaptcha = this.OnRspGenUserCaptcha;
        _spi.OnRspGenUserText = this.OnRspGenUserText;
        _spi.OnRspOrderInsert = this.OnRspOrderInsert;
        _spi.OnRspParkedOrderInsert = this.OnRspParkedOrderInsert;
        _spi.OnRspParkedOrderAction = this.OnRspParkedOrderAction;
        _spi.OnRspOrderAction = this.OnRspOrderAction;
        _spi.OnRspQryMaxOrderVolume = this.OnRspQryMaxOrderVolume;
        _spi.OnRspSettlementInfoConfirm = this.OnRspSettlementInfoConfirm;
        _spi.OnRspRemoveParkedOrder = this.OnRspRemoveParkedOrder;
        _spi.OnRspRemoveParkedOrderAction = this.OnRspRemoveParkedOrderAction;
        _spi.OnRspExecOrderInsert = this.OnRspExecOrderInsert;
        _spi.OnRspExecOrderAction = this.OnRspExecOrderAction;
        _spi.OnRspForQuoteInsert = this.OnRspForQuoteInsert;
        _spi.OnRspQuoteInsert = this.OnRspQuoteInsert;
        _spi.OnRspQuoteAction = this.OnRspQuoteAction;
        _spi.OnRspBatchOrderAction = this.OnRspBatchOrderAction;
        _spi.OnRspOptionSelfCloseInsert = this.OnRspOptionSelfCloseInsert;
        _spi.OnRspOptionSelfCloseAction = this.OnRspOptionSelfCloseAction;
        _spi.OnRspCombActionInsert = this.OnRspCombActionInsert;
        _spi.OnRspQryOrder = this.OnRspQryOrder;
        _spi.OnRspQryTrade = this.OnRspQryTrade;
        _spi.OnRspQryInvestorPosition = this.OnRspQryInvestorPosition;
        _spi.OnRspQryTradingAccount = this.OnRspQryTradingAccount;
        _spi.OnRspQryInvestor = this.OnRspQryInvestor;
        _spi.OnRspQryTradingCode = this.OnRspQryTradingCode;
        _spi.OnRspQryInstrumentMarginRate = this.OnRspQryInstrumentMarginRate;
        _spi.OnRspQryInstrumentCommissionRate = this.OnRspQryInstrumentCommissionRate;
        _spi.OnRspQryExchange = this.OnRspQryExchange;
        _spi.OnRspQryProduct = this.OnRspQryProduct;
        _spi.OnRspQryInstrument = this.OnRspQryInstrument;
        _spi.OnRspQryDepthMarketData = this.OnRspQryDepthMarketData;
        _spi.OnRspQryTraderOffer = this.OnRspQryTraderOffer;
        _spi.OnRspQrySettlementInfo = this.OnRspQrySettlementInfo;
        _spi.OnRspQryTransferBank = this.OnRspQryTransferBank;
        _spi.OnRspQryInvestorPositionDetail = this.OnRspQryInvestorPositionDetail;
        _spi.OnRspQryNotice = this.OnRspQryNotice;
        _spi.OnRspQrySettlementInfoConfirm = this.OnRspQrySettlementInfoConfirm;
        _spi.OnRspQryInvestorPositionCombineDetail = this.OnRspQryInvestorPositionCombineDetail;
        _spi.OnRspQryCFMMCTradingAccountKey = this.OnRspQryCFMMCTradingAccountKey;
        _spi.OnRspQryEWarrantOffset = this.OnRspQryEWarrantOffset;
        _spi.OnRspQryInvestorProductGroupMargin = this.OnRspQryInvestorProductGroupMargin;
        _spi.OnRspQryExchangeMarginRate = this.OnRspQryExchangeMarginRate;
        _spi.OnRspQryExchangeMarginRateAdjust = this.OnRspQryExchangeMarginRateAdjust;
        _spi.OnRspQryExchangeRate = this.OnRspQryExchangeRate;
        _spi.OnRspQrySecAgentACIDMap = this.OnRspQrySecAgentACIDMap;
        _spi.OnRspQryProductExchRate = this.OnRspQryProductExchRate;
        _spi.OnRspQryProductGroup = this.OnRspQryProductGroup;
        _spi.OnRspQryMMInstrumentCommissionRate = this.OnRspQryMMInstrumentCommissionRate;
        _spi.OnRspQryMMOptionInstrCommRate = this.OnRspQryMMOptionInstrCommRate;
        _spi.OnRspQryInstrumentOrderCommRate = this.OnRspQryInstrumentOrderCommRate;
        _spi.OnRspQrySecAgentTradingAccount = this.OnRspQrySecAgentTradingAccount;
        _spi.OnRspQrySecAgentCheckMode = this.OnRspQrySecAgentCheckMode;
        _spi.OnRspQrySecAgentTradeInfo = this.OnRspQrySecAgentTradeInfo;
        _spi.OnRspQryOptionInstrTradeCost = this.OnRspQryOptionInstrTradeCost;
        _spi.OnRspQryOptionInstrCommRate = this.OnRspQryOptionInstrCommRate;
        _spi.OnRspQryExecOrder = this.OnRspQryExecOrder;
        _spi.OnRspQryForQuote = this.OnRspQryForQuote;
        _spi.OnRspQryQuote = this.OnRspQryQuote;
        _spi.OnRspQryOptionSelfClose = this.OnRspQryOptionSelfClose;
        _spi.OnRspQryInvestUnit = this.OnRspQryInvestUnit;
        _spi.OnRspQryCombInstrumentGuard = this.OnRspQryCombInstrumentGuard;
        _spi.OnRspQryCombAction = this.OnRspQryCombAction;
        _spi.OnRspQryTransferSerial = this.OnRspQryTransferSerial;
        _spi.OnRspQryAccountregister = this.OnRspQryAccountregister;
        _spi.OnRspError = this.OnRspError;
        _spi.OnRtnOrder = this.OnRtnOrder;
        _spi.OnRtnTrade = this.OnRtnTrade;
        _spi.OnErrRtnOrderInsert = this.OnErrRtnOrderInsert;
        _spi.OnErrRtnOrderAction = this.OnErrRtnOrderAction;
        _spi.OnRtnInstrumentStatus = this.OnRtnInstrumentStatus;
        _spi.OnRtnBulletin = this.OnRtnBulletin;
        _spi.OnRtnTradingNotice = this.OnRtnTradingNotice;
        _spi.OnRtnErrorConditionalOrder = this.OnRtnErrorConditionalOrder;
        _spi.OnRtnExecOrder = this.OnRtnExecOrder;
        _spi.OnErrRtnExecOrderInsert = this.OnErrRtnExecOrderInsert;
        _spi.OnErrRtnExecOrderAction = this.OnErrRtnExecOrderAction;
        _spi.OnErrRtnForQuoteInsert = this.OnErrRtnForQuoteInsert;
        _spi.OnRtnQuote = this.OnRtnQuote;
        _spi.OnErrRtnQuoteInsert = this.OnErrRtnQuoteInsert;
        _spi.OnErrRtnQuoteAction = this.OnErrRtnQuoteAction;
        _spi.OnRtnForQuoteRsp = this.OnRtnForQuoteRsp;
        _spi.OnRtnCFMMCTradingAccountToken = this.OnRtnCFMMCTradingAccountToken;
        _spi.OnErrRtnBatchOrderAction = this.OnErrRtnBatchOrderAction;
        _spi.OnRtnOptionSelfClose = this.OnRtnOptionSelfClose;
        _spi.OnErrRtnOptionSelfCloseInsert = this.OnErrRtnOptionSelfCloseInsert;
        _spi.OnErrRtnOptionSelfCloseAction = this.OnErrRtnOptionSelfCloseAction;
        _spi.OnRtnCombAction = this.OnRtnCombAction;
        _spi.OnErrRtnCombActionInsert = this.OnErrRtnCombActionInsert;
        _spi.OnRspQryContractBank = this.OnRspQryContractBank;
        _spi.OnRspQryParkedOrder = this.OnRspQryParkedOrder;
        _spi.OnRspQryParkedOrderAction = this.OnRspQryParkedOrderAction;
        _spi.OnRspQryTradingNotice = this.OnRspQryTradingNotice;
        _spi.OnRspQryBrokerTradingParams = this.OnRspQryBrokerTradingParams;
        _spi.OnRspQryBrokerTradingAlgos = this.OnRspQryBrokerTradingAlgos;
        _spi.OnRspQueryCFMMCTradingAccountToken = this.OnRspQueryCFMMCTradingAccountToken;
        _spi.OnRtnFromBankToFutureByBank = this.OnRtnFromBankToFutureByBank;
        _spi.OnRtnFromFutureToBankByBank = this.OnRtnFromFutureToBankByBank;
        _spi.OnRtnRepealFromBankToFutureByBank = this.OnRtnRepealFromBankToFutureByBank;
        _spi.OnRtnRepealFromFutureToBankByBank = this.OnRtnRepealFromFutureToBankByBank;
        _spi.OnRtnFromBankToFutureByFuture = this.OnRtnFromBankToFutureByFuture;
        _spi.OnRtnFromFutureToBankByFuture = this.OnRtnFromFutureToBankByFuture;
        _spi.OnRtnRepealFromBankToFutureByFutureManual = this.OnRtnRepealFromBankToFutureByFutureManual;
        _spi.OnRtnRepealFromFutureToBankByFutureManual = this.OnRtnRepealFromFutureToBankByFutureManual;
        _spi.OnRtnQueryBankBalanceByFuture = this.OnRtnQueryBankBalanceByFuture;
        _spi.OnErrRtnBankToFutureByFuture = this.OnErrRtnBankToFutureByFuture;
        _spi.OnErrRtnFutureToBankByFuture = this.OnErrRtnFutureToBankByFuture;
        _spi.OnErrRtnRepealBankToFutureByFutureManual = this.OnErrRtnRepealBankToFutureByFutureManual;
        _spi.OnErrRtnRepealFutureToBankByFutureManual = this.OnErrRtnRepealFutureToBankByFutureManual;
        _spi.OnErrRtnQueryBankBalanceByFuture = this.OnErrRtnQueryBankBalanceByFuture;
        _spi.OnRtnRepealFromBankToFutureByFuture = this.OnRtnRepealFromBankToFutureByFuture;
        _spi.OnRtnRepealFromFutureToBankByFuture = this.OnRtnRepealFromFutureToBankByFuture;
        _spi.OnRspFromBankToFutureByFuture = this.OnRspFromBankToFutureByFuture;
        _spi.OnRspFromFutureToBankByFuture = this.OnRspFromFutureToBankByFuture;
        _spi.OnRspQueryBankAccountMoneyByFuture = this.OnRspQueryBankAccountMoneyByFuture;
        _spi.OnRtnOpenAccountByBank = this.OnRtnOpenAccountByBank;
        _spi.OnRtnCancelAccountByBank = this.OnRtnCancelAccountByBank;
        _spi.OnRtnChangeAccountByBank = this.OnRtnChangeAccountByBank;
        _spi.OnRspQryClassifiedInstrument = this.OnRspQryClassifiedInstrument;
        _spi.OnRspQryCombPromotionParam = this.OnRspQryCombPromotionParam;
        _spi.OnRspQryRiskSettleInvstPosition = this.OnRspQryRiskSettleInvstPosition;
        _spi.OnRspQryRiskSettleProductStatus = this.OnRspQryRiskSettleProductStatus;
        _spi.OnRspQrySPBMFutureParameter = this.OnRspQrySPBMFutureParameter;
        _spi.OnRspQrySPBMOptionParameter = this.OnRspQrySPBMOptionParameter;
        _spi.OnRspQrySPBMIntraParameter = this.OnRspQrySPBMIntraParameter;
        _spi.OnRspQrySPBMInterParameter = this.OnRspQrySPBMInterParameter;
        _spi.OnRspQrySPBMPortfDefinition = this.OnRspQrySPBMPortfDefinition;
        _spi.OnRspQrySPBMInvestorPortfDef = this.OnRspQrySPBMInvestorPortfDef;
        _spi.OnRspQryInvestorPortfMarginRatio = this.OnRspQryInvestorPortfMarginRatio;
        _spi.OnRspQryInvestorProdSPBMDetail = this.OnRspQryInvestorProdSPBMDetail;
        _spi.OnRspQryInvestorCommoditySPMMMargin = this.OnRspQryInvestorCommoditySPMMMargin;
        _spi.OnRspQryInvestorCommodityGroupSPMMMargin = this.OnRspQryInvestorCommodityGroupSPMMMargin;
        _spi.OnRspQrySPMMInstParam = this.OnRspQrySPMMInstParam;
        _spi.OnRspQrySPMMProductParam = this.OnRspQrySPMMProductParam;
        _spi.OnRspQrySPBMAddOnInterParameter = this.OnRspQrySPBMAddOnInterParameter;
        _spi.OnRspQryRCAMSCombProductInfo = this.OnRspQryRCAMSCombProductInfo;
        _spi.OnRspQryRCAMSInstrParameter = this.OnRspQryRCAMSInstrParameter;
        _spi.OnRspQryRCAMSIntraParameter = this.OnRspQryRCAMSIntraParameter;
        _spi.OnRspQryRCAMSInterParameter = this.OnRspQryRCAMSInterParameter;
        _spi.OnRspQryRCAMSShortOptAdjustParam = this.OnRspQryRCAMSShortOptAdjustParam;
        _spi.OnRspQryRCAMSInvestorCombPosition = this.OnRspQryRCAMSInvestorCombPosition;
        _spi.OnRspQryInvestorProdRCAMSMargin = this.OnRspQryInvestorProdRCAMSMargin;
        _spi.OnRspQryRULEInstrParameter = this.OnRspQryRULEInstrParameter;
        _spi.OnRspQryRULEIntraParameter = this.OnRspQryRULEIntraParameter;
        _spi.OnRspQryRULEInterParameter = this.OnRspQryRULEInterParameter;
        _spi.OnRspQryInvestorProdRULEMargin = this.OnRspQryInvestorProdRULEMargin;
        _handle = CTPSharpPInvoke.CThostFtdcTraderSpi_New(ref _spi);
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
    /// 客户端认证响应
    /// </summary>
    public virtual void OnRspAuthenticate(ref CThostFtdcRspAuthenticateField pRspAuthenticateField,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 登录请求响应
    /// </summary>
    public virtual void OnRspUserLogin(ref CThostFtdcRspUserLoginField pRspUserLogin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 登出请求响应
    /// </summary>
    public virtual void OnRspUserLogout(ref CThostFtdcUserLogoutField pUserLogout,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 用户口令更新请求响应
    /// </summary>
    public virtual void OnRspUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 资金账户口令更新请求响应
    /// </summary>
    public virtual void OnRspTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 查询用户当前支持的认证模式的回复
    /// </summary>
    public virtual void OnRspUserAuthMethod(ref CThostFtdcRspUserAuthMethodField pRspUserAuthMethod,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 获取图形验证码请求的回复
    /// </summary>
    public virtual void OnRspGenUserCaptcha(ref CThostFtdcRspGenUserCaptchaField pRspGenUserCaptcha,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 获取短信验证码请求的回复
    /// </summary>
    public virtual void OnRspGenUserText(ref CThostFtdcRspGenUserTextField pRspGenUserText,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 报单录入请求响应
    /// </summary>
    public virtual void OnRspOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 预埋单录入请求响应
    /// </summary>
    public virtual void OnRspParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 预埋撤单录入请求响应
    /// </summary>
    public virtual void OnRspParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 报单操作请求响应
    /// </summary>
    public virtual void OnRspOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 查询最大报单数量响应
    /// </summary>
    public virtual void OnRspQryMaxOrderVolume(ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者结算结果确认响应
    /// </summary>
    public virtual void OnRspSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 删除预埋单响应
    /// </summary>
    public virtual void OnRspRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 删除预埋撤单响应
    /// </summary>
    public virtual void OnRspRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 执行宣告录入请求响应
    /// </summary>
    public virtual void OnRspExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 执行宣告操作请求响应
    /// </summary>
    public virtual void OnRspExecOrderAction(ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 询价录入请求响应
    /// </summary>
    public virtual void OnRspForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 报价录入请求响应
    /// </summary>
    public virtual void OnRspQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 报价操作请求响应
    /// </summary>
    public virtual void OnRspQuoteAction(ref CThostFtdcInputQuoteActionField pInputQuoteAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 批量报单操作请求响应
    /// </summary>
    public virtual void OnRspBatchOrderAction(ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 期权自对冲录入请求响应
    /// </summary>
    public virtual void OnRspOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 期权自对冲操作请求响应
    /// </summary>
    public virtual void OnRspOptionSelfCloseAction(ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 申请组合录入请求响应
    /// </summary>
    public virtual void OnRspCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询报单响应
    /// </summary>
    public virtual void OnRspQryOrder(ref CThostFtdcOrderField pOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询成交响应
    /// </summary>
    public virtual void OnRspQryTrade(ref CThostFtdcTradeField pTrade,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者持仓响应
    /// </summary>
    public virtual void OnRspQryInvestorPosition(ref CThostFtdcInvestorPositionField pInvestorPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询资金账户响应
    /// </summary>
    public virtual void OnRspQryTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者响应
    /// </summary>
    public virtual void OnRspQryInvestor(ref CThostFtdcInvestorField pInvestor,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易编码响应
    /// </summary>
    public virtual void OnRspQryTradingCode(ref CThostFtdcTradingCodeField pTradingCode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询合约保证金率响应
    /// </summary>
    public virtual void OnRspQryInstrumentMarginRate(ref CThostFtdcInstrumentMarginRateField pInstrumentMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询合约手续费率响应
    /// </summary>
    public virtual void OnRspQryInstrumentCommissionRate(ref CThostFtdcInstrumentCommissionRateField pInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易所响应
    /// </summary>
    public virtual void OnRspQryExchange(ref CThostFtdcExchangeField pExchange,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询产品响应
    /// </summary>
    public virtual void OnRspQryProduct(ref CThostFtdcProductField pProduct,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询合约响应
    /// </summary>
    public virtual void OnRspQryInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询行情响应
    /// </summary>
    public virtual void OnRspQryDepthMarketData(ref CThostFtdcDepthMarketDataField pDepthMarketData,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易员报盘机响应
    /// </summary>
    public virtual void OnRspQryTraderOffer(ref CThostFtdcTraderOfferField pTraderOffer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者结算结果响应
    /// </summary>
    public virtual void OnRspQrySettlementInfo(ref CThostFtdcSettlementInfoField pSettlementInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询转帐银行响应
    /// </summary>
    public virtual void OnRspQryTransferBank(ref CThostFtdcTransferBankField pTransferBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者持仓明细响应
    /// </summary>
    public virtual void OnRspQryInvestorPositionDetail(ref CThostFtdcInvestorPositionDetailField pInvestorPositionDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询客户通知响应
    /// </summary>
    public virtual void OnRspQryNotice(ref CThostFtdcNoticeField pNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询结算信息确认响应
    /// </summary>
    public virtual void OnRspQrySettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者持仓明细响应
    /// </summary>
    public virtual void OnRspQryInvestorPositionCombineDetail(ref CThostFtdcInvestorPositionCombineDetailField pInvestorPositionCombineDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 查询保证金监管系统经纪公司资金账户密钥响应
    /// </summary>
    public virtual void OnRspQryCFMMCTradingAccountKey(ref CThostFtdcCFMMCTradingAccountKeyField pCFMMCTradingAccountKey,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询仓单折抵信息响应
    /// </summary>
    public virtual void OnRspQryEWarrantOffset(ref CThostFtdcEWarrantOffsetField pEWarrantOffset,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资者品种/跨品种保证金响应
    /// </summary>
    public virtual void OnRspQryInvestorProductGroupMargin(ref CThostFtdcInvestorProductGroupMarginField pInvestorProductGroupMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易所保证金率响应
    /// </summary>
    public virtual void OnRspQryExchangeMarginRate(ref CThostFtdcExchangeMarginRateField pExchangeMarginRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易所调整保证金率响应
    /// </summary>
    public virtual void OnRspQryExchangeMarginRateAdjust(ref CThostFtdcExchangeMarginRateAdjustField pExchangeMarginRateAdjust,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询汇率响应
    /// </summary>
    public virtual void OnRspQryExchangeRate(ref CThostFtdcExchangeRateField pExchangeRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询二级代理操作员银期权限响应
    /// </summary>
    public virtual void OnRspQrySecAgentACIDMap(ref CThostFtdcSecAgentACIDMapField pSecAgentACIDMap,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询产品报价汇率
    /// </summary>
    public virtual void OnRspQryProductExchRate(ref CThostFtdcProductExchRateField pProductExchRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询产品组
    /// </summary>
    public virtual void OnRspQryProductGroup(ref CThostFtdcProductGroupField pProductGroup,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询做市商合约手续费率响应
    /// </summary>
    public virtual void OnRspQryMMInstrumentCommissionRate(ref CThostFtdcMMInstrumentCommissionRateField pMMInstrumentCommissionRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询做市商期权合约手续费响应
    /// </summary>
    public virtual void OnRspQryMMOptionInstrCommRate(ref CThostFtdcMMOptionInstrCommRateField pMMOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询报单手续费响应
    /// </summary>
    public virtual void OnRspQryInstrumentOrderCommRate(ref CThostFtdcInstrumentOrderCommRateField pInstrumentOrderCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询资金账户响应
    /// </summary>
    public virtual void OnRspQrySecAgentTradingAccount(ref CThostFtdcTradingAccountField pTradingAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询二级代理商资金校验模式响应
    /// </summary>
    public virtual void OnRspQrySecAgentCheckMode(ref CThostFtdcSecAgentCheckModeField pSecAgentCheckMode,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询二级代理商信息响应
    /// </summary>
    public virtual void OnRspQrySecAgentTradeInfo(ref CThostFtdcSecAgentTradeInfoField pSecAgentTradeInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询期权交易成本响应
    /// </summary>
    public virtual void OnRspQryOptionInstrTradeCost(ref CThostFtdcOptionInstrTradeCostField pOptionInstrTradeCost,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询期权合约手续费响应
    /// </summary>
    public virtual void OnRspQryOptionInstrCommRate(ref CThostFtdcOptionInstrCommRateField pOptionInstrCommRate,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询执行宣告响应
    /// </summary>
    public virtual void OnRspQryExecOrder(ref CThostFtdcExecOrderField pExecOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询询价响应
    /// </summary>
    public virtual void OnRspQryForQuote(ref CThostFtdcForQuoteField pForQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询报价响应
    /// </summary>
    public virtual void OnRspQryQuote(ref CThostFtdcQuoteField pQuote,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询期权自对冲响应
    /// </summary>
    public virtual void OnRspQryOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询投资单元响应
    /// </summary>
    public virtual void OnRspQryInvestUnit(ref CThostFtdcInvestUnitField pInvestUnit,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询组合合约安全系数响应
    /// </summary>
    public virtual void OnRspQryCombInstrumentGuard(ref CThostFtdcCombInstrumentGuardField pCombInstrumentGuard,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询申请组合响应
    /// </summary>
    public virtual void OnRspQryCombAction(ref CThostFtdcCombActionField pCombAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询转帐流水响应
    /// </summary>
    public virtual void OnRspQryTransferSerial(ref CThostFtdcTransferSerialField pTransferSerial,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询银期签约关系响应
    /// </summary>
    public virtual void OnRspQryAccountregister(ref CThostFtdcAccountregisterField pAccountregister,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 错误应答
    /// </summary>
    public virtual void OnRspError(ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 报单通知
    /// </summary>
    public virtual void OnRtnOrder(ref CThostFtdcOrderField pOrder){}

    /// <summary>
    /// 成交通知
    /// </summary>
    public virtual void OnRtnTrade(ref CThostFtdcTradeField pTrade){}

    /// <summary>
    /// 报单录入错误回报
    /// </summary>
    public virtual void OnErrRtnOrderInsert(ref CThostFtdcInputOrderField pInputOrder,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 报单操作错误回报
    /// </summary>
    public virtual void OnErrRtnOrderAction(ref CThostFtdcOrderActionField pOrderAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 合约交易状态通知
    /// </summary>
    public virtual void OnRtnInstrumentStatus(ref CThostFtdcInstrumentStatusField pInstrumentStatus){}

    /// <summary>
    /// 交易所公告通知
    /// </summary>
    public virtual void OnRtnBulletin(ref CThostFtdcBulletinField pBulletin){}

    /// <summary>
    /// 交易通知
    /// </summary>
    public virtual void OnRtnTradingNotice(ref CThostFtdcTradingNoticeInfoField pTradingNoticeInfo){}

    /// <summary>
    /// 提示条件单校验错误
    /// </summary>
    public virtual void OnRtnErrorConditionalOrder(ref CThostFtdcErrorConditionalOrderField pErrorConditionalOrder){}

    /// <summary>
    /// 执行宣告通知
    /// </summary>
    public virtual void OnRtnExecOrder(ref CThostFtdcExecOrderField pExecOrder){}

    /// <summary>
    /// 执行宣告录入错误回报
    /// </summary>
    public virtual void OnErrRtnExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 执行宣告操作错误回报
    /// </summary>
    public virtual void OnErrRtnExecOrderAction(ref CThostFtdcExecOrderActionField pExecOrderAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 询价录入错误回报
    /// </summary>
    public virtual void OnErrRtnForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 报价通知
    /// </summary>
    public virtual void OnRtnQuote(ref CThostFtdcQuoteField pQuote){}

    /// <summary>
    /// 报价录入错误回报
    /// </summary>
    public virtual void OnErrRtnQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 报价操作错误回报
    /// </summary>
    public virtual void OnErrRtnQuoteAction(ref CThostFtdcQuoteActionField pQuoteAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 询价通知
    /// </summary>
    public virtual void OnRtnForQuoteRsp(ref CThostFtdcForQuoteRspField pForQuoteRsp){}

    /// <summary>
    /// 保证金监控中心用户令牌
    /// </summary>
    public virtual void OnRtnCFMMCTradingAccountToken(ref CThostFtdcCFMMCTradingAccountTokenField pCFMMCTradingAccountToken){}

    /// <summary>
    /// 批量报单操作错误回报
    /// </summary>
    public virtual void OnErrRtnBatchOrderAction(ref CThostFtdcBatchOrderActionField pBatchOrderAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 期权自对冲通知
    /// </summary>
    public virtual void OnRtnOptionSelfClose(ref CThostFtdcOptionSelfCloseField pOptionSelfClose){}

    /// <summary>
    /// 期权自对冲录入错误回报
    /// </summary>
    public virtual void OnErrRtnOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 期权自对冲操作错误回报
    /// </summary>
    public virtual void OnErrRtnOptionSelfCloseAction(ref CThostFtdcOptionSelfCloseActionField pOptionSelfCloseAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 申请组合通知
    /// </summary>
    public virtual void OnRtnCombAction(ref CThostFtdcCombActionField pCombAction){}

    /// <summary>
    /// 申请组合录入错误回报
    /// </summary>
    public virtual void OnErrRtnCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 请求查询签约银行响应
    /// </summary>
    public virtual void OnRspQryContractBank(ref CThostFtdcContractBankField pContractBank,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询预埋单响应
    /// </summary>
    public virtual void OnRspQryParkedOrder(ref CThostFtdcParkedOrderField pParkedOrder,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询预埋撤单响应
    /// </summary>
    public virtual void OnRspQryParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询交易通知响应
    /// </summary>
    public virtual void OnRspQryTradingNotice(ref CThostFtdcTradingNoticeField pTradingNotice,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询经纪公司交易参数响应
    /// </summary>
    public virtual void OnRspQryBrokerTradingParams(ref CThostFtdcBrokerTradingParamsField pBrokerTradingParams,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询经纪公司交易算法响应
    /// </summary>
    public virtual void OnRspQryBrokerTradingAlgos(ref CThostFtdcBrokerTradingAlgosField pBrokerTradingAlgos,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求查询监控中心用户令牌
    /// </summary>
    public virtual void OnRspQueryCFMMCTradingAccountToken(ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 银行发起银行资金转期货通知
    /// </summary>
    public virtual void OnRtnFromBankToFutureByBank(ref CThostFtdcRspTransferField pRspTransfer){}

    /// <summary>
    /// 银行发起期货资金转银行通知
    /// </summary>
    public virtual void OnRtnFromFutureToBankByBank(ref CThostFtdcRspTransferField pRspTransfer){}

    /// <summary>
    /// 银行发起冲正银行转期货通知
    /// </summary>
    public virtual void OnRtnRepealFromBankToFutureByBank(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 银行发起冲正期货转银行通知
    /// </summary>
    public virtual void OnRtnRepealFromFutureToBankByBank(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 期货发起银行资金转期货通知
    /// </summary>
    public virtual void OnRtnFromBankToFutureByFuture(ref CThostFtdcRspTransferField pRspTransfer){}

    /// <summary>
    /// 期货发起期货资金转银行通知
    /// </summary>
    public virtual void OnRtnFromFutureToBankByFuture(ref CThostFtdcRspTransferField pRspTransfer){}

    /// <summary>
    /// 系统运行时期货端手工发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public virtual void OnRtnRepealFromBankToFutureByFutureManual(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 系统运行时期货端手工发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public virtual void OnRtnRepealFromFutureToBankByFutureManual(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 期货发起查询银行余额通知
    /// </summary>
    public virtual void OnRtnQueryBankBalanceByFuture(ref CThostFtdcNotifyQueryAccountField pNotifyQueryAccount){}

    /// <summary>
    /// 期货发起银行资金转期货错误回报
    /// </summary>
    public virtual void OnErrRtnBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 期货发起期货资金转银行错误回报
    /// </summary>
    public virtual void OnErrRtnFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 系统运行时期货端手工发起冲正银行转期货错误回报
    /// </summary>
    public virtual void OnErrRtnRepealBankToFutureByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 系统运行时期货端手工发起冲正期货转银行错误回报
    /// </summary>
    public virtual void OnErrRtnRepealFutureToBankByFutureManual(ref CThostFtdcReqRepealField pReqRepeal,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 期货发起查询银行余额错误回报
    /// </summary>
    public virtual void OnErrRtnQueryBankBalanceByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo){}

    /// <summary>
    /// 期货发起冲正银行转期货请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public virtual void OnRtnRepealFromBankToFutureByFuture(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 期货发起冲正期货转银行请求，银行处理完毕后报盘发回的通知
    /// </summary>
    public virtual void OnRtnRepealFromFutureToBankByFuture(ref CThostFtdcRspRepealField pRspRepeal){}

    /// <summary>
    /// 期货发起银行资金转期货应答
    /// </summary>
    public virtual void OnRspFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 期货发起期货资金转银行应答
    /// </summary>
    public virtual void OnRspFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 期货发起查询银行余额应答
    /// </summary>
    public virtual void OnRspQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 银行发起银期开户通知
    /// </summary>
    public virtual void OnRtnOpenAccountByBank(ref CThostFtdcOpenAccountField pOpenAccount){}

    /// <summary>
    /// 银行发起银期销户通知
    /// </summary>
    public virtual void OnRtnCancelAccountByBank(ref CThostFtdcCancelAccountField pCancelAccount){}

    /// <summary>
    /// 银行发起变更银行账号通知
    /// </summary>
    public virtual void OnRtnChangeAccountByBank(ref CThostFtdcChangeAccountField pChangeAccount){}

    /// <summary>
    /// 请求查询分类合约响应
    /// </summary>
    public virtual void OnRspQryClassifiedInstrument(ref CThostFtdcInstrumentField pInstrument,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 请求组合优惠比例响应
    /// </summary>
    public virtual void OnRspQryCombPromotionParam(ref CThostFtdcCombPromotionParamField pCombPromotionParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者风险结算持仓查询响应
    /// </summary>
    public virtual void OnRspQryRiskSettleInvstPosition(ref CThostFtdcRiskSettleInvstPositionField pRiskSettleInvstPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 风险结算产品查询响应
    /// </summary>
    public virtual void OnRspQryRiskSettleProductStatus(ref CThostFtdcRiskSettleProductStatusField pRiskSettleProductStatus,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM期货合约参数查询响应
    /// </summary>
    public virtual void OnRspQrySPBMFutureParameter(ref CThostFtdcSPBMFutureParameterField pSPBMFutureParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM期权合约参数查询响应
    /// </summary>
    public virtual void OnRspQrySPBMOptionParameter(ref CThostFtdcSPBMOptionParameterField pSPBMOptionParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM品种内对锁仓折扣参数查询响应
    /// </summary>
    public virtual void OnRspQrySPBMIntraParameter(ref CThostFtdcSPBMIntraParameterField pSPBMIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM跨品种抵扣参数查询响应
    /// </summary>
    public virtual void OnRspQrySPBMInterParameter(ref CThostFtdcSPBMInterParameterField pSPBMInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM组合保证金套餐查询响应
    /// </summary>
    public virtual void OnRspQrySPBMPortfDefinition(ref CThostFtdcSPBMPortfDefinitionField pSPBMPortfDefinition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者SPBM套餐选择查询响应
    /// </summary>
    public virtual void OnRspQrySPBMInvestorPortfDef(ref CThostFtdcSPBMInvestorPortfDefField pSPBMInvestorPortfDef,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者新型组合保证金系数查询响应
    /// </summary>
    public virtual void OnRspQryInvestorPortfMarginRatio(ref CThostFtdcInvestorPortfMarginRatioField pInvestorPortfMarginRatio,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者产品SPBM明细查询响应
    /// </summary>
    public virtual void OnRspQryInvestorProdSPBMDetail(ref CThostFtdcInvestorProdSPBMDetailField pInvestorProdSPBMDetail,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者商品组SPMM记录查询响应
    /// </summary>
    public virtual void OnRspQryInvestorCommoditySPMMMargin(ref CThostFtdcInvestorCommoditySPMMMarginField pInvestorCommoditySPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者商品群SPMM记录查询响应
    /// </summary>
    public virtual void OnRspQryInvestorCommodityGroupSPMMMargin(ref CThostFtdcInvestorCommodityGroupSPMMMarginField pInvestorCommodityGroupSPMMMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPMM合约参数查询响应
    /// </summary>
    public virtual void OnRspQrySPMMInstParam(ref CThostFtdcSPMMInstParamField pSPMMInstParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPMM产品参数查询响应
    /// </summary>
    public virtual void OnRspQrySPMMProductParam(ref CThostFtdcSPMMProductParamField pSPMMProductParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// SPBM附加跨品种抵扣参数查询响应
    /// </summary>
    public virtual void OnRspQrySPBMAddOnInterParameter(ref CThostFtdcSPBMAddOnInterParameterField pSPBMAddOnInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS产品组合信息查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSCombProductInfo(ref CThostFtdcRCAMSCombProductInfoField pRCAMSCombProductInfo,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS同合约风险对冲参数查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSInstrParameter(ref CThostFtdcRCAMSInstrParameterField pRCAMSInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS品种内风险对冲参数查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSIntraParameter(ref CThostFtdcRCAMSIntraParameterField pRCAMSIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS跨品种风险折抵参数查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSInterParameter(ref CThostFtdcRCAMSInterParameterField pRCAMSInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS空头期权风险调整参数查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSShortOptAdjustParam(ref CThostFtdcRCAMSShortOptAdjustParamField pRCAMSShortOptAdjustParam,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RCAMS策略组合持仓查询响应
    /// </summary>
    public virtual void OnRspQryRCAMSInvestorCombPosition(ref CThostFtdcRCAMSInvestorCombPositionField pRCAMSInvestorCombPosition,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者品种RCAMS保证金查询响应
    /// </summary>
    public virtual void OnRspQryInvestorProdRCAMSMargin(ref CThostFtdcInvestorProdRCAMSMarginField pInvestorProdRCAMSMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RULE合约保证金参数查询响应
    /// </summary>
    public virtual void OnRspQryRULEInstrParameter(ref CThostFtdcRULEInstrParameterField pRULEInstrParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RULE品种内对锁仓折扣参数查询响应
    /// </summary>
    public virtual void OnRspQryRULEIntraParameter(ref CThostFtdcRULEIntraParameterField pRULEIntraParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// RULE跨品种抵扣参数查询响应
    /// </summary>
    public virtual void OnRspQryRULEInterParameter(ref CThostFtdcRULEInterParameterField pRULEInterParameter,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    /// <summary>
    /// 投资者产品RULE保证金查询响应
    /// </summary>
    public virtual void OnRspQryInvestorProdRULEMargin(ref CThostFtdcInvestorProdRULEMarginField pInvestorProdRULEMargin,ref CThostFtdcRspInfoField pRspInfo,int nRequestID,bool bIsLast){}

    private void Close()
    {
        CTPSharpPInvoke.CThostFtdcTraderSpi_Delete(_handle);
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
