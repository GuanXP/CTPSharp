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

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_GetFrontInfo", CharSet=CharSet.Ansi)]
   public extern static void CThostFtdcTraderApi_GetFrontInfo(IntPtr handle, ref CThostFtdcFrontInfoField pFrontInfo);

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

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_RegisterWechatUserSystemInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_RegisterWechatUserSystemInfo(IntPtr handle, ref CThostFtdcWechatUserSystemInfoField pUserSystemInfo);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_SubmitWechatUserSystemInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_SubmitWechatUserSystemInfo(IntPtr handle, ref CThostFtdcWechatUserSystemInfoField pUserSystemInfo);

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

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorCommoditySPMMMargin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorCommoditySPMMMargin(IntPtr handle, ref CThostFtdcQryInvestorCommoditySPMMMarginField pQryInvestorCommoditySPMMMargin,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorCommodityGroupSPMMMargin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorCommodityGroupSPMMMargin(IntPtr handle, ref CThostFtdcQryInvestorCommodityGroupSPMMMarginField pQryInvestorCommodityGroupSPMMMargin,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPMMInstParam", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPMMInstParam(IntPtr handle, ref CThostFtdcQrySPMMInstParamField pQrySPMMInstParam,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPMMProductParam", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPMMProductParam(IntPtr handle, ref CThostFtdcQrySPMMProductParamField pQrySPMMProductParam,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQrySPBMAddOnInterParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQrySPBMAddOnInterParameter(IntPtr handle, ref CThostFtdcQrySPBMAddOnInterParameterField pQrySPBMAddOnInterParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSCombProductInfo", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSCombProductInfo(IntPtr handle, ref CThostFtdcQryRCAMSCombProductInfoField pQryRCAMSCombProductInfo,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSInstrParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSInstrParameter(IntPtr handle, ref CThostFtdcQryRCAMSInstrParameterField pQryRCAMSInstrParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSIntraParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSIntraParameter(IntPtr handle, ref CThostFtdcQryRCAMSIntraParameterField pQryRCAMSIntraParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSInterParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSInterParameter(IntPtr handle, ref CThostFtdcQryRCAMSInterParameterField pQryRCAMSInterParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSShortOptAdjustParam", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSShortOptAdjustParam(IntPtr handle, ref CThostFtdcQryRCAMSShortOptAdjustParamField pQryRCAMSShortOptAdjustParam,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRCAMSInvestorCombPosition", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRCAMSInvestorCombPosition(IntPtr handle, ref CThostFtdcQryRCAMSInvestorCombPositionField pQryRCAMSInvestorCombPosition,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorProdRCAMSMargin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorProdRCAMSMargin(IntPtr handle, ref CThostFtdcQryInvestorProdRCAMSMarginField pQryInvestorProdRCAMSMargin,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRULEInstrParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRULEInstrParameter(IntPtr handle, ref CThostFtdcQryRULEInstrParameterField pQryRULEInstrParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRULEIntraParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRULEIntraParameter(IntPtr handle, ref CThostFtdcQryRULEIntraParameterField pQryRULEIntraParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryRULEInterParameter", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryRULEInterParameter(IntPtr handle, ref CThostFtdcQryRULEInterParameterField pQryRULEInterParameter,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorProdRULEMargin", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorProdRULEMargin(IntPtr handle, ref CThostFtdcQryInvestorProdRULEMarginField pQryInvestorProdRULEMargin,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorPortfSetting", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorPortfSetting(IntPtr handle, ref CThostFtdcQryInvestorPortfSettingField pQryInvestorPortfSetting,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryInvestorInfoCommRec", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryInvestorInfoCommRec(IntPtr handle, ref CThostFtdcQryInvestorInfoCommRecField pQryInvestorInfoCommRec,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryCombLeg", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryCombLeg(IntPtr handle, ref CThostFtdcQryCombLegField pQryCombLeg,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqOffsetSetting", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqOffsetSetting(IntPtr handle, ref CThostFtdcInputOffsetSettingField pInputOffsetSetting,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqCancelOffsetSetting", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqCancelOffsetSetting(IntPtr handle, ref CThostFtdcInputOffsetSettingField pInputOffsetSetting,int nRequestID);

    [DllImport("CTPInvoke", EntryPoint="CThostFtdcTraderApi_ReqQryOffsetSetting", CharSet=CharSet.Ansi)]
   public extern static int CThostFtdcTraderApi_ReqQryOffsetSetting(IntPtr handle, ref CThostFtdcQryOffsetSettingField pQryOffsetSetting,int nRequestID);

}
public sealed class CThostFtdcTraderApi
{
    IntPtr _handle;
    public CThostFtdcTraderApi(string flowPath)
    {
        _handle = CTPSharpPInvoke.CThostFtdcTraderApi_Create(flowPath);
    }

    /// <summary>
    /// 获取API的版本信息
    /// </summary>
    public string GetApiVersion()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcTraderApi_GetApiVersion());
    }

    /// <summary>
    /// 删除接口对象本身
    /// </summary>
    public void Release()
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_Release(_handle);
    }

    /// <summary>
    /// 初始化
    /// </summary>
    public void Init()
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_Init(_handle);
    }

    /// <summary>
    /// 等待接口线程结束运行
    /// </summary>
    public int Join()
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_Join(_handle);
    }

    /// <summary>
    /// 获取当前交易日
    /// </summary>
    public string GetTradingDay()
    {
        return GBKConvert.Instance.GetString(CTPSharpPInvoke.CThostFtdcTraderApi_GetTradingDay(_handle));
    }

    /// <summary>
    /// 获取已连接的前置的信息
    /// </summary>
    public void GetFrontInfo(ref CThostFtdcFrontInfoField pFrontInfo)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_GetFrontInfo(_handle, ref pFrontInfo);
    }

    /// <summary>
    /// 注册前置机网络地址
    /// </summary>
    /// <param name="pszFrontAddress">前置机网络地址。</param>
    public void RegisterFront([MarshalAs(UnmanagedType.LPStr)] string pszFrontAddress)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterFront(_handle, pszFrontAddress);
    }

    /// <summary>
    /// 注册名字服务器网络地址
    /// </summary>
    /// <param name="pszNsAddress">名字服务器网络地址。</param>
    public void RegisterNameServer([MarshalAs(UnmanagedType.LPStr)] string pszNsAddress)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterNameServer(_handle, pszNsAddress);
    }

    /// <summary>
    /// 注册名字服务器用户信息
    /// </summary>
    /// <param name="pFensUserInfo">用户信息。</param>
    public void RegisterFensUserInfo(ref CThostFtdcFensUserInfoField pFensUserInfo)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterFensUserInfo(_handle, ref pFensUserInfo);
    }

    /// <summary>
    /// 注册回调接口
    /// </summary>
    /// <param name="pSpi">派生自回调接口类的实例</param>
    public void RegisterSpi(IntPtr pSpi)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_RegisterSpi(_handle, pSpi);
    }

    /// <summary>
    /// 订阅私有流。
    /// </summary>
    /// <param name="nResumeType">私有流重传方式</param>
    public void SubscribePrivateTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_SubscribePrivateTopic(_handle, nResumeType);
    }

    /// <summary>
    /// 订阅公共流。
    /// </summary>
    /// <param name="nResumeType">公共流重传方式</param>
    public void SubscribePublicTopic(THOST_TE_RESUME_TYPE nResumeType)
    {
        CTPSharpPInvoke.CThostFtdcTraderApi_SubscribePublicTopic(_handle, nResumeType);
    }

    /// <summary>
    /// 客户端认证请求
    /// </summary>
    public int ReqAuthenticate(ref CThostFtdcReqAuthenticateField pReqAuthenticateField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqAuthenticate(_handle, ref pReqAuthenticateField,nRequestID);
    }

    /// <summary>
    /// 注册用户终端信息，用于中继服务器多连接模式
    /// </summary>
    public int RegisterUserSystemInfo(ref CThostFtdcUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_RegisterUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// 上报用户终端信息，用于中继服务器操作员登录模式
    /// </summary>
    public int SubmitUserSystemInfo(ref CThostFtdcUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_SubmitUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// 注册用户终端信息，用于中继服务器多连接模式.用于微信小程序等应用上报信息.
    /// </summary>
    public int RegisterWechatUserSystemInfo(ref CThostFtdcWechatUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_RegisterWechatUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// 上报用户终端信息，用于中继服务器操作员登录模式.用于微信小程序等应用上报信息.
    /// </summary>
    public int SubmitWechatUserSystemInfo(ref CThostFtdcWechatUserSystemInfoField pUserSystemInfo)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_SubmitWechatUserSystemInfo(_handle, ref pUserSystemInfo);
    }

    /// <summary>
    /// 用户登录请求
    /// </summary>
    public int ReqUserLogin(ref CThostFtdcReqUserLoginField pReqUserLoginField,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLogin(_handle, ref pReqUserLoginField,nRequestID);
    }

    /// <summary>
    /// 登出请求
    /// </summary>
    public int ReqUserLogout(ref CThostFtdcUserLogoutField pUserLogout,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLogout(_handle, ref pUserLogout,nRequestID);
    }

    /// <summary>
    /// 用户口令更新请求
    /// </summary>
    public int ReqUserPasswordUpdate(ref CThostFtdcUserPasswordUpdateField pUserPasswordUpdate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserPasswordUpdate(_handle, ref pUserPasswordUpdate,nRequestID);
    }

    /// <summary>
    /// 资金账户口令更新请求
    /// </summary>
    public int ReqTradingAccountPasswordUpdate(ref CThostFtdcTradingAccountPasswordUpdateField pTradingAccountPasswordUpdate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate(_handle, ref pTradingAccountPasswordUpdate,nRequestID);
    }

    /// <summary>
    /// 查询用户当前支持的认证模式
    /// </summary>
    public int ReqUserAuthMethod(ref CThostFtdcReqUserAuthMethodField pReqUserAuthMethod,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserAuthMethod(_handle, ref pReqUserAuthMethod,nRequestID);
    }

    /// <summary>
    /// 用户发出获取图形验证码请求
    /// </summary>
    public int ReqGenUserCaptcha(ref CThostFtdcReqGenUserCaptchaField pReqGenUserCaptcha,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqGenUserCaptcha(_handle, ref pReqGenUserCaptcha,nRequestID);
    }

    /// <summary>
    /// 用户发出获取短信验证码请求
    /// </summary>
    public int ReqGenUserText(ref CThostFtdcReqGenUserTextField pReqGenUserText,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqGenUserText(_handle, ref pReqGenUserText,nRequestID);
    }

    /// <summary>
    /// 用户发出带有图片验证码的登陆请求
    /// </summary>
    public int ReqUserLoginWithCaptcha(ref CThostFtdcReqUserLoginWithCaptchaField pReqUserLoginWithCaptcha,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithCaptcha(_handle, ref pReqUserLoginWithCaptcha,nRequestID);
    }

    /// <summary>
    /// 用户发出带有短信验证码的登陆请求
    /// </summary>
    public int ReqUserLoginWithText(ref CThostFtdcReqUserLoginWithTextField pReqUserLoginWithText,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithText(_handle, ref pReqUserLoginWithText,nRequestID);
    }

    /// <summary>
    /// 用户发出带有动态口令的登陆请求
    /// </summary>
    public int ReqUserLoginWithOTP(ref CThostFtdcReqUserLoginWithOTPField pReqUserLoginWithOTP,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqUserLoginWithOTP(_handle, ref pReqUserLoginWithOTP,nRequestID);
    }

    /// <summary>
    /// 报单录入请求
    /// </summary>
    public int ReqOrderInsert(ref CThostFtdcInputOrderField pInputOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOrderInsert(_handle, ref pInputOrder,nRequestID);
    }

    /// <summary>
    /// 预埋单录入请求
    /// </summary>
    public int ReqParkedOrderInsert(ref CThostFtdcParkedOrderField pParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqParkedOrderInsert(_handle, ref pParkedOrder,nRequestID);
    }

    /// <summary>
    /// 预埋撤单录入请求
    /// </summary>
    public int ReqParkedOrderAction(ref CThostFtdcParkedOrderActionField pParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqParkedOrderAction(_handle, ref pParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// 报单操作请求
    /// </summary>
    public int ReqOrderAction(ref CThostFtdcInputOrderActionField pInputOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOrderAction(_handle, ref pInputOrderAction,nRequestID);
    }

    /// <summary>
    /// 查询最大报单数量请求
    /// </summary>
    public int ReqQryMaxOrderVolume(ref CThostFtdcQryMaxOrderVolumeField pQryMaxOrderVolume,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMaxOrderVolume(_handle, ref pQryMaxOrderVolume,nRequestID);
    }

    /// <summary>
    /// 投资者结算结果确认
    /// </summary>
    public int ReqSettlementInfoConfirm(ref CThostFtdcSettlementInfoConfirmField pSettlementInfoConfirm,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqSettlementInfoConfirm(_handle, ref pSettlementInfoConfirm,nRequestID);
    }

    /// <summary>
    /// 请求删除预埋单
    /// </summary>
    public int ReqRemoveParkedOrder(ref CThostFtdcRemoveParkedOrderField pRemoveParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqRemoveParkedOrder(_handle, ref pRemoveParkedOrder,nRequestID);
    }

    /// <summary>
    /// 请求删除预埋撤单
    /// </summary>
    public int ReqRemoveParkedOrderAction(ref CThostFtdcRemoveParkedOrderActionField pRemoveParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqRemoveParkedOrderAction(_handle, ref pRemoveParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// 执行宣告录入请求
    /// </summary>
    public int ReqExecOrderInsert(ref CThostFtdcInputExecOrderField pInputExecOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqExecOrderInsert(_handle, ref pInputExecOrder,nRequestID);
    }

    /// <summary>
    /// 执行宣告操作请求
    /// </summary>
    public int ReqExecOrderAction(ref CThostFtdcInputExecOrderActionField pInputExecOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqExecOrderAction(_handle, ref pInputExecOrderAction,nRequestID);
    }

    /// <summary>
    /// 询价录入请求
    /// </summary>
    public int ReqForQuoteInsert(ref CThostFtdcInputForQuoteField pInputForQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqForQuoteInsert(_handle, ref pInputForQuote,nRequestID);
    }

    /// <summary>
    /// 报价录入请求
    /// </summary>
    public int ReqQuoteInsert(ref CThostFtdcInputQuoteField pInputQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQuoteInsert(_handle, ref pInputQuote,nRequestID);
    }

    /// <summary>
    /// 报价操作请求
    /// </summary>
    public int ReqQuoteAction(ref CThostFtdcInputQuoteActionField pInputQuoteAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQuoteAction(_handle, ref pInputQuoteAction,nRequestID);
    }

    /// <summary>
    /// 批量报单操作请求
    /// </summary>
    public int ReqBatchOrderAction(ref CThostFtdcInputBatchOrderActionField pInputBatchOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqBatchOrderAction(_handle, ref pInputBatchOrderAction,nRequestID);
    }

    /// <summary>
    /// 期权自对冲录入请求
    /// </summary>
    public int ReqOptionSelfCloseInsert(ref CThostFtdcInputOptionSelfCloseField pInputOptionSelfClose,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOptionSelfCloseInsert(_handle, ref pInputOptionSelfClose,nRequestID);
    }

    /// <summary>
    /// 期权自对冲操作请求
    /// </summary>
    public int ReqOptionSelfCloseAction(ref CThostFtdcInputOptionSelfCloseActionField pInputOptionSelfCloseAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOptionSelfCloseAction(_handle, ref pInputOptionSelfCloseAction,nRequestID);
    }

    /// <summary>
    /// 申请组合录入请求
    /// </summary>
    public int ReqCombActionInsert(ref CThostFtdcInputCombActionField pInputCombAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqCombActionInsert(_handle, ref pInputCombAction,nRequestID);
    }

    /// <summary>
    /// 请求查询报单
    /// </summary>
    public int ReqQryOrder(ref CThostFtdcQryOrderField pQryOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOrder(_handle, ref pQryOrder,nRequestID);
    }

    /// <summary>
    /// 请求查询成交
    /// </summary>
    public int ReqQryTrade(ref CThostFtdcQryTradeField pQryTrade,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTrade(_handle, ref pQryTrade,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者持仓
    /// </summary>
    public int ReqQryInvestorPosition(ref CThostFtdcQryInvestorPositionField pQryInvestorPosition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPosition(_handle, ref pQryInvestorPosition,nRequestID);
    }

    /// <summary>
    /// 请求查询资金账户
    /// </summary>
    public int ReqQryTradingAccount(ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingAccount(_handle, ref pQryTradingAccount,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者
    /// </summary>
    public int ReqQryInvestor(ref CThostFtdcQryInvestorField pQryInvestor,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestor(_handle, ref pQryInvestor,nRequestID);
    }

    /// <summary>
    /// 请求查询交易编码
    /// </summary>
    public int ReqQryTradingCode(ref CThostFtdcQryTradingCodeField pQryTradingCode,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingCode(_handle, ref pQryTradingCode,nRequestID);
    }

    /// <summary>
    /// 请求查询合约保证金率
    /// </summary>
    public int ReqQryInstrumentMarginRate(ref CThostFtdcQryInstrumentMarginRateField pQryInstrumentMarginRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentMarginRate(_handle, ref pQryInstrumentMarginRate,nRequestID);
    }

    /// <summary>
    /// 请求查询合约手续费率
    /// </summary>
    public int ReqQryInstrumentCommissionRate(ref CThostFtdcQryInstrumentCommissionRateField pQryInstrumentCommissionRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentCommissionRate(_handle, ref pQryInstrumentCommissionRate,nRequestID);
    }

    /// <summary>
    /// 请求查询交易所
    /// </summary>
    public int ReqQryExchange(ref CThostFtdcQryExchangeField pQryExchange,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchange(_handle, ref pQryExchange,nRequestID);
    }

    /// <summary>
    /// 请求查询产品
    /// </summary>
    public int ReqQryProduct(ref CThostFtdcQryProductField pQryProduct,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProduct(_handle, ref pQryProduct,nRequestID);
    }

    /// <summary>
    /// 请求查询合约
    /// </summary>
    public int ReqQryInstrument(ref CThostFtdcQryInstrumentField pQryInstrument,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrument(_handle, ref pQryInstrument,nRequestID);
    }

    /// <summary>
    /// 请求查询行情
    /// </summary>
    public int ReqQryDepthMarketData(ref CThostFtdcQryDepthMarketDataField pQryDepthMarketData,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryDepthMarketData(_handle, ref pQryDepthMarketData,nRequestID);
    }

    /// <summary>
    /// 请求查询交易员报盘机
    /// </summary>
    public int ReqQryTraderOffer(ref CThostFtdcQryTraderOfferField pQryTraderOffer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTraderOffer(_handle, ref pQryTraderOffer,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者结算结果
    /// </summary>
    public int ReqQrySettlementInfo(ref CThostFtdcQrySettlementInfoField pQrySettlementInfo,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySettlementInfo(_handle, ref pQrySettlementInfo,nRequestID);
    }

    /// <summary>
    /// 请求查询转帐银行
    /// </summary>
    public int ReqQryTransferBank(ref CThostFtdcQryTransferBankField pQryTransferBank,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTransferBank(_handle, ref pQryTransferBank,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者持仓明细
    /// </summary>
    public int ReqQryInvestorPositionDetail(ref CThostFtdcQryInvestorPositionDetailField pQryInvestorPositionDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPositionDetail(_handle, ref pQryInvestorPositionDetail,nRequestID);
    }

    /// <summary>
    /// 请求查询客户通知
    /// </summary>
    public int ReqQryNotice(ref CThostFtdcQryNoticeField pQryNotice,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryNotice(_handle, ref pQryNotice,nRequestID);
    }

    /// <summary>
    /// 请求查询结算信息确认
    /// </summary>
    public int ReqQrySettlementInfoConfirm(ref CThostFtdcQrySettlementInfoConfirmField pQrySettlementInfoConfirm,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySettlementInfoConfirm(_handle, ref pQrySettlementInfoConfirm,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者持仓明细
    /// </summary>
    public int ReqQryInvestorPositionCombineDetail(ref CThostFtdcQryInvestorPositionCombineDetailField pQryInvestorPositionCombineDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail(_handle, ref pQryInvestorPositionCombineDetail,nRequestID);
    }

    /// <summary>
    /// 请求查询保证金监管系统经纪公司资金账户密钥
    /// </summary>
    public int ReqQryCFMMCTradingAccountKey(ref CThostFtdcQryCFMMCTradingAccountKeyField pQryCFMMCTradingAccountKey,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey(_handle, ref pQryCFMMCTradingAccountKey,nRequestID);
    }

    /// <summary>
    /// 请求查询仓单折抵信息
    /// </summary>
    public int ReqQryEWarrantOffset(ref CThostFtdcQryEWarrantOffsetField pQryEWarrantOffset,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryEWarrantOffset(_handle, ref pQryEWarrantOffset,nRequestID);
    }

    /// <summary>
    /// 请求查询投资者品种/跨品种保证金
    /// </summary>
    public int ReqQryInvestorProductGroupMargin(ref CThostFtdcQryInvestorProductGroupMarginField pQryInvestorProductGroupMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin(_handle, ref pQryInvestorProductGroupMargin,nRequestID);
    }

    /// <summary>
    /// 请求查询交易所保证金率
    /// </summary>
    public int ReqQryExchangeMarginRate(ref CThostFtdcQryExchangeMarginRateField pQryExchangeMarginRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeMarginRate(_handle, ref pQryExchangeMarginRate,nRequestID);
    }

    /// <summary>
    /// 请求查询交易所调整保证金率
    /// </summary>
    public int ReqQryExchangeMarginRateAdjust(ref CThostFtdcQryExchangeMarginRateAdjustField pQryExchangeMarginRateAdjust,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust(_handle, ref pQryExchangeMarginRateAdjust,nRequestID);
    }

    /// <summary>
    /// 请求查询汇率
    /// </summary>
    public int ReqQryExchangeRate(ref CThostFtdcQryExchangeRateField pQryExchangeRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExchangeRate(_handle, ref pQryExchangeRate,nRequestID);
    }

    /// <summary>
    /// 请求查询二级代理操作员银期权限
    /// </summary>
    public int ReqQrySecAgentACIDMap(ref CThostFtdcQrySecAgentACIDMapField pQrySecAgentACIDMap,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentACIDMap(_handle, ref pQrySecAgentACIDMap,nRequestID);
    }

    /// <summary>
    /// 请求查询产品报价汇率
    /// </summary>
    public int ReqQryProductExchRate(ref CThostFtdcQryProductExchRateField pQryProductExchRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProductExchRate(_handle, ref pQryProductExchRate,nRequestID);
    }

    /// <summary>
    /// 请求查询产品组
    /// </summary>
    public int ReqQryProductGroup(ref CThostFtdcQryProductGroupField pQryProductGroup,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryProductGroup(_handle, ref pQryProductGroup,nRequestID);
    }

    /// <summary>
    /// 请求查询做市商合约手续费率
    /// </summary>
    public int ReqQryMMInstrumentCommissionRate(ref CThostFtdcQryMMInstrumentCommissionRateField pQryMMInstrumentCommissionRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate(_handle, ref pQryMMInstrumentCommissionRate,nRequestID);
    }

    /// <summary>
    /// 请求查询做市商期权合约手续费
    /// </summary>
    public int ReqQryMMOptionInstrCommRate(ref CThostFtdcQryMMOptionInstrCommRateField pQryMMOptionInstrCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate(_handle, ref pQryMMOptionInstrCommRate,nRequestID);
    }

    /// <summary>
    /// 请求查询报单手续费
    /// </summary>
    public int ReqQryInstrumentOrderCommRate(ref CThostFtdcQryInstrumentOrderCommRateField pQryInstrumentOrderCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate(_handle, ref pQryInstrumentOrderCommRate,nRequestID);
    }

    /// <summary>
    /// 请求查询资金账户
    /// </summary>
    public int ReqQrySecAgentTradingAccount(ref CThostFtdcQryTradingAccountField pQryTradingAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentTradingAccount(_handle, ref pQryTradingAccount,nRequestID);
    }

    /// <summary>
    /// 请求查询二级代理商资金校验模式
    /// </summary>
    public int ReqQrySecAgentCheckMode(ref CThostFtdcQrySecAgentCheckModeField pQrySecAgentCheckMode,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentCheckMode(_handle, ref pQrySecAgentCheckMode,nRequestID);
    }

    /// <summary>
    /// 请求查询二级代理商信息
    /// </summary>
    public int ReqQrySecAgentTradeInfo(ref CThostFtdcQrySecAgentTradeInfoField pQrySecAgentTradeInfo,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySecAgentTradeInfo(_handle, ref pQrySecAgentTradeInfo,nRequestID);
    }

    /// <summary>
    /// 请求查询期权交易成本
    /// </summary>
    public int ReqQryOptionInstrTradeCost(ref CThostFtdcQryOptionInstrTradeCostField pQryOptionInstrTradeCost,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionInstrTradeCost(_handle, ref pQryOptionInstrTradeCost,nRequestID);
    }

    /// <summary>
    /// 请求查询期权合约手续费
    /// </summary>
    public int ReqQryOptionInstrCommRate(ref CThostFtdcQryOptionInstrCommRateField pQryOptionInstrCommRate,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionInstrCommRate(_handle, ref pQryOptionInstrCommRate,nRequestID);
    }

    /// <summary>
    /// 请求查询执行宣告
    /// </summary>
    public int ReqQryExecOrder(ref CThostFtdcQryExecOrderField pQryExecOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryExecOrder(_handle, ref pQryExecOrder,nRequestID);
    }

    /// <summary>
    /// 请求查询询价
    /// </summary>
    public int ReqQryForQuote(ref CThostFtdcQryForQuoteField pQryForQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryForQuote(_handle, ref pQryForQuote,nRequestID);
    }

    /// <summary>
    /// 请求查询报价
    /// </summary>
    public int ReqQryQuote(ref CThostFtdcQryQuoteField pQryQuote,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryQuote(_handle, ref pQryQuote,nRequestID);
    }

    /// <summary>
    /// 请求查询期权自对冲
    /// </summary>
    public int ReqQryOptionSelfClose(ref CThostFtdcQryOptionSelfCloseField pQryOptionSelfClose,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOptionSelfClose(_handle, ref pQryOptionSelfClose,nRequestID);
    }

    /// <summary>
    /// 请求查询投资单元
    /// </summary>
    public int ReqQryInvestUnit(ref CThostFtdcQryInvestUnitField pQryInvestUnit,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestUnit(_handle, ref pQryInvestUnit,nRequestID);
    }

    /// <summary>
    /// 请求查询组合合约安全系数
    /// </summary>
    public int ReqQryCombInstrumentGuard(ref CThostFtdcQryCombInstrumentGuardField pQryCombInstrumentGuard,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombInstrumentGuard(_handle, ref pQryCombInstrumentGuard,nRequestID);
    }

    /// <summary>
    /// 请求查询申请组合
    /// </summary>
    public int ReqQryCombAction(ref CThostFtdcQryCombActionField pQryCombAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombAction(_handle, ref pQryCombAction,nRequestID);
    }

    /// <summary>
    /// 请求查询转帐流水
    /// </summary>
    public int ReqQryTransferSerial(ref CThostFtdcQryTransferSerialField pQryTransferSerial,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTransferSerial(_handle, ref pQryTransferSerial,nRequestID);
    }

    /// <summary>
    /// 请求查询银期签约关系
    /// </summary>
    public int ReqQryAccountregister(ref CThostFtdcQryAccountregisterField pQryAccountregister,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryAccountregister(_handle, ref pQryAccountregister,nRequestID);
    }

    /// <summary>
    /// 请求查询签约银行
    /// </summary>
    public int ReqQryContractBank(ref CThostFtdcQryContractBankField pQryContractBank,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryContractBank(_handle, ref pQryContractBank,nRequestID);
    }

    /// <summary>
    /// 请求查询预埋单
    /// </summary>
    public int ReqQryParkedOrder(ref CThostFtdcQryParkedOrderField pQryParkedOrder,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryParkedOrder(_handle, ref pQryParkedOrder,nRequestID);
    }

    /// <summary>
    /// 请求查询预埋撤单
    /// </summary>
    public int ReqQryParkedOrderAction(ref CThostFtdcQryParkedOrderActionField pQryParkedOrderAction,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryParkedOrderAction(_handle, ref pQryParkedOrderAction,nRequestID);
    }

    /// <summary>
    /// 请求查询交易通知
    /// </summary>
    public int ReqQryTradingNotice(ref CThostFtdcQryTradingNoticeField pQryTradingNotice,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryTradingNotice(_handle, ref pQryTradingNotice,nRequestID);
    }

    /// <summary>
    /// 请求查询经纪公司交易参数
    /// </summary>
    public int ReqQryBrokerTradingParams(ref CThostFtdcQryBrokerTradingParamsField pQryBrokerTradingParams,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryBrokerTradingParams(_handle, ref pQryBrokerTradingParams,nRequestID);
    }

    /// <summary>
    /// 请求查询经纪公司交易算法
    /// </summary>
    public int ReqQryBrokerTradingAlgos(ref CThostFtdcQryBrokerTradingAlgosField pQryBrokerTradingAlgos,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryBrokerTradingAlgos(_handle, ref pQryBrokerTradingAlgos,nRequestID);
    }

    /// <summary>
    /// 请求查询监控中心用户令牌
    /// </summary>
    public int ReqQueryCFMMCTradingAccountToken(ref CThostFtdcQueryCFMMCTradingAccountTokenField pQueryCFMMCTradingAccountToken,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken(_handle, ref pQueryCFMMCTradingAccountToken,nRequestID);
    }

    /// <summary>
    /// 期货发起银行资金转期货请求
    /// </summary>
    public int ReqFromBankToFutureByFuture(ref CThostFtdcReqTransferField pReqTransfer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqFromBankToFutureByFuture(_handle, ref pReqTransfer,nRequestID);
    }

    /// <summary>
    /// 期货发起期货资金转银行请求
    /// </summary>
    public int ReqFromFutureToBankByFuture(ref CThostFtdcReqTransferField pReqTransfer,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqFromFutureToBankByFuture(_handle, ref pReqTransfer,nRequestID);
    }

    /// <summary>
    /// 期货发起查询银行余额请求
    /// </summary>
    public int ReqQueryBankAccountMoneyByFuture(ref CThostFtdcReqQueryAccountField pReqQueryAccount,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture(_handle, ref pReqQueryAccount,nRequestID);
    }

    /// <summary>
    /// 请求查询分类合约
    /// </summary>
    public int ReqQryClassifiedInstrument(ref CThostFtdcQryClassifiedInstrumentField pQryClassifiedInstrument,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryClassifiedInstrument(_handle, ref pQryClassifiedInstrument,nRequestID);
    }

    /// <summary>
    /// 请求组合优惠比例
    /// </summary>
    public int ReqQryCombPromotionParam(ref CThostFtdcQryCombPromotionParamField pQryCombPromotionParam,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombPromotionParam(_handle, ref pQryCombPromotionParam,nRequestID);
    }

    /// <summary>
    /// 投资者风险结算持仓查询
    /// </summary>
    public int ReqQryRiskSettleInvstPosition(ref CThostFtdcQryRiskSettleInvstPositionField pQryRiskSettleInvstPosition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition(_handle, ref pQryRiskSettleInvstPosition,nRequestID);
    }

    /// <summary>
    /// 风险结算产品查询
    /// </summary>
    public int ReqQryRiskSettleProductStatus(ref CThostFtdcQryRiskSettleProductStatusField pQryRiskSettleProductStatus,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRiskSettleProductStatus(_handle, ref pQryRiskSettleProductStatus,nRequestID);
    }

    /// <summary>
    /// SPBM期货合约参数查询
    /// </summary>
    public int ReqQrySPBMFutureParameter(ref CThostFtdcQrySPBMFutureParameterField pQrySPBMFutureParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMFutureParameter(_handle, ref pQrySPBMFutureParameter,nRequestID);
    }

    /// <summary>
    /// SPBM期权合约参数查询
    /// </summary>
    public int ReqQrySPBMOptionParameter(ref CThostFtdcQrySPBMOptionParameterField pQrySPBMOptionParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMOptionParameter(_handle, ref pQrySPBMOptionParameter,nRequestID);
    }

    /// <summary>
    /// SPBM品种内对锁仓折扣参数查询
    /// </summary>
    public int ReqQrySPBMIntraParameter(ref CThostFtdcQrySPBMIntraParameterField pQrySPBMIntraParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMIntraParameter(_handle, ref pQrySPBMIntraParameter,nRequestID);
    }

    /// <summary>
    /// SPBM跨品种抵扣参数查询
    /// </summary>
    public int ReqQrySPBMInterParameter(ref CThostFtdcQrySPBMInterParameterField pQrySPBMInterParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMInterParameter(_handle, ref pQrySPBMInterParameter,nRequestID);
    }

    /// <summary>
    /// SPBM组合保证金套餐查询
    /// </summary>
    public int ReqQrySPBMPortfDefinition(ref CThostFtdcQrySPBMPortfDefinitionField pQrySPBMPortfDefinition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMPortfDefinition(_handle, ref pQrySPBMPortfDefinition,nRequestID);
    }

    /// <summary>
    /// 投资者SPBM套餐选择查询
    /// </summary>
    public int ReqQrySPBMInvestorPortfDef(ref CThostFtdcQrySPBMInvestorPortfDefField pQrySPBMInvestorPortfDef,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef(_handle, ref pQrySPBMInvestorPortfDef,nRequestID);
    }

    /// <summary>
    /// 投资者新型组合保证金系数查询
    /// </summary>
    public int ReqQryInvestorPortfMarginRatio(ref CThostFtdcQryInvestorPortfMarginRatioField pQryInvestorPortfMarginRatio,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio(_handle, ref pQryInvestorPortfMarginRatio,nRequestID);
    }

    /// <summary>
    /// 投资者产品SPBM明细查询
    /// </summary>
    public int ReqQryInvestorProdSPBMDetail(ref CThostFtdcQryInvestorProdSPBMDetailField pQryInvestorProdSPBMDetail,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail(_handle, ref pQryInvestorProdSPBMDetail,nRequestID);
    }

    /// <summary>
    /// 投资者商品组SPMM记录查询
    /// </summary>
    public int ReqQryInvestorCommoditySPMMMargin(ref CThostFtdcQryInvestorCommoditySPMMMarginField pQryInvestorCommoditySPMMMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorCommoditySPMMMargin(_handle, ref pQryInvestorCommoditySPMMMargin,nRequestID);
    }

    /// <summary>
    /// 投资者商品群SPMM记录查询
    /// </summary>
    public int ReqQryInvestorCommodityGroupSPMMMargin(ref CThostFtdcQryInvestorCommodityGroupSPMMMarginField pQryInvestorCommodityGroupSPMMMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorCommodityGroupSPMMMargin(_handle, ref pQryInvestorCommodityGroupSPMMMargin,nRequestID);
    }

    /// <summary>
    /// SPMM合约参数查询
    /// </summary>
    public int ReqQrySPMMInstParam(ref CThostFtdcQrySPMMInstParamField pQrySPMMInstParam,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPMMInstParam(_handle, ref pQrySPMMInstParam,nRequestID);
    }

    /// <summary>
    /// SPMM产品参数查询
    /// </summary>
    public int ReqQrySPMMProductParam(ref CThostFtdcQrySPMMProductParamField pQrySPMMProductParam,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPMMProductParam(_handle, ref pQrySPMMProductParam,nRequestID);
    }

    /// <summary>
    /// SPBM附加跨品种抵扣参数查询
    /// </summary>
    public int ReqQrySPBMAddOnInterParameter(ref CThostFtdcQrySPBMAddOnInterParameterField pQrySPBMAddOnInterParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQrySPBMAddOnInterParameter(_handle, ref pQrySPBMAddOnInterParameter,nRequestID);
    }

    /// <summary>
    /// RCAMS产品组合信息查询
    /// </summary>
    public int ReqQryRCAMSCombProductInfo(ref CThostFtdcQryRCAMSCombProductInfoField pQryRCAMSCombProductInfo,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSCombProductInfo(_handle, ref pQryRCAMSCombProductInfo,nRequestID);
    }

    /// <summary>
    /// RCAMS同合约风险对冲参数查询
    /// </summary>
    public int ReqQryRCAMSInstrParameter(ref CThostFtdcQryRCAMSInstrParameterField pQryRCAMSInstrParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSInstrParameter(_handle, ref pQryRCAMSInstrParameter,nRequestID);
    }

    /// <summary>
    /// RCAMS品种内风险对冲参数查询
    /// </summary>
    public int ReqQryRCAMSIntraParameter(ref CThostFtdcQryRCAMSIntraParameterField pQryRCAMSIntraParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSIntraParameter(_handle, ref pQryRCAMSIntraParameter,nRequestID);
    }

    /// <summary>
    /// RCAMS跨品种风险折抵参数查询
    /// </summary>
    public int ReqQryRCAMSInterParameter(ref CThostFtdcQryRCAMSInterParameterField pQryRCAMSInterParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSInterParameter(_handle, ref pQryRCAMSInterParameter,nRequestID);
    }

    /// <summary>
    /// RCAMS空头期权风险调整参数查询
    /// </summary>
    public int ReqQryRCAMSShortOptAdjustParam(ref CThostFtdcQryRCAMSShortOptAdjustParamField pQryRCAMSShortOptAdjustParam,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSShortOptAdjustParam(_handle, ref pQryRCAMSShortOptAdjustParam,nRequestID);
    }

    /// <summary>
    /// RCAMS策略组合持仓查询
    /// </summary>
    public int ReqQryRCAMSInvestorCombPosition(ref CThostFtdcQryRCAMSInvestorCombPositionField pQryRCAMSInvestorCombPosition,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRCAMSInvestorCombPosition(_handle, ref pQryRCAMSInvestorCombPosition,nRequestID);
    }

    /// <summary>
    /// 投资者品种RCAMS保证金查询
    /// </summary>
    public int ReqQryInvestorProdRCAMSMargin(ref CThostFtdcQryInvestorProdRCAMSMarginField pQryInvestorProdRCAMSMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProdRCAMSMargin(_handle, ref pQryInvestorProdRCAMSMargin,nRequestID);
    }

    /// <summary>
    /// RULE合约保证金参数查询
    /// </summary>
    public int ReqQryRULEInstrParameter(ref CThostFtdcQryRULEInstrParameterField pQryRULEInstrParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRULEInstrParameter(_handle, ref pQryRULEInstrParameter,nRequestID);
    }

    /// <summary>
    /// RULE品种内对锁仓折扣参数查询
    /// </summary>
    public int ReqQryRULEIntraParameter(ref CThostFtdcQryRULEIntraParameterField pQryRULEIntraParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRULEIntraParameter(_handle, ref pQryRULEIntraParameter,nRequestID);
    }

    /// <summary>
    /// RULE跨品种抵扣参数查询
    /// </summary>
    public int ReqQryRULEInterParameter(ref CThostFtdcQryRULEInterParameterField pQryRULEInterParameter,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryRULEInterParameter(_handle, ref pQryRULEInterParameter,nRequestID);
    }

    /// <summary>
    /// 投资者产品RULE保证金查询
    /// </summary>
    public int ReqQryInvestorProdRULEMargin(ref CThostFtdcQryInvestorProdRULEMarginField pQryInvestorProdRULEMargin,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorProdRULEMargin(_handle, ref pQryInvestorProdRULEMargin,nRequestID);
    }

    /// <summary>
    /// 投资者新型组合保证金开关查询
    /// </summary>
    public int ReqQryInvestorPortfSetting(ref CThostFtdcQryInvestorPortfSettingField pQryInvestorPortfSetting,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorPortfSetting(_handle, ref pQryInvestorPortfSetting,nRequestID);
    }

    /// <summary>
    /// 投资者申报费阶梯收取记录查询
    /// </summary>
    public int ReqQryInvestorInfoCommRec(ref CThostFtdcQryInvestorInfoCommRecField pQryInvestorInfoCommRec,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryInvestorInfoCommRec(_handle, ref pQryInvestorInfoCommRec,nRequestID);
    }

    /// <summary>
    /// 组合腿信息查询
    /// </summary>
    public int ReqQryCombLeg(ref CThostFtdcQryCombLegField pQryCombLeg,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryCombLeg(_handle, ref pQryCombLeg,nRequestID);
    }

    /// <summary>
    /// 对冲设置请求
    /// </summary>
    public int ReqOffsetSetting(ref CThostFtdcInputOffsetSettingField pInputOffsetSetting,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqOffsetSetting(_handle, ref pInputOffsetSetting,nRequestID);
    }

    /// <summary>
    /// 对冲设置撤销请求
    /// </summary>
    public int ReqCancelOffsetSetting(ref CThostFtdcInputOffsetSettingField pInputOffsetSetting,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqCancelOffsetSetting(_handle, ref pInputOffsetSetting,nRequestID);
    }

    /// <summary>
    /// 投资者对冲设置查询
    /// </summary>
    public int ReqQryOffsetSetting(ref CThostFtdcQryOffsetSettingField pQryOffsetSetting,int nRequestID)
    {
        return CTPSharpPInvoke.CThostFtdcTraderApi_ReqQryOffsetSetting(_handle, ref pQryOffsetSetting,nRequestID);
    }

    public void Dispose()
    {
        if (_handle == 0) return;
        CTPSharpPInvoke.CThostFtdcTraderApi_Release(_handle);
        //CTPSharpPInvoke.CThostFtdcTraderApi_Join(_handle);
        _handle = 0;
    }
}
