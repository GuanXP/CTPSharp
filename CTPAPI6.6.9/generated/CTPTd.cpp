//由 generator生成的文件，不要手工修改

#include "ThostFtdcTraderApi.h"

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

struct CTPSharp_CThostFtdcTraderSpi
{
    void (CTPSHARP_STDCALL *OnFrontConnected)();
    void (CTPSHARP_STDCALL *OnFrontDisconnected)(int nReason);
    void (CTPSHARP_STDCALL *OnHeartBeatWarning)(int nTimeLapse);
    void (CTPSHARP_STDCALL *OnRspAuthenticate)(CThostFtdcRspAuthenticateField* pRspAuthenticateField,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogin)(CThostFtdcRspUserLoginField* pRspUserLogin,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogout)(CThostFtdcUserLogoutField* pUserLogout,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserPasswordUpdate)(CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspTradingAccountPasswordUpdate)(CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserAuthMethod)(CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspGenUserCaptcha)(CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspGenUserText)(CThostFtdcRspGenUserTextField* pRspGenUserText,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOrderInsert)(CThostFtdcInputOrderField* pInputOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspParkedOrderInsert)(CThostFtdcParkedOrderField* pParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspParkedOrderAction)(CThostFtdcParkedOrderActionField* pParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOrderAction)(CThostFtdcInputOrderActionField* pInputOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMaxOrderVolume)(CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspRemoveParkedOrder)(CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspRemoveParkedOrderAction)(CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspExecOrderInsert)(CThostFtdcInputExecOrderField* pInputExecOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspExecOrderAction)(CThostFtdcInputExecOrderActionField* pInputExecOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspForQuoteInsert)(CThostFtdcInputForQuoteField* pInputForQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQuoteInsert)(CThostFtdcInputQuoteField* pInputQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQuoteAction)(CThostFtdcInputQuoteActionField* pInputQuoteAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspBatchOrderAction)(CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOptionSelfCloseInsert)(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOptionSelfCloseAction)(CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspCombActionInsert)(CThostFtdcInputCombActionField* pInputCombAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOrder)(CThostFtdcOrderField* pOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTrade)(CThostFtdcTradeField* pTrade,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPosition)(CThostFtdcInvestorPositionField* pInvestorPosition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingAccount)(CThostFtdcTradingAccountField* pTradingAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestor)(CThostFtdcInvestorField* pInvestor,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingCode)(CThostFtdcTradingCodeField* pTradingCode,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentMarginRate)(CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentCommissionRate)(CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchange)(CThostFtdcExchangeField* pExchange,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProduct)(CThostFtdcProductField* pProduct,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrument)(CThostFtdcInstrumentField* pInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryDepthMarketData)(CThostFtdcDepthMarketDataField* pDepthMarketData,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTraderOffer)(CThostFtdcTraderOfferField* pTraderOffer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySettlementInfo)(CThostFtdcSettlementInfoField* pSettlementInfo,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTransferBank)(CThostFtdcTransferBankField* pTransferBank,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPositionDetail)(CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryNotice)(CThostFtdcNoticeField* pNotice,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySettlementInfoConfirm)(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPositionCombineDetail)(CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCFMMCTradingAccountKey)(CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryEWarrantOffset)(CThostFtdcEWarrantOffsetField* pEWarrantOffset,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProductGroupMargin)(CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeMarginRate)(CThostFtdcExchangeMarginRateField* pExchangeMarginRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeMarginRateAdjust)(CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeRate)(CThostFtdcExchangeRateField* pExchangeRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentACIDMap)(CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProductExchRate)(CThostFtdcProductExchRateField* pProductExchRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProductGroup)(CThostFtdcProductGroupField* pProductGroup,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMMInstrumentCommissionRate)(CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMMOptionInstrCommRate)(CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentOrderCommRate)(CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentTradingAccount)(CThostFtdcTradingAccountField* pTradingAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentCheckMode)(CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentTradeInfo)(CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionInstrTradeCost)(CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionInstrCommRate)(CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExecOrder)(CThostFtdcExecOrderField* pExecOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryForQuote)(CThostFtdcForQuoteField* pForQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryQuote)(CThostFtdcQuoteField* pQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionSelfClose)(CThostFtdcOptionSelfCloseField* pOptionSelfClose,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestUnit)(CThostFtdcInvestUnitField* pInvestUnit,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombInstrumentGuard)(CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombAction)(CThostFtdcCombActionField* pCombAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTransferSerial)(CThostFtdcTransferSerialField* pTransferSerial,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryAccountregister)(CThostFtdcAccountregisterField* pAccountregister,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspError)(CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnOrder)(CThostFtdcOrderField* pOrder);
    void (CTPSHARP_STDCALL *OnRtnTrade)(CThostFtdcTradeField* pTrade);
    void (CTPSHARP_STDCALL *OnErrRtnOrderInsert)(CThostFtdcInputOrderField* pInputOrder,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnOrderAction)(CThostFtdcOrderActionField* pOrderAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnInstrumentStatus)(CThostFtdcInstrumentStatusField* pInstrumentStatus);
    void (CTPSHARP_STDCALL *OnRtnBulletin)(CThostFtdcBulletinField* pBulletin);
    void (CTPSHARP_STDCALL *OnRtnTradingNotice)(CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo);
    void (CTPSHARP_STDCALL *OnRtnErrorConditionalOrder)(CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder);
    void (CTPSHARP_STDCALL *OnRtnExecOrder)(CThostFtdcExecOrderField* pExecOrder);
    void (CTPSHARP_STDCALL *OnErrRtnExecOrderInsert)(CThostFtdcInputExecOrderField* pInputExecOrder,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnExecOrderAction)(CThostFtdcExecOrderActionField* pExecOrderAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnForQuoteInsert)(CThostFtdcInputForQuoteField* pInputForQuote,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnQuote)(CThostFtdcQuoteField* pQuote);
    void (CTPSHARP_STDCALL *OnErrRtnQuoteInsert)(CThostFtdcInputQuoteField* pInputQuote,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnQuoteAction)(CThostFtdcQuoteActionField* pQuoteAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnForQuoteRsp)(CThostFtdcForQuoteRspField* pForQuoteRsp);
    void (CTPSHARP_STDCALL *OnRtnCFMMCTradingAccountToken)(CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken);
    void (CTPSHARP_STDCALL *OnErrRtnBatchOrderAction)(CThostFtdcBatchOrderActionField* pBatchOrderAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnOptionSelfClose)(CThostFtdcOptionSelfCloseField* pOptionSelfClose);
    void (CTPSHARP_STDCALL *OnErrRtnOptionSelfCloseInsert)(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnOptionSelfCloseAction)(CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnCombAction)(CThostFtdcCombActionField* pCombAction);
    void (CTPSHARP_STDCALL *OnErrRtnCombActionInsert)(CThostFtdcInputCombActionField* pInputCombAction,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRspQryContractBank)(CThostFtdcContractBankField* pContractBank,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryParkedOrder)(CThostFtdcParkedOrderField* pParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryParkedOrderAction)(CThostFtdcParkedOrderActionField* pParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingNotice)(CThostFtdcTradingNoticeField* pTradingNotice,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryBrokerTradingParams)(CThostFtdcBrokerTradingParamsField* pBrokerTradingParams,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryBrokerTradingAlgos)(CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQueryCFMMCTradingAccountToken)(CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnFromBankToFutureByBank)(CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnFromFutureToBankByBank)(CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByBank)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByBank)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnFromBankToFutureByFuture)(CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnFromFutureToBankByFuture)(CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByFutureManual)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByFutureManual)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnQueryBankBalanceByFuture)(CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount);
    void (CTPSHARP_STDCALL *OnErrRtnBankToFutureByFuture)(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnFutureToBankByFuture)(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnRepealBankToFutureByFutureManual)(CThostFtdcReqRepealField* pReqRepeal,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnRepealFutureToBankByFutureManual)(CThostFtdcReqRepealField* pReqRepeal,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnQueryBankBalanceByFuture)(CThostFtdcReqQueryAccountField* pReqQueryAccount,CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByFuture)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByFuture)(CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRspFromBankToFutureByFuture)(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspFromFutureToBankByFuture)(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQueryBankAccountMoneyByFuture)(CThostFtdcReqQueryAccountField* pReqQueryAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnOpenAccountByBank)(CThostFtdcOpenAccountField* pOpenAccount);
    void (CTPSHARP_STDCALL *OnRtnCancelAccountByBank)(CThostFtdcCancelAccountField* pCancelAccount);
    void (CTPSHARP_STDCALL *OnRtnChangeAccountByBank)(CThostFtdcChangeAccountField* pChangeAccount);
    void (CTPSHARP_STDCALL *OnRspQryClassifiedInstrument)(CThostFtdcInstrumentField* pInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombPromotionParam)(CThostFtdcCombPromotionParamField* pCombPromotionParam,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRiskSettleInvstPosition)(CThostFtdcRiskSettleInvstPositionField* pRiskSettleInvstPosition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRiskSettleProductStatus)(CThostFtdcRiskSettleProductStatusField* pRiskSettleProductStatus,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMFutureParameter)(CThostFtdcSPBMFutureParameterField* pSPBMFutureParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMOptionParameter)(CThostFtdcSPBMOptionParameterField* pSPBMOptionParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMIntraParameter)(CThostFtdcSPBMIntraParameterField* pSPBMIntraParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMInterParameter)(CThostFtdcSPBMInterParameterField* pSPBMInterParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMPortfDefinition)(CThostFtdcSPBMPortfDefinitionField* pSPBMPortfDefinition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMInvestorPortfDef)(CThostFtdcSPBMInvestorPortfDefField* pSPBMInvestorPortfDef,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPortfMarginRatio)(CThostFtdcInvestorPortfMarginRatioField* pInvestorPortfMarginRatio,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProdSPBMDetail)(CThostFtdcInvestorProdSPBMDetailField* pInvestorProdSPBMDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
};
class CThostFtdcTraderSpi_Ex: public CThostFtdcTraderSpi
{
    CTPSharp_CThostFtdcTraderSpi _callbacks;
public:
    CThostFtdcTraderSpi_Ex(const CTPSharp_CThostFtdcTraderSpi* callbacks){ _callbacks = *callbacks; }
    virtual ~CThostFtdcTraderSpi_Ex() {}
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

