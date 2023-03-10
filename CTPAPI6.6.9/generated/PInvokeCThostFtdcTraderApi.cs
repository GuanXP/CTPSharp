using System.Runtime.InteropServices;
namespace XP.CTPSharp;

internal partial class CTPSharpPInvoke
{
    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_Create", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcTraderApi_Create([MarshalAs(UnmanagedType.LPStr)] string pszFlowPath="");

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_GetApiVersion", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcTraderApi_GetApiVersion();

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_Release", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_Release(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_Init", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_Init(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_Join", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_Join(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_GetTradingDay", CharSet=CharSet.Ansi)]
   public extern static IntPtr CThostFtdcTraderApi_GetTradingDay(IntPtr handle);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterFront", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_RegisterFront(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterNameServer", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_RegisterNameServer(IntPtr handle, [MarshalAs(UnmanagedType.LPStr)] string pszNsAddress);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterFensUserInfo", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_RegisterFensUserInfo(IntPtr handle, ref CThostFtdcFensUserInfoField pFensUserInfo);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterSpi", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_RegisterSpi(IntPtr handle, IntPtr pSpi);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_SubscribePrivateTopic", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_SubscribePrivateTopic(IntPtr handle, THOST_TE_RESUME_TYPE nResumeType);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_SubscribePublicTopic", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_SubscribePublicTopic(IntPtr handle, THOST_TE_RESUME_TYPE nResumeType);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqAuthenticate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqAuthenticate(IntPtr handle, ref CThostFtdcReqAuthenticateField pReqAuthenticateField,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterUserSystemInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_RegisterUserSystemInfo(IntPtr handle, ref CThostFtdcUserSystemInfoField pUserSystemInfo);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_SubmitUserSystemInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_SubmitUserSystemInfo(IntPtr handle, ref CThostFtdcUserSystemInfoField pUserSystemInfo);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserLogin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserLogin(IntPtr handle, ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserLogout", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserLogout(IntPtr handle, ref CThostFtdcUserLogoutField pUserLogout,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserPasswordUpdate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserPasswordUpdate(IntPtr handle, ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate(IntPtr handle, ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserAuthMethod", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserAuthMethod(IntPtr handle, ref CThostFtdcReqUserAuthMethodField pReqUserAuthMethod,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqGenUserCaptcha", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqGenUserCaptcha(IntPtr handle, ref CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqGenUserText", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqGenUserText(IntPtr handle, ref CThostFtdcReqGenUserTextField pReqGenUserText,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserLoginWithCaptcha", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserLoginWithCaptcha(IntPtr handle, ref CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserLoginWithText", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserLoginWithText(IntPtr handle, ref CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqUserLoginWithOTP", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqUserLoginWithOTP(IntPtr handle, ref CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqOrderInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqOrderInsert(IntPtr handle, ref CThostFtdcInputOrderField pInputOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqParkedOrderInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqParkedOrderInsert(IntPtr handle, ref CThostFtdcParkedOrderField pParkedOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqParkedOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqParkedOrderAction(IntPtr handle, ref CThostFtdcParkedOrderActionField pParkedOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqOrderAction(IntPtr handle, ref CThostFtdcInputOrderActionField pInputOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryMaxOrderVolume", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryMaxOrderVolume(IntPtr handle, ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqSettlementInfoConfirm", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqSettlementInfoConfirm(IntPtr handle, ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqRemoveParkedOrder", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqRemoveParkedOrder(IntPtr handle, ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqRemoveParkedOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqRemoveParkedOrderAction(IntPtr handle, ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqExecOrderInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqExecOrderInsert(IntPtr handle, ref CThostFtdcInputExecOrderField pInputExecOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqExecOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqExecOrderAction(IntPtr handle, ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqForQuoteInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqForQuoteInsert(IntPtr handle, ref CThostFtdcInputForQuoteField pInputForQuote,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQuoteInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQuoteInsert(IntPtr handle, ref CThostFtdcInputQuoteField pInputQuote,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQuoteAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQuoteAction(IntPtr handle, ref CThostFtdcInputQuoteActionField pInputQuoteAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqBatchOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqBatchOrderAction(IntPtr handle, ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqOptionSelfCloseInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqOptionSelfCloseInsert(IntPtr handle, ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqOptionSelfCloseAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqOptionSelfCloseAction(IntPtr handle, ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqCombActionInsert", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqCombActionInsert(IntPtr handle, ref CThostFtdcInputCombActionField pInputCombAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryOrder", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryOrder(IntPtr handle, ref CThostFtdcQryOrderField pQryOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTrade", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTrade(IntPtr handle, ref CThostFtdcQryTradeField pQryTrade,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorPosition", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorPosition(IntPtr handle, ref CThostFtdcQryInvestorPositionField pQryInvestorPosition,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTradingAccount", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTradingAccount(IntPtr handle, ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestor", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestor(IntPtr handle, ref CThostFtdcQryInvestorField pQryInvestor,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTradingCode", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTradingCode(IntPtr handle, ref CThostFtdcQryTradingCodeField pQryTradingCode,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInstrumentMarginRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInstrumentMarginRate(IntPtr handle, ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInstrumentCommissionRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInstrumentCommissionRate(IntPtr handle, ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryExchange", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryExchange(IntPtr handle, ref CThostFtdcQryExchangeField pQryExchange,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryProduct", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryProduct(IntPtr handle, ref CThostFtdcQryProductField pQryProduct,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInstrument", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInstrument(IntPtr handle, ref CThostFtdcQryInstrumentField pQryInstrument,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryDepthMarketData", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryDepthMarketData(IntPtr handle, ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTraderOffer", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTraderOffer(IntPtr handle, ref CThostFtdcQryTraderOfferField pQryTraderOffer,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySettlementInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySettlementInfo(IntPtr handle, ref CThostFtdcQrySettlementInfoField pQrySettlementInfo,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTransferBank", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTransferBank(IntPtr handle, ref CThostFtdcQryTransferBankField pQryTransferBank,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorPositionDetail", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorPositionDetail(IntPtr handle, ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryNotice", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryNotice(IntPtr handle, ref CThostFtdcQryNoticeField pQryNotice,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySettlementInfoConfirm", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySettlementInfoConfirm(IntPtr handle, ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail(IntPtr handle, ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey(IntPtr handle, ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryEWarrantOffset", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryEWarrantOffset(IntPtr handle, ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin(IntPtr handle, ref CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryExchangeMarginRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryExchangeMarginRate(IntPtr handle, ref CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust(IntPtr handle, ref CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryExchangeRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryExchangeRate(IntPtr handle, ref CThostFtdcQryExchangeRateField pQryExchangeRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySecAgentACIDMap", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySecAgentACIDMap(IntPtr handle, ref CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryProductExchRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryProductExchRate(IntPtr handle, ref CThostFtdcQryProductExchRateField pQryProductExchRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryProductGroup", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryProductGroup(IntPtr handle, ref CThostFtdcQryProductGroupField pQryProductGroup,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate(IntPtr handle, ref CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate(IntPtr handle, ref CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate(IntPtr handle, ref CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySecAgentTradingAccount", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySecAgentTradingAccount(IntPtr handle, ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySecAgentCheckMode", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySecAgentCheckMode(IntPtr handle, ref CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySecAgentTradeInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySecAgentTradeInfo(IntPtr handle, ref CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryOptionInstrTradeCost", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryOptionInstrTradeCost(IntPtr handle, ref CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryOptionInstrCommRate", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryOptionInstrCommRate(IntPtr handle, ref CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryExecOrder", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryExecOrder(IntPtr handle, ref CThostFtdcQryExecOrderField pQryExecOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryForQuote", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryForQuote(IntPtr handle, ref CThostFtdcQryForQuoteField pQryForQuote,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryQuote", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryQuote(IntPtr handle, ref CThostFtdcQryQuoteField pQryQuote,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryOptionSelfClose", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryOptionSelfClose(IntPtr handle, ref CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestUnit", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestUnit(IntPtr handle, ref CThostFtdcQryInvestUnitField pQryInvestUnit,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryCombInstrumentGuard", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryCombInstrumentGuard(IntPtr handle, ref CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryCombAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryCombAction(IntPtr handle, ref CThostFtdcQryCombActionField pQryCombAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTransferSerial", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTransferSerial(IntPtr handle, ref CThostFtdcQryTransferSerialField pQryTransferSerial,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryAccountregister", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryAccountregister(IntPtr handle, ref CThostFtdcQryAccountregisterField pQryAccountregister,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryContractBank", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryContractBank(IntPtr handle, ref CThostFtdcQryContractBankField pQryContractBank,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryParkedOrder", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryParkedOrder(IntPtr handle, ref CThostFtdcQryParkedOrderField pQryParkedOrder,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryParkedOrderAction", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryParkedOrderAction(IntPtr handle, ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryTradingNotice", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryTradingNotice(IntPtr handle, ref CThostFtdcQryTradingNoticeField pQryTradingNotice,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryBrokerTradingParams", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryBrokerTradingParams(IntPtr handle, ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryBrokerTradingAlgos", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryBrokerTradingAlgos(IntPtr handle, ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken(IntPtr handle, ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqFromBankToFutureByFuture", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqFromBankToFutureByFuture(IntPtr handle, ref CThostFtdcReqTransferField pReqTransfer,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqFromFutureToBankByFuture", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqFromFutureToBankByFuture(IntPtr handle, ref CThostFtdcReqTransferField pReqTransfer,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture(IntPtr handle, ref CThostFtdcReqQueryAccountField pReqQueryAccount,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryClassifiedInstrument", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryClassifiedInstrument(IntPtr handle, ref CThostFtdcQryClassifiedInstrumentField pQryClassifiedInstrument,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryCombPromotionParam", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryCombPromotionParam(IntPtr handle, ref CThostFtdcQryCombPromotionParamField pQryCombPromotionParam,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition(IntPtr handle, ref CThostFtdcQryRiskSettleInvstPositionField pQryRiskSettleInvstPosition,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRiskSettleProductStatus", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRiskSettleProductStatus(IntPtr handle, ref CThostFtdcQryRiskSettleProductStatusField pQryRiskSettleProductStatus,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMFutureParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMFutureParameter(IntPtr handle, ref CThostFtdcQrySPBMFutureParameterField pQrySPBMFutureParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMOptionParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMOptionParameter(IntPtr handle, ref CThostFtdcQrySPBMOptionParameterField pQrySPBMOptionParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMIntraParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMIntraParameter(IntPtr handle, ref CThostFtdcQrySPBMIntraParameterField pQrySPBMIntraParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMInterParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMInterParameter(IntPtr handle, ref CThostFtdcQrySPBMInterParameterField pQrySPBMInterParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMPortfDefinition", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMPortfDefinition(IntPtr handle, ref CThostFtdcQrySPBMPortfDefinitionField pQrySPBMPortfDefinition,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef(IntPtr handle, ref CThostFtdcQrySPBMInvestorPortfDefField pQrySPBMInvestorPortfDef,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio(IntPtr handle, ref CThostFtdcQryInvestorPortfMarginRatioField pQryInvestorPortfMarginRatio,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail(IntPtr handle, ref CThostFtdcQryInvestorProdSPBMDetailField pQryInvestorProdSPBMDetail,int nRequestID);

}
public sealed class CThostFtdcTraderApi
{
    IntPtr _handle;
    public CThostFtdcTraderApi(string flowPath)
    {
        _handle = CTPSharpPInvoke.CThostFtdcTraderApi_Create(flowPath);
    }

    /// <summary>
    /// ??????API???????????????
    /// </summary>
    public string GetApiVersion()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcTraderApi_GetApiVersion());
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public void Release()
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_Release(_handle);
    }

    /// <summary>
    /// ?????????
    /// </summary>
    public void Init()
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_Init(_handle);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int Join()
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_Join(_handle);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public string GetTradingDay()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcTraderApi_GetTradingDay(_handle));
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    /// <param name="pszFrontAddress">????????????????????????</param>
    public void RegisterFront([MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterFront(_handle, pszFrontAddress);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    /// <param name="pszNsAddress">??????????????????????????????</param>
    public void RegisterNameServer([MarshalAs(UnmanagedType.LPStr)] string pszNsAddress)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterNameServer(_handle, pszNsAddress);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    /// <param name="pFensUserInfo">???????????????</param>
    public void RegisterFensUserInfo(ref CThostFtdcFensUserInfoField pFensUserInfo)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterFensUserInfo(_handle, ref pFensUserInfo);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    /// <param name="pSpi">?????????????????????????????????</param>
    public void RegisterSpi(IntPtr pSpi)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterSpi(_handle, pSpi);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    /// <param name="nResumeType">?????????????????????</param>
    public void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_SubscribePrivateTopic(_handle, nResumeType);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    /// <param name="nResumeType">?????????????????????</param>
    public void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_SubscribePublicTopic(_handle, nResumeType);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqAuthenticate(ref CThostFtdcReqAuthenticateField pReqAuthenticateField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqAuthenticate(_handle, ref pReqAuthenticateField,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????????????????????????????
    /// </summary>
    public int RegisterUserSystemInfo(ref CThostFtdcUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_RegisterUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// ?????????????????????????????????????????????????????????????????????
    /// </summary>
    public int SubmitUserSystemInfo(ref CThostFtdcUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_SubmitUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLogin(_handle, ref pReqUserLoginField,nRequestID);
    }

    /// <summary>
    /// ????????????
    /// </summary>
    public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLogout(_handle, ref pUserLogout,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserPasswordUpdate(_handle, ref pUserPasswordUpdate,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate(_handle, ref pTradingAccountPasswordUpdate,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqUserAuthMethod(ref CThostFtdcReqUserAuthMethodField pReqUserAuthMethod,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserAuthMethod(_handle, ref pReqUserAuthMethod,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqGenUserCaptcha(ref CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqGenUserCaptcha(_handle, ref pReqGenUserCaptcha,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqGenUserText(ref CThostFtdcReqGenUserTextField pReqGenUserText,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqGenUserText(_handle, ref pReqGenUserText,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????????????????
    /// </summary>
    public int ReqUserLoginWithCaptcha(ref CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithCaptcha(_handle, ref pReqUserLoginWithCaptcha,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????????????????
    /// </summary>
    public int ReqUserLoginWithText(ref CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithText(_handle, ref pReqUserLoginWithText,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????????????????
    /// </summary>
    public int ReqUserLoginWithOTP(ref CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithOTP(_handle, ref pReqUserLoginWithOTP,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqOrderInsert(ref CThostFtdcInputOrderField pInputOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOrderInsert(_handle, ref pInputOrder,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqParkedOrderInsert(_handle, ref pParkedOrder,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqParkedOrderAction(_handle, ref pParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOrderAction(_handle, ref pInputOrderAction,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryMaxOrderVolume(ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMaxOrderVolume(_handle, ref pQryMaxOrderVolume,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqSettlementInfoConfirm(_handle, ref pSettlementInfoConfirm,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqRemoveParkedOrder(_handle, ref pRemoveParkedOrder,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqRemoveParkedOrderAction(_handle, ref pRemoveParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqExecOrderInsert(_handle, ref pInputExecOrder,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqExecOrderAction(ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqExecOrderAction(_handle, ref pInputExecOrderAction,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqForQuoteInsert(_handle, ref pInputForQuote,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQuoteInsert(_handle, ref pInputQuote,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQuoteAction(ref CThostFtdcInputQuoteActionField pInputQuoteAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQuoteAction(_handle, ref pInputQuoteAction,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqBatchOrderAction(ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqBatchOrderAction(_handle, ref pInputBatchOrderAction,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOptionSelfCloseInsert(_handle, ref pInputOptionSelfClose,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqOptionSelfCloseAction(ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOptionSelfCloseAction(_handle, ref pInputOptionSelfCloseAction,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqCombActionInsert(_handle, ref pInputCombAction,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryOrder(ref CThostFtdcQryOrderField pQryOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOrder(_handle, ref pQryOrder,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryTrade(ref CThostFtdcQryTradeField pQryTrade,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTrade(_handle, ref pQryTrade,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqQryInvestorPosition(ref CThostFtdcQryInvestorPositionField pQryInvestorPosition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPosition(_handle, ref pQryInvestorPosition,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryTradingAccount(ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingAccount(_handle, ref pQryTradingAccount,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqQryInvestor(ref CThostFtdcQryInvestorField pQryInvestor,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestor(_handle, ref pQryInvestor,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryTradingCode(ref CThostFtdcQryTradingCodeField pQryTradingCode,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingCode(_handle, ref pQryTradingCode,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryInstrumentMarginRate(ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentMarginRate(_handle, ref pQryInstrumentMarginRate,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryInstrumentCommissionRate(ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentCommissionRate(_handle, ref pQryInstrumentCommissionRate,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqQryExchange(ref CThostFtdcQryExchangeField pQryExchange,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchange(_handle, ref pQryExchange,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryProduct(ref CThostFtdcQryProductField pQryProduct,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProduct(_handle, ref pQryProduct,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryInstrument(ref CThostFtdcQryInstrumentField pQryInstrument,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrument(_handle, ref pQryInstrument,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryDepthMarketData(ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryDepthMarketData(_handle, ref pQryDepthMarketData,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryTraderOffer(ref CThostFtdcQryTraderOfferField pQryTraderOffer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTraderOffer(_handle, ref pQryTraderOffer,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQrySettlementInfo(ref CThostFtdcQrySettlementInfoField pQrySettlementInfo,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySettlementInfo(_handle, ref pQrySettlementInfo,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryTransferBank(ref CThostFtdcQryTransferBankField pQryTransferBank,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTransferBank(_handle, ref pQryTransferBank,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQryInvestorPositionDetail(ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPositionDetail(_handle, ref pQryInvestorPositionDetail,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryNotice(ref CThostFtdcQryNoticeField pQryNotice,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryNotice(_handle, ref pQryNotice,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQrySettlementInfoConfirm(ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySettlementInfoConfirm(_handle, ref pQrySettlementInfoConfirm,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQryInvestorPositionCombineDetail(ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail(_handle, ref pQryInvestorPositionCombineDetail,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????????????????????????????
    /// </summary>
    public int ReqQryCFMMCTradingAccountKey(ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey(_handle, ref pQryCFMMCTradingAccountKey,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryEWarrantOffset(ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryEWarrantOffset(_handle, ref pQryEWarrantOffset,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????/??????????????????
    /// </summary>
    public int ReqQryInvestorProductGroupMargin(ref CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin(_handle, ref pQryInvestorProductGroupMargin,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQryExchangeMarginRate(ref CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeMarginRate(_handle, ref pQryExchangeMarginRate,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqQryExchangeMarginRateAdjust(ref CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust(_handle, ref pQryExchangeMarginRateAdjust,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryExchangeRate(ref CThostFtdcQryExchangeRateField pQryExchangeRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeRate(_handle, ref pQryExchangeRate,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????????????????
    /// </summary>
    public int ReqQrySecAgentACIDMap(ref CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentACIDMap(_handle, ref pQrySecAgentACIDMap,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryProductExchRate(ref CThostFtdcQryProductExchRateField pQryProductExchRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProductExchRate(_handle, ref pQryProductExchRate,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqQryProductGroup(ref CThostFtdcQryProductGroupField pQryProductGroup,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProductGroup(_handle, ref pQryProductGroup,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqQryMMInstrumentCommissionRate(ref CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate(_handle, ref pQryMMInstrumentCommissionRate,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????????????????
    /// </summary>
    public int ReqQryMMOptionInstrCommRate(ref CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate(_handle, ref pQryMMOptionInstrCommRate,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqQryInstrumentOrderCommRate(ref CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate(_handle, ref pQryInstrumentOrderCommRate,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQrySecAgentTradingAccount(ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentTradingAccount(_handle, ref pQryTradingAccount,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????????????????
    /// </summary>
    public int ReqQrySecAgentCheckMode(ref CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentCheckMode(_handle, ref pQrySecAgentCheckMode,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQrySecAgentTradeInfo(ref CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentTradeInfo(_handle, ref pQrySecAgentTradeInfo,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryOptionInstrTradeCost(ref CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionInstrTradeCost(_handle, ref pQryOptionInstrTradeCost,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQryOptionInstrCommRate(ref CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionInstrCommRate(_handle, ref pQryOptionInstrCommRate,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryExecOrder(ref CThostFtdcQryExecOrderField pQryExecOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExecOrder(_handle, ref pQryExecOrder,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryForQuote(ref CThostFtdcQryForQuoteField pQryForQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryForQuote(_handle, ref pQryForQuote,nRequestID);
    }

    /// <summary>
    /// ??????????????????
    /// </summary>
    public int ReqQryQuote(ref CThostFtdcQryQuoteField pQryQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryQuote(_handle, ref pQryQuote,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????
    /// </summary>
    public int ReqQryOptionSelfClose(ref CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionSelfClose(_handle, ref pQryOptionSelfClose,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryInvestUnit(ref CThostFtdcQryInvestUnitField pQryInvestUnit,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestUnit(_handle, ref pQryInvestUnit,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    public int ReqQryCombInstrumentGuard(ref CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombInstrumentGuard(_handle, ref pQryCombInstrumentGuard,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryCombAction(ref CThostFtdcQryCombActionField pQryCombAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombAction(_handle, ref pQryCombAction,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryTransferSerial(ref CThostFtdcQryTransferSerialField pQryTransferSerial,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTransferSerial(_handle, ref pQryTransferSerial,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????
    /// </summary>
    public int ReqQryAccountregister(ref CThostFtdcQryAccountregisterField pQryAccountregister,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryAccountregister(_handle, ref pQryAccountregister,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryContractBank(ref CThostFtdcQryContractBankField pQryContractBank,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryContractBank(_handle, ref pQryContractBank,nRequestID);
    }

    /// <summary>
    /// ?????????????????????
    /// </summary>
    public int ReqQryParkedOrder(ref CThostFtdcQryParkedOrderField pQryParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryParkedOrder(_handle, ref pQryParkedOrder,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryParkedOrderAction(ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryParkedOrderAction(_handle, ref pQryParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryTradingNotice(ref CThostFtdcQryTradingNoticeField pQryTradingNotice,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingNotice(_handle, ref pQryTradingNotice,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    public int ReqQryBrokerTradingParams(ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryBrokerTradingParams(_handle, ref pQryBrokerTradingParams,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    public int ReqQryBrokerTradingAlgos(ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryBrokerTradingAlgos(_handle, ref pQryBrokerTradingAlgos,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    public int ReqQueryCFMMCTradingAccountToken(ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken(_handle, ref pQueryCFMMCTradingAccountToken,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqFromBankToFutureByFuture(_handle, ref pReqTransfer,nRequestID);
    }

    /// <summary>
    /// ???????????????????????????????????????
    /// </summary>
    public int ReqFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqFromFutureToBankByFuture(_handle, ref pReqTransfer,nRequestID);
    }

    /// <summary>
    /// ????????????????????????????????????
    /// </summary>
    public int ReqQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture(_handle, ref pReqQueryAccount,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryClassifiedInstrument(ref CThostFtdcQryClassifiedInstrumentField pQryClassifiedInstrument,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryClassifiedInstrument(_handle, ref pQryClassifiedInstrument,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryCombPromotionParam(ref CThostFtdcQryCombPromotionParamField pQryCombPromotionParam,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombPromotionParam(_handle, ref pQryCombPromotionParam,nRequestID);
    }

    /// <summary>
    /// ?????????????????????????????????
    /// </summary>
    public int ReqQryRiskSettleInvstPosition(ref CThostFtdcQryRiskSettleInvstPositionField pQryRiskSettleInvstPosition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition(_handle, ref pQryRiskSettleInvstPosition,nRequestID);
    }

    /// <summary>
    /// ????????????????????????
    /// </summary>
    public int ReqQryRiskSettleProductStatus(ref CThostFtdcQryRiskSettleProductStatusField pQryRiskSettleProductStatus,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRiskSettleProductStatus(_handle, ref pQryRiskSettleProductStatus,nRequestID);
    }

    /// <summary>
    /// SPBM????????????????????????
    /// </summary>
    public int ReqQrySPBMFutureParameter(ref CThostFtdcQrySPBMFutureParameterField pQrySPBMFutureParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMFutureParameter(_handle, ref pQrySPBMFutureParameter,nRequestID);
    }

    /// <summary>
    /// SPBM????????????????????????
    /// </summary>
    public int ReqQrySPBMOptionParameter(ref CThostFtdcQrySPBMOptionParameterField pQrySPBMOptionParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMOptionParameter(_handle, ref pQrySPBMOptionParameter,nRequestID);
    }

    /// <summary>
    /// SPBM????????????????????????????????????
    /// </summary>
    public int ReqQrySPBMIntraParameter(ref CThostFtdcQrySPBMIntraParameterField pQrySPBMIntraParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMIntraParameter(_handle, ref pQrySPBMIntraParameter,nRequestID);
    }

    /// <summary>
    /// SPBM???????????????????????????
    /// </summary>
    public int ReqQrySPBMInterParameter(ref CThostFtdcQrySPBMInterParameterField pQrySPBMInterParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMInterParameter(_handle, ref pQrySPBMInterParameter,nRequestID);
    }

    /// <summary>
    /// SPBM???????????????????????????
    /// </summary>
    public int ReqQrySPBMPortfDefinition(ref CThostFtdcQrySPBMPortfDefinitionField pQrySPBMPortfDefinition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMPortfDefinition(_handle, ref pQrySPBMPortfDefinition,nRequestID);
    }

    /// <summary>
    /// ?????????SPBM??????????????????
    /// </summary>
    public int ReqQrySPBMInvestorPortfDef(ref CThostFtdcQrySPBMInvestorPortfDefField pQrySPBMInvestorPortfDef,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef(_handle, ref pQrySPBMInvestorPortfDef,nRequestID);
    }

    /// <summary>
    /// ??????????????????????????????????????????
    /// </summary>
    public int ReqQryInvestorPortfMarginRatio(ref CThostFtdcQryInvestorPortfMarginRatioField pQryInvestorPortfMarginRatio,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio(_handle, ref pQryInvestorPortfMarginRatio,nRequestID);
    }

    /// <summary>
    /// ???????????????SPBM????????????
    /// </summary>
    public int ReqQryInvestorProdSPBMDetail(ref CThostFtdcQryInvestorProdSPBMDetailField pQryInvestorProdSPBMDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail(_handle, ref pQryInvestorProdSPBMDetail,nRequestID);
    }

    public void Dispose()
    {
        if (_handle == 0) return;
        CTPSharpPInvoke.CThostFtdcTraderApi_Release(_handle);
        //CTPSharpPInvoke.CThostFtdcTraderApi_Join(_handle);
        _handle = 0;
    }
}