    virtual void OnRspAuthenticate(CThostFtdcRspAuthenticateField* pRspAuthenticateField,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspAuthenticateField 回调 C# 参数 不能为 NULL
        CThostFtdcRspAuthenticateField zero0 = {0};
        if (!pRspAuthenticateField) pRspAuthenticateField = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspAuthenticate(pRspAuthenticateField,pRspInfo,nRequestID,bIsLast);
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

    virtual void OnRspUserPasswordUpdate(CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pUserPasswordUpdate 回调 C# 参数 不能为 NULL
        CThostFtdcUserPasswordUpdateField zero0 = {0};
        if (!pUserPasswordUpdate) pUserPasswordUpdate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserPasswordUpdate(pUserPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspTradingAccountPasswordUpdate(CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccountPasswordUpdate 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountPasswordUpdateField zero0 = {0};
        if (!pTradingAccountPasswordUpdate) pTradingAccountPasswordUpdate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUserAuthMethod(CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspUserAuthMethod 回调 C# 参数 不能为 NULL
        CThostFtdcRspUserAuthMethodField zero0 = {0};
        if (!pRspUserAuthMethod) pRspUserAuthMethod = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserAuthMethod(pRspUserAuthMethod,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspGenUserCaptcha(CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspGenUserCaptcha 回调 C# 参数 不能为 NULL
        CThostFtdcRspGenUserCaptchaField zero0 = {0};
        if (!pRspGenUserCaptcha) pRspGenUserCaptcha = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspGenUserCaptcha(pRspGenUserCaptcha,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspGenUserText(CThostFtdcRspGenUserTextField* pRspGenUserText,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspGenUserText 回调 C# 参数 不能为 NULL
        CThostFtdcRspGenUserTextField zero0 = {0};
        if (!pRspGenUserText) pRspGenUserText = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspGenUserText(pRspGenUserText,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOrderInsert(CThostFtdcInputOrderField* pInputOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderField zero0 = {0};
        if (!pInputOrder) pInputOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOrderInsert(pInputOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspParkedOrderInsert(CThostFtdcParkedOrderField* pParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderField zero0 = {0};
        if (!pParkedOrder) pParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspParkedOrderInsert(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderActionField zero0 = {0};
        if (!pParkedOrderAction) pParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspParkedOrderAction(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOrderAction(CThostFtdcInputOrderActionField* pInputOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderActionField zero0 = {0};
        if (!pInputOrderAction) pInputOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOrderAction(pInputOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMaxOrderVolume(CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQryMaxOrderVolume 回调 C# 参数 不能为 NULL
        CThostFtdcQryMaxOrderVolumeField zero0 = {0};
        if (!pQryMaxOrderVolume) pQryMaxOrderVolume = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMaxOrderVolume(pQryMaxOrderVolume,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfoConfirm 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoConfirmField zero0 = {0};
        if (!pSettlementInfoConfirm) pSettlementInfoConfirm = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSettlementInfoConfirm(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspRemoveParkedOrder(CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRemoveParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcRemoveParkedOrderField zero0 = {0};
        if (!pRemoveParkedOrder) pRemoveParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspRemoveParkedOrder(pRemoveParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspRemoveParkedOrderAction(CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRemoveParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcRemoveParkedOrderActionField zero0 = {0};
        if (!pRemoveParkedOrderAction) pRemoveParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspRemoveParkedOrderAction(pRemoveParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderField zero0 = {0};
        if (!pInputExecOrder) pInputExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspExecOrderInsert(pInputExecOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspExecOrderAction(CThostFtdcInputExecOrderActionField* pInputExecOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputExecOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderActionField zero0 = {0};
        if (!pInputExecOrderAction) pInputExecOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspExecOrderAction(pInputExecOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputForQuoteField zero0 = {0};
        if (!pInputForQuote) pInputForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspForQuoteInsert(pInputForQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQuoteInsert(CThostFtdcInputQuoteField* pInputQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteField zero0 = {0};
        if (!pInputQuote) pInputQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQuoteInsert(pInputQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQuoteAction(CThostFtdcInputQuoteActionField* pInputQuoteAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputQuoteAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteActionField zero0 = {0};
        if (!pInputQuoteAction) pInputQuoteAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQuoteAction(pInputQuoteAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspBatchOrderAction(CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputBatchOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputBatchOrderActionField zero0 = {0};
        if (!pInputBatchOrderAction) pInputBatchOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspBatchOrderAction(pInputBatchOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseField zero0 = {0};
        if (!pInputOptionSelfClose) pInputOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOptionSelfCloseInsert(pInputOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOptionSelfCloseAction(CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOptionSelfCloseAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseActionField zero0 = {0};
        if (!pInputOptionSelfCloseAction) pInputOptionSelfCloseAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOptionSelfCloseAction(pInputOptionSelfCloseAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputCombActionField zero0 = {0};
        if (!pInputCombAction) pInputCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspCombActionInsert(pInputCombAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOrder(CThostFtdcOrderField* pOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOrder 回调 C# 参数 不能为 NULL
        CThostFtdcOrderField zero0 = {0};
        if (!pOrder) pOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOrder(pOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTrade(CThostFtdcTradeField* pTrade,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTrade 回调 C# 参数 不能为 NULL
        CThostFtdcTradeField zero0 = {0};
        if (!pTrade) pTrade = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTrade(pTrade,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPosition(CThostFtdcInvestorPositionField* pInvestorPosition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPosition 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionField zero0 = {0};
        if (!pInvestorPosition) pInvestorPosition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPosition(pInvestorPosition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingAccount(CThostFtdcTradingAccountField* pTradingAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccount 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountField zero0 = {0};
        if (!pTradingAccount) pTradingAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingAccount(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestor(CThostFtdcInvestorField* pInvestor,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestor 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorField zero0 = {0};
        if (!pInvestor) pInvestor = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestor(pInvestor,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingCode(CThostFtdcTradingCodeField* pTradingCode,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingCode 回调 C# 参数 不能为 NULL
        CThostFtdcTradingCodeField zero0 = {0};
        if (!pTradingCode) pTradingCode = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingCode(pTradingCode,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentMarginRate(CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentMarginRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentMarginRateField zero0 = {0};
        if (!pInstrumentMarginRate) pInstrumentMarginRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentMarginRate(pInstrumentMarginRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentCommissionRate(CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentCommissionRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentCommissionRateField zero0 = {0};
        if (!pInstrumentCommissionRate) pInstrumentCommissionRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentCommissionRate(pInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchange(CThostFtdcExchangeField* pExchange,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchange 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeField zero0 = {0};
        if (!pExchange) pExchange = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchange(pExchange,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProduct(CThostFtdcProductField* pProduct,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProduct 回调 C# 参数 不能为 NULL
        CThostFtdcProductField zero0 = {0};
        if (!pProduct) pProduct = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProduct(pProduct,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrument(CThostFtdcInstrumentField* pInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentField zero0 = {0};
        if (!pInstrument) pInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrument(pInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryDepthMarketData(CThostFtdcDepthMarketDataField* pDepthMarketData,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pDepthMarketData 回调 C# 参数 不能为 NULL
        CThostFtdcDepthMarketDataField zero0 = {0};
        if (!pDepthMarketData) pDepthMarketData = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryDepthMarketData(pDepthMarketData,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTraderOffer(CThostFtdcTraderOfferField* pTraderOffer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTraderOffer 回调 C# 参数 不能为 NULL
        CThostFtdcTraderOfferField zero0 = {0};
        if (!pTraderOffer) pTraderOffer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTraderOffer(pTraderOffer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySettlementInfo(CThostFtdcSettlementInfoField* pSettlementInfo,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfo 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoField zero0 = {0};
        if (!pSettlementInfo) pSettlementInfo = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySettlementInfo(pSettlementInfo,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTransferBank(CThostFtdcTransferBankField* pTransferBank,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTransferBank 回调 C# 参数 不能为 NULL
        CThostFtdcTransferBankField zero0 = {0};
        if (!pTransferBank) pTransferBank = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTransferBank(pTransferBank,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPositionDetail(CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPositionDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionDetailField zero0 = {0};
        if (!pInvestorPositionDetail) pInvestorPositionDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPositionDetail(pInvestorPositionDetail,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryNotice(CThostFtdcNoticeField* pNotice,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pNotice 回调 C# 参数 不能为 NULL
        CThostFtdcNoticeField zero0 = {0};
        if (!pNotice) pNotice = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryNotice(pNotice,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySettlementInfoConfirm(CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfoConfirm 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoConfirmField zero0 = {0};
        if (!pSettlementInfoConfirm) pSettlementInfoConfirm = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySettlementInfoConfirm(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPositionCombineDetail(CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPositionCombineDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionCombineDetailField zero0 = {0};
        if (!pInvestorPositionCombineDetail) pInvestorPositionCombineDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCFMMCTradingAccountKey(CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCFMMCTradingAccountKey 回调 C# 参数 不能为 NULL
        CThostFtdcCFMMCTradingAccountKeyField zero0 = {0};
        if (!pCFMMCTradingAccountKey) pCFMMCTradingAccountKey = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryEWarrantOffset(CThostFtdcEWarrantOffsetField* pEWarrantOffset,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pEWarrantOffset 回调 C# 参数 不能为 NULL
        CThostFtdcEWarrantOffsetField zero0 = {0};
        if (!pEWarrantOffset) pEWarrantOffset = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryEWarrantOffset(pEWarrantOffset,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProductGroupMargin(CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProductGroupMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProductGroupMarginField zero0 = {0};
        if (!pInvestorProductGroupMargin) pInvestorProductGroupMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProductGroupMargin(pInvestorProductGroupMargin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeMarginRate(CThostFtdcExchangeMarginRateField* pExchangeMarginRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeMarginRate 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeMarginRateField zero0 = {0};
        if (!pExchangeMarginRate) pExchangeMarginRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeMarginRate(pExchangeMarginRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeMarginRateAdjust(CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeMarginRateAdjust 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeMarginRateAdjustField zero0 = {0};
        if (!pExchangeMarginRateAdjust) pExchangeMarginRateAdjust = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeMarginRateAdjust(pExchangeMarginRateAdjust,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeRate(CThostFtdcExchangeRateField* pExchangeRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeRate 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeRateField zero0 = {0};
        if (!pExchangeRate) pExchangeRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeRate(pExchangeRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentACIDMap(CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentACIDMap 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentACIDMapField zero0 = {0};
        if (!pSecAgentACIDMap) pSecAgentACIDMap = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentACIDMap(pSecAgentACIDMap,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProductExchRate(CThostFtdcProductExchRateField* pProductExchRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProductExchRate 回调 C# 参数 不能为 NULL
        CThostFtdcProductExchRateField zero0 = {0};
        if (!pProductExchRate) pProductExchRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProductExchRate(pProductExchRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProductGroup(CThostFtdcProductGroupField* pProductGroup,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProductGroup 回调 C# 参数 不能为 NULL
        CThostFtdcProductGroupField zero0 = {0};
        if (!pProductGroup) pProductGroup = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProductGroup(pProductGroup,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMMInstrumentCommissionRate(CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMMInstrumentCommissionRate 回调 C# 参数 不能为 NULL
        CThostFtdcMMInstrumentCommissionRateField zero0 = {0};
        if (!pMMInstrumentCommissionRate) pMMInstrumentCommissionRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMMInstrumentCommissionRate(pMMInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMMOptionInstrCommRate(CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMMOptionInstrCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcMMOptionInstrCommRateField zero0 = {0};
        if (!pMMOptionInstrCommRate) pMMOptionInstrCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMMOptionInstrCommRate(pMMOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentOrderCommRate(CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentOrderCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentOrderCommRateField zero0 = {0};
        if (!pInstrumentOrderCommRate) pInstrumentOrderCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentOrderCommRate(pInstrumentOrderCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentTradingAccount(CThostFtdcTradingAccountField* pTradingAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccount 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountField zero0 = {0};
        if (!pTradingAccount) pTradingAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentTradingAccount(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentCheckMode(CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentCheckMode 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentCheckModeField zero0 = {0};
        if (!pSecAgentCheckMode) pSecAgentCheckMode = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentCheckMode(pSecAgentCheckMode,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentTradeInfo(CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentTradeInfo 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentTradeInfoField zero0 = {0};
        if (!pSecAgentTradeInfo) pSecAgentTradeInfo = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentTradeInfo(pSecAgentTradeInfo,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionInstrTradeCost(CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionInstrTradeCost 回调 C# 参数 不能为 NULL
        CThostFtdcOptionInstrTradeCostField zero0 = {0};
        if (!pOptionInstrTradeCost) pOptionInstrTradeCost = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionInstrTradeCost(pOptionInstrTradeCost,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionInstrCommRate(CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionInstrCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcOptionInstrCommRateField zero0 = {0};
        if (!pOptionInstrCommRate) pOptionInstrCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionInstrCommRate(pOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExecOrder(CThostFtdcExecOrderField* pExecOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderField zero0 = {0};
        if (!pExecOrder) pExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExecOrder(pExecOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryForQuote(CThostFtdcForQuoteField* pForQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteField zero0 = {0};
        if (!pForQuote) pForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryForQuote(pForQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryQuote(CThostFtdcQuoteField* pQuote,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQuote 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteField zero0 = {0};
        if (!pQuote) pQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryQuote(pQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseField zero0 = {0};
        if (!pOptionSelfClose) pOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionSelfClose(pOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestUnit(CThostFtdcInvestUnitField* pInvestUnit,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestUnit 回调 C# 参数 不能为 NULL
        CThostFtdcInvestUnitField zero0 = {0};
        if (!pInvestUnit) pInvestUnit = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestUnit(pInvestUnit,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombInstrumentGuard(CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombInstrumentGuard 回调 C# 参数 不能为 NULL
        CThostFtdcCombInstrumentGuardField zero0 = {0};
        if (!pCombInstrumentGuard) pCombInstrumentGuard = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombInstrumentGuard(pCombInstrumentGuard,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombAction(CThostFtdcCombActionField* pCombAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcCombActionField zero0 = {0};
        if (!pCombAction) pCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombAction(pCombAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTransferSerial(CThostFtdcTransferSerialField* pTransferSerial,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTransferSerial 回调 C# 参数 不能为 NULL
        CThostFtdcTransferSerialField zero0 = {0};
        if (!pTransferSerial) pTransferSerial = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTransferSerial(pTransferSerial,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryAccountregister(CThostFtdcAccountregisterField* pAccountregister,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pAccountregister 回调 C# 参数 不能为 NULL
        CThostFtdcAccountregisterField zero0 = {0};
        if (!pAccountregister) pAccountregister = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryAccountregister(pAccountregister,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspError(CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero0 = {0};
        if (!pRspInfo) pRspInfo = &zero0;
        _callbacks.OnRspError(pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnOrder(CThostFtdcOrderField* pOrder)
    {
        //pOrder 回调 C# 参数 不能为 NULL
        CThostFtdcOrderField zero0 = {0};
        if (!pOrder) pOrder = &zero0;
        _callbacks.OnRtnOrder(pOrder);
    }

    virtual void OnRtnTrade(CThostFtdcTradeField* pTrade)
    {
        //pTrade 回调 C# 参数 不能为 NULL
        CThostFtdcTradeField zero0 = {0};
        if (!pTrade) pTrade = &zero0;
        _callbacks.OnRtnTrade(pTrade);
    }

    virtual void OnErrRtnOrderInsert(CThostFtdcInputOrderField* pInputOrder,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderField zero0 = {0};
        if (!pInputOrder) pInputOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOrderInsert(pInputOrder,pRspInfo);
    }

    virtual void OnErrRtnOrderAction(CThostFtdcOrderActionField* pOrderAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcOrderActionField zero0 = {0};
        if (!pOrderAction) pOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOrderAction(pOrderAction,pRspInfo);
    }

    virtual void OnRtnInstrumentStatus(CThostFtdcInstrumentStatusField* pInstrumentStatus)
    {
        //pInstrumentStatus 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentStatusField zero0 = {0};
        if (!pInstrumentStatus) pInstrumentStatus = &zero0;
        _callbacks.OnRtnInstrumentStatus(pInstrumentStatus);
    }

    virtual void OnRtnBulletin(CThostFtdcBulletinField* pBulletin)
    {
        //pBulletin 回调 C# 参数 不能为 NULL
        CThostFtdcBulletinField zero0 = {0};
        if (!pBulletin) pBulletin = &zero0;
        _callbacks.OnRtnBulletin(pBulletin);
    }

    virtual void OnRtnTradingNotice(CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo)
    {
        //pTradingNoticeInfo 回调 C# 参数 不能为 NULL
        CThostFtdcTradingNoticeInfoField zero0 = {0};
        if (!pTradingNoticeInfo) pTradingNoticeInfo = &zero0;
        _callbacks.OnRtnTradingNotice(pTradingNoticeInfo);
    }

    virtual void OnRtnErrorConditionalOrder(CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder)
    {
        //pErrorConditionalOrder 回调 C# 参数 不能为 NULL
        CThostFtdcErrorConditionalOrderField zero0 = {0};
        if (!pErrorConditionalOrder) pErrorConditionalOrder = &zero0;
        _callbacks.OnRtnErrorConditionalOrder(pErrorConditionalOrder);
    }

    virtual void OnRtnExecOrder(CThostFtdcExecOrderField* pExecOrder)
    {
        //pExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderField zero0 = {0};
        if (!pExecOrder) pExecOrder = &zero0;
        _callbacks.OnRtnExecOrder(pExecOrder);
    }

    virtual void OnErrRtnExecOrderInsert(CThostFtdcInputExecOrderField* pInputExecOrder,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderField zero0 = {0};
        if (!pInputExecOrder) pInputExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnExecOrderInsert(pInputExecOrder,pRspInfo);
    }

    virtual void OnErrRtnExecOrderAction(CThostFtdcExecOrderActionField* pExecOrderAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pExecOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderActionField zero0 = {0};
        if (!pExecOrderAction) pExecOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnExecOrderAction(pExecOrderAction,pRspInfo);
    }

    virtual void OnErrRtnForQuoteInsert(CThostFtdcInputForQuoteField* pInputForQuote,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputForQuoteField zero0 = {0};
        if (!pInputForQuote) pInputForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnForQuoteInsert(pInputForQuote,pRspInfo);
    }

    virtual void OnRtnQuote(CThostFtdcQuoteField* pQuote)
    {
        //pQuote 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteField zero0 = {0};
        if (!pQuote) pQuote = &zero0;
        _callbacks.OnRtnQuote(pQuote);
    }

    virtual void OnErrRtnQuoteInsert(CThostFtdcInputQuoteField* pInputQuote,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteField zero0 = {0};
        if (!pInputQuote) pInputQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQuoteInsert(pInputQuote,pRspInfo);
    }

    virtual void OnErrRtnQuoteAction(CThostFtdcQuoteActionField* pQuoteAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pQuoteAction 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteActionField zero0 = {0};
        if (!pQuoteAction) pQuoteAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQuoteAction(pQuoteAction,pRspInfo);
    }

    virtual void OnRtnForQuoteRsp(CThostFtdcForQuoteRspField* pForQuoteRsp)
    {
        //pForQuoteRsp 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteRspField zero0 = {0};
        if (!pForQuoteRsp) pForQuoteRsp = &zero0;
        _callbacks.OnRtnForQuoteRsp(pForQuoteRsp);
    }

    virtual void OnRtnCFMMCTradingAccountToken(CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken)
    {
        //pCFMMCTradingAccountToken 回调 C# 参数 不能为 NULL
        CThostFtdcCFMMCTradingAccountTokenField zero0 = {0};
        if (!pCFMMCTradingAccountToken) pCFMMCTradingAccountToken = &zero0;
        _callbacks.OnRtnCFMMCTradingAccountToken(pCFMMCTradingAccountToken);
    }

    virtual void OnErrRtnBatchOrderAction(CThostFtdcBatchOrderActionField* pBatchOrderAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pBatchOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcBatchOrderActionField zero0 = {0};
        if (!pBatchOrderAction) pBatchOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnBatchOrderAction(pBatchOrderAction,pRspInfo);
    }

    virtual void OnRtnOptionSelfClose(CThostFtdcOptionSelfCloseField* pOptionSelfClose)
    {
        //pOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseField zero0 = {0};
        if (!pOptionSelfClose) pOptionSelfClose = &zero0;
        _callbacks.OnRtnOptionSelfClose(pOptionSelfClose);
    }

    virtual void OnErrRtnOptionSelfCloseInsert(CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseField zero0 = {0};
        if (!pInputOptionSelfClose) pInputOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOptionSelfCloseInsert(pInputOptionSelfClose,pRspInfo);
    }

    virtual void OnErrRtnOptionSelfCloseAction(CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pOptionSelfCloseAction 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseActionField zero0 = {0};
        if (!pOptionSelfCloseAction) pOptionSelfCloseAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOptionSelfCloseAction(pOptionSelfCloseAction,pRspInfo);
    }

    virtual void OnRtnCombAction(CThostFtdcCombActionField* pCombAction)
    {
        //pCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcCombActionField zero0 = {0};
        if (!pCombAction) pCombAction = &zero0;
        _callbacks.OnRtnCombAction(pCombAction);
    }

    virtual void OnErrRtnCombActionInsert(CThostFtdcInputCombActionField* pInputCombAction,CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputCombActionField zero0 = {0};
        if (!pInputCombAction) pInputCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnCombActionInsert(pInputCombAction,pRspInfo);
    }

    virtual void OnRspQryContractBank(CThostFtdcContractBankField* pContractBank,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pContractBank 回调 C# 参数 不能为 NULL
        CThostFtdcContractBankField zero0 = {0};
        if (!pContractBank) pContractBank = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryContractBank(pContractBank,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryParkedOrder(CThostFtdcParkedOrderField* pParkedOrder,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderField zero0 = {0};
        if (!pParkedOrder) pParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryParkedOrder(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryParkedOrderAction(CThostFtdcParkedOrderActionField* pParkedOrderAction,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderActionField zero0 = {0};
        if (!pParkedOrderAction) pParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryParkedOrderAction(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingNotice(CThostFtdcTradingNoticeField* pTradingNotice,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingNotice 回调 C# 参数 不能为 NULL
        CThostFtdcTradingNoticeField zero0 = {0};
        if (!pTradingNotice) pTradingNotice = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingNotice(pTradingNotice,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryBrokerTradingParams(CThostFtdcBrokerTradingParamsField* pBrokerTradingParams,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pBrokerTradingParams 回调 C# 参数 不能为 NULL
        CThostFtdcBrokerTradingParamsField zero0 = {0};
        if (!pBrokerTradingParams) pBrokerTradingParams = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryBrokerTradingParams(pBrokerTradingParams,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryBrokerTradingAlgos(CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pBrokerTradingAlgos 回调 C# 参数 不能为 NULL
        CThostFtdcBrokerTradingAlgosField zero0 = {0};
        if (!pBrokerTradingAlgos) pBrokerTradingAlgos = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryBrokerTradingAlgos(pBrokerTradingAlgos,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQueryCFMMCTradingAccountToken(CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQueryCFMMCTradingAccountToken 回调 C# 参数 不能为 NULL
        CThostFtdcQueryCFMMCTradingAccountTokenField zero0 = {0};
        if (!pQueryCFMMCTradingAccountToken) pQueryCFMMCTradingAccountToken = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnFromBankToFutureByBank(CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromBankToFutureByBank(pRspTransfer);
    }

    virtual void OnRtnFromFutureToBankByBank(CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromFutureToBankByBank(pRspTransfer);
    }

    virtual void OnRtnRepealFromBankToFutureByBank(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByBank(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByBank(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByBank(pRspRepeal);
    }

    virtual void OnRtnFromBankToFutureByFuture(CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromBankToFutureByFuture(pRspTransfer);
    }

    virtual void OnRtnFromFutureToBankByFuture(CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromFutureToBankByFuture(pRspTransfer);
    }

    virtual void OnRtnRepealFromBankToFutureByFutureManual(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByFutureManual(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
    }

    virtual void OnRtnQueryBankBalanceByFuture(CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount)
    {
        //pNotifyQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcNotifyQueryAccountField zero0 = {0};
        if (!pNotifyQueryAccount) pNotifyQueryAccount = &zero0;
        _callbacks.OnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
    }

    virtual void OnErrRtnBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnBankToFutureByFuture(pReqTransfer,pRspInfo);
    }

    virtual void OnErrRtnFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnFutureToBankByFuture(pReqTransfer,pRspInfo);
    }

    virtual void OnErrRtnRepealBankToFutureByFutureManual(CThostFtdcReqRepealField* pReqRepeal,CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcReqRepealField zero0 = {0};
        if (!pReqRepeal) pReqRepeal = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnRepealBankToFutureByFutureManual(pReqRepeal,pRspInfo);
    }

    virtual void OnErrRtnRepealFutureToBankByFutureManual(CThostFtdcReqRepealField* pReqRepeal,CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcReqRepealField zero0 = {0};
        if (!pReqRepeal) pReqRepeal = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnRepealFutureToBankByFutureManual(pReqRepeal,pRspInfo);
    }

    virtual void OnErrRtnQueryBankBalanceByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount,CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcReqQueryAccountField zero0 = {0};
        if (!pReqQueryAccount) pReqQueryAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQueryBankBalanceByFuture(pReqQueryAccount,pRspInfo);
    }

    virtual void OnRtnRepealFromBankToFutureByFuture(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByFuture(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByFuture(CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByFuture(pRspRepeal);
    }

    virtual void OnRspFromBankToFutureByFuture(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspFromBankToFutureByFuture(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspFromFutureToBankByFuture(CThostFtdcReqTransferField* pReqTransfer,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspFromFutureToBankByFuture(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQueryBankAccountMoneyByFuture(CThostFtdcReqQueryAccountField* pReqQueryAccount,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcReqQueryAccountField zero0 = {0};
        if (!pReqQueryAccount) pReqQueryAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQueryBankAccountMoneyByFuture(pReqQueryAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnOpenAccountByBank(CThostFtdcOpenAccountField* pOpenAccount)
    {
        //pOpenAccount 回调 C# 参数 不能为 NULL
        CThostFtdcOpenAccountField zero0 = {0};
        if (!pOpenAccount) pOpenAccount = &zero0;
        _callbacks.OnRtnOpenAccountByBank(pOpenAccount);
    }

    virtual void OnRtnCancelAccountByBank(CThostFtdcCancelAccountField* pCancelAccount)
    {
        //pCancelAccount 回调 C# 参数 不能为 NULL
        CThostFtdcCancelAccountField zero0 = {0};
        if (!pCancelAccount) pCancelAccount = &zero0;
        _callbacks.OnRtnCancelAccountByBank(pCancelAccount);
    }

    virtual void OnRtnChangeAccountByBank(CThostFtdcChangeAccountField* pChangeAccount)
    {
        //pChangeAccount 回调 C# 参数 不能为 NULL
        CThostFtdcChangeAccountField zero0 = {0};
        if (!pChangeAccount) pChangeAccount = &zero0;
        _callbacks.OnRtnChangeAccountByBank(pChangeAccount);
    }

    virtual void OnRspQryClassifiedInstrument(CThostFtdcInstrumentField* pInstrument,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentField zero0 = {0};
        if (!pInstrument) pInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryClassifiedInstrument(pInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombPromotionParam(CThostFtdcCombPromotionParamField* pCombPromotionParam,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombPromotionParam 回调 C# 参数 不能为 NULL
        CThostFtdcCombPromotionParamField zero0 = {0};
        if (!pCombPromotionParam) pCombPromotionParam = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombPromotionParam(pCombPromotionParam,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRiskSettleInvstPosition(CThostFtdcRiskSettleInvstPositionField* pRiskSettleInvstPosition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRiskSettleInvstPosition 回调 C# 参数 不能为 NULL
        CThostFtdcRiskSettleInvstPositionField zero0 = {0};
        if (!pRiskSettleInvstPosition) pRiskSettleInvstPosition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRiskSettleInvstPosition(pRiskSettleInvstPosition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRiskSettleProductStatus(CThostFtdcRiskSettleProductStatusField* pRiskSettleProductStatus,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRiskSettleProductStatus 回调 C# 参数 不能为 NULL
        CThostFtdcRiskSettleProductStatusField zero0 = {0};
        if (!pRiskSettleProductStatus) pRiskSettleProductStatus = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRiskSettleProductStatus(pRiskSettleProductStatus,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMFutureParameter(CThostFtdcSPBMFutureParameterField* pSPBMFutureParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMFutureParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMFutureParameterField zero0 = {0};
        if (!pSPBMFutureParameter) pSPBMFutureParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMFutureParameter(pSPBMFutureParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMOptionParameter(CThostFtdcSPBMOptionParameterField* pSPBMOptionParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMOptionParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMOptionParameterField zero0 = {0};
        if (!pSPBMOptionParameter) pSPBMOptionParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMOptionParameter(pSPBMOptionParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMIntraParameter(CThostFtdcSPBMIntraParameterField* pSPBMIntraParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMIntraParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMIntraParameterField zero0 = {0};
        if (!pSPBMIntraParameter) pSPBMIntraParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMIntraParameter(pSPBMIntraParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMInterParameter(CThostFtdcSPBMInterParameterField* pSPBMInterParameter,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMInterParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMInterParameterField zero0 = {0};
        if (!pSPBMInterParameter) pSPBMInterParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMInterParameter(pSPBMInterParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMPortfDefinition(CThostFtdcSPBMPortfDefinitionField* pSPBMPortfDefinition,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMPortfDefinition 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMPortfDefinitionField zero0 = {0};
        if (!pSPBMPortfDefinition) pSPBMPortfDefinition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMPortfDefinition(pSPBMPortfDefinition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMInvestorPortfDef(CThostFtdcSPBMInvestorPortfDefField* pSPBMInvestorPortfDef,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMInvestorPortfDef 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMInvestorPortfDefField zero0 = {0};
        if (!pSPBMInvestorPortfDef) pSPBMInvestorPortfDef = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMInvestorPortfDef(pSPBMInvestorPortfDef,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPortfMarginRatio(CThostFtdcInvestorPortfMarginRatioField* pInvestorPortfMarginRatio,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPortfMarginRatio 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPortfMarginRatioField zero0 = {0};
        if (!pInvestorPortfMarginRatio) pInvestorPortfMarginRatio = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPortfMarginRatio(pInvestorPortfMarginRatio,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProdSPBMDetail(CThostFtdcInvestorProdSPBMDetailField* pInvestorProdSPBMDetail,CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProdSPBMDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProdSPBMDetailField zero0 = {0};
        if (!pInvestorProdSPBMDetail) pInvestorProdSPBMDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProdSPBMDetail(pInvestorProdSPBMDetail,pRspInfo,nRequestID,bIsLast);
    }

};
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcTraderSpi_New(const CTPSharp_CThostFtdcTraderSpi* callbacks)
{
    return new CThostFtdcTraderSpi_Ex(callbacks);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderSpi_Delete(void* spi)
{
    delete (CThostFtdcTraderSpi_Ex*)spi;
}
extern "C"
CTPSHARP_EXPORT CThostFtdcTraderApi* CTPSHARP_STDCALL CThostFtdcTraderApi_Create(const char* pszFlowPath)
{
    return CThostFtdcTraderApi::CreateFtdcTraderApi(pszFlowPath);
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcTraderApi_GetApiVersion()
{
    return CThostFtdcTraderApi::GetApiVersion();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_Release(CThostFtdcTraderApi* api)
{
    api->Release();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_Init(CThostFtdcTraderApi* api)
{
    api->Init();
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_Join(CThostFtdcTraderApi* api)
{
    return api->Join();
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcTraderApi_GetTradingDay(CThostFtdcTraderApi* api)
{
    return api->GetTradingDay();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterFront(CThostFtdcTraderApi * api,char* pszFrontAddress)
{
    api->RegisterFront(pszFrontAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterNameServer(CThostFtdcTraderApi * api,char* pszNsAddress)
{
    api->RegisterNameServer(pszNsAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterFensUserInfo(CThostFtdcTraderApi * api,CThostFtdcFensUserInfoField* pFensUserInfo)
{
    api->RegisterFensUserInfo(pFensUserInfo);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterSpi(CThostFtdcTraderApi * api,CThostFtdcTraderSpi* pSpi)
{
    api->RegisterSpi(pSpi);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_SubscribePrivateTopic(CThostFtdcTraderApi * api,THOST_TE_RESUME_TYPE nResumeType)
{
    api->SubscribePrivateTopic(nResumeType);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_SubscribePublicTopic(CThostFtdcTraderApi * api,THOST_TE_RESUME_TYPE nResumeType)
{
    api->SubscribePublicTopic(nResumeType);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqAuthenticate(CThostFtdcTraderApi * api,CThostFtdcReqAuthenticateField* pReqAuthenticateField,int nRequestID)
{
    return api->ReqAuthenticate(pReqAuthenticateField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterUserSystemInfo(CThostFtdcTraderApi * api,CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    return api->RegisterUserSystemInfo(pUserSystemInfo);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_SubmitUserSystemInfo(CThostFtdcTraderApi * api,CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    return api->SubmitUserSystemInfo(pUserSystemInfo);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLogin(CThostFtdcTraderApi * api,CThostFtdcReqUserLoginField* pReqUserLoginField,int nRequestID)
{
    return api->ReqUserLogin(pReqUserLoginField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLogout(CThostFtdcTraderApi * api,CThostFtdcUserLogoutField* pUserLogout,int nRequestID)
{
    return api->ReqUserLogout(pUserLogout,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserPasswordUpdate(CThostFtdcTraderApi * api,CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,int nRequestID)
{
    return api->ReqUserPasswordUpdate(pUserPasswordUpdate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate(CThostFtdcTraderApi * api,CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,int nRequestID)
{
    return api->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserAuthMethod(CThostFtdcTraderApi * api,CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod,int nRequestID)
{
    return api->ReqUserAuthMethod(pReqUserAuthMethod,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqGenUserCaptcha(CThostFtdcTraderApi * api,CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha,int nRequestID)
{
    return api->ReqGenUserCaptcha(pReqGenUserCaptcha,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqGenUserText(CThostFtdcTraderApi * api,CThostFtdcReqGenUserTextField* pReqGenUserText,int nRequestID)
{
    return api->ReqGenUserText(pReqGenUserText,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithCaptcha(CThostFtdcTraderApi * api,CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha,int nRequestID)
{
    return api->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithText(CThostFtdcTraderApi * api,CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText,int nRequestID)
{
    return api->ReqUserLoginWithText(pReqUserLoginWithText,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithOTP(CThostFtdcTraderApi * api,CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP,int nRequestID)
{
    return api->ReqUserLoginWithOTP(pReqUserLoginWithOTP,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOrderInsert(CThostFtdcTraderApi * api,CThostFtdcInputOrderField* pInputOrder,int nRequestID)
{
    return api->ReqOrderInsert(pInputOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqParkedOrderInsert(CThostFtdcTraderApi * api,CThostFtdcParkedOrderField* pParkedOrder,int nRequestID)
{
    return api->ReqParkedOrderInsert(pParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqParkedOrderAction(CThostFtdcTraderApi * api,CThostFtdcParkedOrderActionField* pParkedOrderAction,int nRequestID)
{
    return api->ReqParkedOrderAction(pParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOrderAction(CThostFtdcTraderApi * api,CThostFtdcInputOrderActionField* pInputOrderAction,int nRequestID)
{
    return api->ReqOrderAction(pInputOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMaxOrderVolume(CThostFtdcTraderApi * api,CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,int nRequestID)
{
    return api->ReqQryMaxOrderVolume(pQryMaxOrderVolume,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqSettlementInfoConfirm(CThostFtdcTraderApi * api,CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,int nRequestID)
{
    return api->ReqSettlementInfoConfirm(pSettlementInfoConfirm,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqRemoveParkedOrder(CThostFtdcTraderApi * api,CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,int nRequestID)
{
    return api->ReqRemoveParkedOrder(pRemoveParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqRemoveParkedOrderAction(CThostFtdcTraderApi * api,CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,int nRequestID)
{
    return api->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqExecOrderInsert(CThostFtdcTraderApi * api,CThostFtdcInputExecOrderField* pInputExecOrder,int nRequestID)
{
    return api->ReqExecOrderInsert(pInputExecOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqExecOrderAction(CThostFtdcTraderApi * api,CThostFtdcInputExecOrderActionField* pInputExecOrderAction,int nRequestID)
{
    return api->ReqExecOrderAction(pInputExecOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqForQuoteInsert(CThostFtdcTraderApi * api,CThostFtdcInputForQuoteField* pInputForQuote,int nRequestID)
{
    return api->ReqForQuoteInsert(pInputForQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQuoteInsert(CThostFtdcTraderApi * api,CThostFtdcInputQuoteField* pInputQuote,int nRequestID)
{
    return api->ReqQuoteInsert(pInputQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQuoteAction(CThostFtdcTraderApi * api,CThostFtdcInputQuoteActionField* pInputQuoteAction,int nRequestID)
{
    return api->ReqQuoteAction(pInputQuoteAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqBatchOrderAction(CThostFtdcTraderApi * api,CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,int nRequestID)
{
    return api->ReqBatchOrderAction(pInputBatchOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOptionSelfCloseInsert(CThostFtdcTraderApi * api,CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,int nRequestID)
{
    return api->ReqOptionSelfCloseInsert(pInputOptionSelfClose,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOptionSelfCloseAction(CThostFtdcTraderApi * api,CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,int nRequestID)
{
    return api->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqCombActionInsert(CThostFtdcTraderApi * api,CThostFtdcInputCombActionField* pInputCombAction,int nRequestID)
{
    return api->ReqCombActionInsert(pInputCombAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOrder(CThostFtdcTraderApi * api,CThostFtdcQryOrderField* pQryOrder,int nRequestID)
{
    return api->ReqQryOrder(pQryOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTrade(CThostFtdcTraderApi * api,CThostFtdcQryTradeField* pQryTrade,int nRequestID)
{
    return api->ReqQryTrade(pQryTrade,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPosition(CThostFtdcTraderApi * api,CThostFtdcQryInvestorPositionField* pQryInvestorPosition,int nRequestID)
{
    return api->ReqQryInvestorPosition(pQryInvestorPosition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingAccount(CThostFtdcTraderApi * api,CThostFtdcQryTradingAccountField* pQryTradingAccount,int nRequestID)
{
    return api->ReqQryTradingAccount(pQryTradingAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestor(CThostFtdcTraderApi * api,CThostFtdcQryInvestorField* pQryInvestor,int nRequestID)
{
    return api->ReqQryInvestor(pQryInvestor,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingCode(CThostFtdcTraderApi * api,CThostFtdcQryTradingCodeField* pQryTradingCode,int nRequestID)
{
    return api->ReqQryTradingCode(pQryTradingCode,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentMarginRate(CThostFtdcTraderApi * api,CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate,int nRequestID)
{
    return api->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentCommissionRate(CThostFtdcTraderApi * api,CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate,int nRequestID)
{
    return api->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchange(CThostFtdcTraderApi * api,CThostFtdcQryExchangeField* pQryExchange,int nRequestID)
{
    return api->ReqQryExchange(pQryExchange,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProduct(CThostFtdcTraderApi * api,CThostFtdcQryProductField* pQryProduct,int nRequestID)
{
    return api->ReqQryProduct(pQryProduct,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrument(CThostFtdcTraderApi * api,CThostFtdcQryInstrumentField* pQryInstrument,int nRequestID)
{
    return api->ReqQryInstrument(pQryInstrument,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryDepthMarketData(CThostFtdcTraderApi * api,CThostFtdcQryDepthMarketDataField* pQryDepthMarketData,int nRequestID)
{
    return api->ReqQryDepthMarketData(pQryDepthMarketData,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTraderOffer(CThostFtdcTraderApi * api,CThostFtdcQryTraderOfferField* pQryTraderOffer,int nRequestID)
{
    return api->ReqQryTraderOffer(pQryTraderOffer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySettlementInfo(CThostFtdcTraderApi * api,CThostFtdcQrySettlementInfoField* pQrySettlementInfo,int nRequestID)
{
    return api->ReqQrySettlementInfo(pQrySettlementInfo,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTransferBank(CThostFtdcTraderApi * api,CThostFtdcQryTransferBankField* pQryTransferBank,int nRequestID)
{
    return api->ReqQryTransferBank(pQryTransferBank,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPositionDetail(CThostFtdcTraderApi * api,CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail,int nRequestID)
{
    return api->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryNotice(CThostFtdcTraderApi * api,CThostFtdcQryNoticeField* pQryNotice,int nRequestID)
{
    return api->ReqQryNotice(pQryNotice,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySettlementInfoConfirm(CThostFtdcTraderApi * api,CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm,int nRequestID)
{
    return api->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail(CThostFtdcTraderApi * api,CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail,int nRequestID)
{
    return api->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey(CThostFtdcTraderApi * api,CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey,int nRequestID)
{
    return api->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryEWarrantOffset(CThostFtdcTraderApi * api,CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset,int nRequestID)
{
    return api->ReqQryEWarrantOffset(pQryEWarrantOffset,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin(CThostFtdcTraderApi * api,CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin,int nRequestID)
{
    return api->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeMarginRate(CThostFtdcTraderApi * api,CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate,int nRequestID)
{
    return api->ReqQryExchangeMarginRate(pQryExchangeMarginRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust(CThostFtdcTraderApi * api,CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust,int nRequestID)
{
    return api->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeRate(CThostFtdcTraderApi * api,CThostFtdcQryExchangeRateField* pQryExchangeRate,int nRequestID)
{
    return api->ReqQryExchangeRate(pQryExchangeRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentACIDMap(CThostFtdcTraderApi * api,CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap,int nRequestID)
{
    return api->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProductExchRate(CThostFtdcTraderApi * api,CThostFtdcQryProductExchRateField* pQryProductExchRate,int nRequestID)
{
    return api->ReqQryProductExchRate(pQryProductExchRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProductGroup(CThostFtdcTraderApi * api,CThostFtdcQryProductGroupField* pQryProductGroup,int nRequestID)
{
    return api->ReqQryProductGroup(pQryProductGroup,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate(CThostFtdcTraderApi * api,CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate,int nRequestID)
{
    return api->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate(CThostFtdcTraderApi * api,CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate,int nRequestID)
{
    return api->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate(CThostFtdcTraderApi * api,CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate,int nRequestID)
{
    return api->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentTradingAccount(CThostFtdcTraderApi * api,CThostFtdcQryTradingAccountField* pQryTradingAccount,int nRequestID)
{
    return api->ReqQrySecAgentTradingAccount(pQryTradingAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentCheckMode(CThostFtdcTraderApi * api,CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode,int nRequestID)
{
    return api->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentTradeInfo(CThostFtdcTraderApi * api,CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo,int nRequestID)
{
    return api->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionInstrTradeCost(CThostFtdcTraderApi * api,CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost,int nRequestID)
{
    return api->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionInstrCommRate(CThostFtdcTraderApi * api,CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate,int nRequestID)
{
    return api->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExecOrder(CThostFtdcTraderApi * api,CThostFtdcQryExecOrderField* pQryExecOrder,int nRequestID)
{
    return api->ReqQryExecOrder(pQryExecOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryForQuote(CThostFtdcTraderApi * api,CThostFtdcQryForQuoteField* pQryForQuote,int nRequestID)
{
    return api->ReqQryForQuote(pQryForQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryQuote(CThostFtdcTraderApi * api,CThostFtdcQryQuoteField* pQryQuote,int nRequestID)
{
    return api->ReqQryQuote(pQryQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionSelfClose(CThostFtdcTraderApi * api,CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose,int nRequestID)
{
    return api->ReqQryOptionSelfClose(pQryOptionSelfClose,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestUnit(CThostFtdcTraderApi * api,CThostFtdcQryInvestUnitField* pQryInvestUnit,int nRequestID)
{
    return api->ReqQryInvestUnit(pQryInvestUnit,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombInstrumentGuard(CThostFtdcTraderApi * api,CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard,int nRequestID)
{
    return api->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombAction(CThostFtdcTraderApi * api,CThostFtdcQryCombActionField* pQryCombAction,int nRequestID)
{
    return api->ReqQryCombAction(pQryCombAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTransferSerial(CThostFtdcTraderApi * api,CThostFtdcQryTransferSerialField* pQryTransferSerial,int nRequestID)
{
    return api->ReqQryTransferSerial(pQryTransferSerial,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryAccountregister(CThostFtdcTraderApi * api,CThostFtdcQryAccountregisterField* pQryAccountregister,int nRequestID)
{
    return api->ReqQryAccountregister(pQryAccountregister,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryContractBank(CThostFtdcTraderApi * api,CThostFtdcQryContractBankField* pQryContractBank,int nRequestID)
{
    return api->ReqQryContractBank(pQryContractBank,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryParkedOrder(CThostFtdcTraderApi * api,CThostFtdcQryParkedOrderField* pQryParkedOrder,int nRequestID)
{
    return api->ReqQryParkedOrder(pQryParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryParkedOrderAction(CThostFtdcTraderApi * api,CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction,int nRequestID)
{
    return api->ReqQryParkedOrderAction(pQryParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingNotice(CThostFtdcTraderApi * api,CThostFtdcQryTradingNoticeField* pQryTradingNotice,int nRequestID)
{
    return api->ReqQryTradingNotice(pQryTradingNotice,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryBrokerTradingParams(CThostFtdcTraderApi * api,CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams,int nRequestID)
{
    return api->ReqQryBrokerTradingParams(pQryBrokerTradingParams,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryBrokerTradingAlgos(CThostFtdcTraderApi * api,CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos,int nRequestID)
{
    return api->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken(CThostFtdcTraderApi * api,CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,int nRequestID)
{
    return api->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqFromBankToFutureByFuture(CThostFtdcTraderApi * api,CThostFtdcReqTransferField* pReqTransfer,int nRequestID)
{
    return api->ReqFromBankToFutureByFuture(pReqTransfer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqFromFutureToBankByFuture(CThostFtdcTraderApi * api,CThostFtdcReqTransferField* pReqTransfer,int nRequestID)
{
    return api->ReqFromFutureToBankByFuture(pReqTransfer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture(CThostFtdcTraderApi * api,CThostFtdcReqQueryAccountField* pReqQueryAccount,int nRequestID)
{
    return api->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryClassifiedInstrument(CThostFtdcTraderApi * api,CThostFtdcQryClassifiedInstrumentField* pQryClassifiedInstrument,int nRequestID)
{
    return api->ReqQryClassifiedInstrument(pQryClassifiedInstrument,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombPromotionParam(CThostFtdcTraderApi * api,CThostFtdcQryCombPromotionParamField* pQryCombPromotionParam,int nRequestID)
{
    return api->ReqQryCombPromotionParam(pQryCombPromotionParam,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition(CThostFtdcTraderApi * api,CThostFtdcQryRiskSettleInvstPositionField* pQryRiskSettleInvstPosition,int nRequestID)
{
    return api->ReqQryRiskSettleInvstPosition(pQryRiskSettleInvstPosition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRiskSettleProductStatus(CThostFtdcTraderApi * api,CThostFtdcQryRiskSettleProductStatusField* pQryRiskSettleProductStatus,int nRequestID)
{
    return api->ReqQryRiskSettleProductStatus(pQryRiskSettleProductStatus,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMFutureParameter(CThostFtdcTraderApi * api,CThostFtdcQrySPBMFutureParameterField* pQrySPBMFutureParameter,int nRequestID)
{
    return api->ReqQrySPBMFutureParameter(pQrySPBMFutureParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMOptionParameter(CThostFtdcTraderApi * api,CThostFtdcQrySPBMOptionParameterField* pQrySPBMOptionParameter,int nRequestID)
{
    return api->ReqQrySPBMOptionParameter(pQrySPBMOptionParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMIntraParameter(CThostFtdcTraderApi * api,CThostFtdcQrySPBMIntraParameterField* pQrySPBMIntraParameter,int nRequestID)
{
    return api->ReqQrySPBMIntraParameter(pQrySPBMIntraParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMInterParameter(CThostFtdcTraderApi * api,CThostFtdcQrySPBMInterParameterField* pQrySPBMInterParameter,int nRequestID)
{
    return api->ReqQrySPBMInterParameter(pQrySPBMInterParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMPortfDefinition(CThostFtdcTraderApi * api,CThostFtdcQrySPBMPortfDefinitionField* pQrySPBMPortfDefinition,int nRequestID)
{
    return api->ReqQrySPBMPortfDefinition(pQrySPBMPortfDefinition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef(CThostFtdcTraderApi * api,CThostFtdcQrySPBMInvestorPortfDefField* pQrySPBMInvestorPortfDef,int nRequestID)
{
    return api->ReqQrySPBMInvestorPortfDef(pQrySPBMInvestorPortfDef,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio(CThostFtdcTraderApi * api,CThostFtdcQryInvestorPortfMarginRatioField* pQryInvestorPortfMarginRatio,int nRequestID)
{
    return api->ReqQryInvestorPortfMarginRatio(pQryInvestorPortfMarginRatio,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail(CThostFtdcTraderApi * api,CThostFtdcQryInvestorProdSPBMDetailField* pQryInvestorProdSPBMDetail,int nRequestID)
{
    return api->ReqQryInvestorProdSPBMDetail(pQryInvestorProdSPBMDetail,nRequestID);
}

