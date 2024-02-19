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
    void (CTPSHARP_STDCALL *OnRspAuthenticate)(struct CThostFtdcRspAuthenticateField* pRspAuthenticateField,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogin)(struct CThostFtdcRspUserLoginField* pRspUserLogin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserLogout)(struct CThostFtdcUserLogoutField* pUserLogout,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserPasswordUpdate)(struct CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspTradingAccountPasswordUpdate)(struct CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspUserAuthMethod)(struct CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspGenUserCaptcha)(struct CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspGenUserText)(struct CThostFtdcRspGenUserTextField* pRspGenUserText,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOrderInsert)(struct CThostFtdcInputOrderField* pInputOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspParkedOrderInsert)(struct CThostFtdcParkedOrderField* pParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspParkedOrderAction)(struct CThostFtdcParkedOrderActionField* pParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOrderAction)(struct CThostFtdcInputOrderActionField* pInputOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMaxOrderVolume)(struct CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspSettlementInfoConfirm)(struct CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspRemoveParkedOrder)(struct CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspRemoveParkedOrderAction)(struct CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspExecOrderInsert)(struct CThostFtdcInputExecOrderField* pInputExecOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspExecOrderAction)(struct CThostFtdcInputExecOrderActionField* pInputExecOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspForQuoteInsert)(struct CThostFtdcInputForQuoteField* pInputForQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQuoteInsert)(struct CThostFtdcInputQuoteField* pInputQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQuoteAction)(struct CThostFtdcInputQuoteActionField* pInputQuoteAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspBatchOrderAction)(struct CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOptionSelfCloseInsert)(struct CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspOptionSelfCloseAction)(struct CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspCombActionInsert)(struct CThostFtdcInputCombActionField* pInputCombAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOrder)(struct CThostFtdcOrderField* pOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTrade)(struct CThostFtdcTradeField* pTrade,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPosition)(struct CThostFtdcInvestorPositionField* pInvestorPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingAccount)(struct CThostFtdcTradingAccountField* pTradingAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestor)(struct CThostFtdcInvestorField* pInvestor,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingCode)(struct CThostFtdcTradingCodeField* pTradingCode,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentMarginRate)(struct CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentCommissionRate)(struct CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchange)(struct CThostFtdcExchangeField* pExchange,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProduct)(struct CThostFtdcProductField* pProduct,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrument)(struct CThostFtdcInstrumentField* pInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryDepthMarketData)(struct CThostFtdcDepthMarketDataField* pDepthMarketData,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTraderOffer)(struct CThostFtdcTraderOfferField* pTraderOffer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySettlementInfo)(struct CThostFtdcSettlementInfoField* pSettlementInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTransferBank)(struct CThostFtdcTransferBankField* pTransferBank,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPositionDetail)(struct CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryNotice)(struct CThostFtdcNoticeField* pNotice,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySettlementInfoConfirm)(struct CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPositionCombineDetail)(struct CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCFMMCTradingAccountKey)(struct CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryEWarrantOffset)(struct CThostFtdcEWarrantOffsetField* pEWarrantOffset,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProductGroupMargin)(struct CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeMarginRate)(struct CThostFtdcExchangeMarginRateField* pExchangeMarginRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeMarginRateAdjust)(struct CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExchangeRate)(struct CThostFtdcExchangeRateField* pExchangeRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentACIDMap)(struct CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProductExchRate)(struct CThostFtdcProductExchRateField* pProductExchRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryProductGroup)(struct CThostFtdcProductGroupField* pProductGroup,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMMInstrumentCommissionRate)(struct CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryMMOptionInstrCommRate)(struct CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInstrumentOrderCommRate)(struct CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentTradingAccount)(struct CThostFtdcTradingAccountField* pTradingAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentCheckMode)(struct CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySecAgentTradeInfo)(struct CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionInstrTradeCost)(struct CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionInstrCommRate)(struct CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryExecOrder)(struct CThostFtdcExecOrderField* pExecOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryForQuote)(struct CThostFtdcForQuoteField* pForQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryQuote)(struct CThostFtdcQuoteField* pQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryOptionSelfClose)(struct CThostFtdcOptionSelfCloseField* pOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestUnit)(struct CThostFtdcInvestUnitField* pInvestUnit,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombInstrumentGuard)(struct CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombAction)(struct CThostFtdcCombActionField* pCombAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTransferSerial)(struct CThostFtdcTransferSerialField* pTransferSerial,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryAccountregister)(struct CThostFtdcAccountregisterField* pAccountregister,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspError)(struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnOrder)(struct CThostFtdcOrderField* pOrder);
    void (CTPSHARP_STDCALL *OnRtnTrade)(struct CThostFtdcTradeField* pTrade);
    void (CTPSHARP_STDCALL *OnErrRtnOrderInsert)(struct CThostFtdcInputOrderField* pInputOrder,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnOrderAction)(struct CThostFtdcOrderActionField* pOrderAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnInstrumentStatus)(struct CThostFtdcInstrumentStatusField* pInstrumentStatus);
    void (CTPSHARP_STDCALL *OnRtnBulletin)(struct CThostFtdcBulletinField* pBulletin);
    void (CTPSHARP_STDCALL *OnRtnTradingNotice)(struct CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo);
    void (CTPSHARP_STDCALL *OnRtnErrorConditionalOrder)(struct CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder);
    void (CTPSHARP_STDCALL *OnRtnExecOrder)(struct CThostFtdcExecOrderField* pExecOrder);
    void (CTPSHARP_STDCALL *OnErrRtnExecOrderInsert)(struct CThostFtdcInputExecOrderField* pInputExecOrder,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnExecOrderAction)(struct CThostFtdcExecOrderActionField* pExecOrderAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnForQuoteInsert)(struct CThostFtdcInputForQuoteField* pInputForQuote,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnQuote)(struct CThostFtdcQuoteField* pQuote);
    void (CTPSHARP_STDCALL *OnErrRtnQuoteInsert)(struct CThostFtdcInputQuoteField* pInputQuote,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnQuoteAction)(struct CThostFtdcQuoteActionField* pQuoteAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnForQuoteRsp)(struct CThostFtdcForQuoteRspField* pForQuoteRsp);
    void (CTPSHARP_STDCALL *OnRtnCFMMCTradingAccountToken)(struct CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken);
    void (CTPSHARP_STDCALL *OnErrRtnBatchOrderAction)(struct CThostFtdcBatchOrderActionField* pBatchOrderAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnOptionSelfClose)(struct CThostFtdcOptionSelfCloseField* pOptionSelfClose);
    void (CTPSHARP_STDCALL *OnErrRtnOptionSelfCloseInsert)(struct CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnOptionSelfCloseAction)(struct CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnCombAction)(struct CThostFtdcCombActionField* pCombAction);
    void (CTPSHARP_STDCALL *OnErrRtnCombActionInsert)(struct CThostFtdcInputCombActionField* pInputCombAction,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRspQryContractBank)(struct CThostFtdcContractBankField* pContractBank,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryParkedOrder)(struct CThostFtdcParkedOrderField* pParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryParkedOrderAction)(struct CThostFtdcParkedOrderActionField* pParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryTradingNotice)(struct CThostFtdcTradingNoticeField* pTradingNotice,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryBrokerTradingParams)(struct CThostFtdcBrokerTradingParamsField* pBrokerTradingParams,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryBrokerTradingAlgos)(struct CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQueryCFMMCTradingAccountToken)(struct CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnFromBankToFutureByBank)(struct CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnFromFutureToBankByBank)(struct CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByBank)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByBank)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnFromBankToFutureByFuture)(struct CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnFromFutureToBankByFuture)(struct CThostFtdcRspTransferField* pRspTransfer);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByFutureManual)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByFutureManual)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnQueryBankBalanceByFuture)(struct CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount);
    void (CTPSHARP_STDCALL *OnErrRtnBankToFutureByFuture)(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnFutureToBankByFuture)(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnRepealBankToFutureByFutureManual)(struct CThostFtdcReqRepealField* pReqRepeal,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnRepealFutureToBankByFutureManual)(struct CThostFtdcReqRepealField* pReqRepeal,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnErrRtnQueryBankBalanceByFuture)(struct CThostFtdcReqQueryAccountField* pReqQueryAccount,struct CThostFtdcRspInfoField* pRspInfo);
    void (CTPSHARP_STDCALL *OnRtnRepealFromBankToFutureByFuture)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRtnRepealFromFutureToBankByFuture)(struct CThostFtdcRspRepealField* pRspRepeal);
    void (CTPSHARP_STDCALL *OnRspFromBankToFutureByFuture)(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspFromFutureToBankByFuture)(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQueryBankAccountMoneyByFuture)(struct CThostFtdcReqQueryAccountField* pReqQueryAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRtnOpenAccountByBank)(struct CThostFtdcOpenAccountField* pOpenAccount);
    void (CTPSHARP_STDCALL *OnRtnCancelAccountByBank)(struct CThostFtdcCancelAccountField* pCancelAccount);
    void (CTPSHARP_STDCALL *OnRtnChangeAccountByBank)(struct CThostFtdcChangeAccountField* pChangeAccount);
    void (CTPSHARP_STDCALL *OnRspQryClassifiedInstrument)(struct CThostFtdcInstrumentField* pInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryCombPromotionParam)(struct CThostFtdcCombPromotionParamField* pCombPromotionParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRiskSettleInvstPosition)(struct CThostFtdcRiskSettleInvstPositionField* pRiskSettleInvstPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRiskSettleProductStatus)(struct CThostFtdcRiskSettleProductStatusField* pRiskSettleProductStatus,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMFutureParameter)(struct CThostFtdcSPBMFutureParameterField* pSPBMFutureParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMOptionParameter)(struct CThostFtdcSPBMOptionParameterField* pSPBMOptionParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMIntraParameter)(struct CThostFtdcSPBMIntraParameterField* pSPBMIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMInterParameter)(struct CThostFtdcSPBMInterParameterField* pSPBMInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMPortfDefinition)(struct CThostFtdcSPBMPortfDefinitionField* pSPBMPortfDefinition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMInvestorPortfDef)(struct CThostFtdcSPBMInvestorPortfDefField* pSPBMInvestorPortfDef,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorPortfMarginRatio)(struct CThostFtdcInvestorPortfMarginRatioField* pInvestorPortfMarginRatio,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProdSPBMDetail)(struct CThostFtdcInvestorProdSPBMDetailField* pInvestorProdSPBMDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorCommoditySPMMMargin)(struct CThostFtdcInvestorCommoditySPMMMarginField* pInvestorCommoditySPMMMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorCommodityGroupSPMMMargin)(struct CThostFtdcInvestorCommodityGroupSPMMMarginField* pInvestorCommodityGroupSPMMMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPMMInstParam)(struct CThostFtdcSPMMInstParamField* pSPMMInstParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPMMProductParam)(struct CThostFtdcSPMMProductParamField* pSPMMProductParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQrySPBMAddOnInterParameter)(struct CThostFtdcSPBMAddOnInterParameterField* pSPBMAddOnInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSCombProductInfo)(struct CThostFtdcRCAMSCombProductInfoField* pRCAMSCombProductInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSInstrParameter)(struct CThostFtdcRCAMSInstrParameterField* pRCAMSInstrParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSIntraParameter)(struct CThostFtdcRCAMSIntraParameterField* pRCAMSIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSInterParameter)(struct CThostFtdcRCAMSInterParameterField* pRCAMSInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSShortOptAdjustParam)(struct CThostFtdcRCAMSShortOptAdjustParamField* pRCAMSShortOptAdjustParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRCAMSInvestorCombPosition)(struct CThostFtdcRCAMSInvestorCombPositionField* pRCAMSInvestorCombPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProdRCAMSMargin)(struct CThostFtdcInvestorProdRCAMSMarginField* pInvestorProdRCAMSMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRULEInstrParameter)(struct CThostFtdcRULEInstrParameterField* pRULEInstrParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRULEIntraParameter)(struct CThostFtdcRULEIntraParameterField* pRULEIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryRULEInterParameter)(struct CThostFtdcRULEInterParameterField* pRULEInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
    void (CTPSHARP_STDCALL *OnRspQryInvestorProdRULEMargin)(struct CThostFtdcInvestorProdRULEMarginField* pInvestorProdRULEMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast);
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

    virtual void OnRspAuthenticate(struct CThostFtdcRspAuthenticateField* pRspAuthenticateField,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspAuthenticateField 回调 C# 参数 不能为 NULL
        CThostFtdcRspAuthenticateField zero0 = {0};
        if (!pRspAuthenticateField) pRspAuthenticateField = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspAuthenticate(pRspAuthenticateField,pRspInfo,nRequestID,bIsLast);
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

    virtual void OnRspUserPasswordUpdate(struct CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pUserPasswordUpdate 回调 C# 参数 不能为 NULL
        CThostFtdcUserPasswordUpdateField zero0 = {0};
        if (!pUserPasswordUpdate) pUserPasswordUpdate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserPasswordUpdate(pUserPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspTradingAccountPasswordUpdate(struct CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccountPasswordUpdate 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountPasswordUpdateField zero0 = {0};
        if (!pTradingAccountPasswordUpdate) pTradingAccountPasswordUpdate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspUserAuthMethod(struct CThostFtdcRspUserAuthMethodField* pRspUserAuthMethod,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspUserAuthMethod 回调 C# 参数 不能为 NULL
        CThostFtdcRspUserAuthMethodField zero0 = {0};
        if (!pRspUserAuthMethod) pRspUserAuthMethod = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspUserAuthMethod(pRspUserAuthMethod,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspGenUserCaptcha(struct CThostFtdcRspGenUserCaptchaField* pRspGenUserCaptcha,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspGenUserCaptcha 回调 C# 参数 不能为 NULL
        CThostFtdcRspGenUserCaptchaField zero0 = {0};
        if (!pRspGenUserCaptcha) pRspGenUserCaptcha = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspGenUserCaptcha(pRspGenUserCaptcha,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspGenUserText(struct CThostFtdcRspGenUserTextField* pRspGenUserText,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspGenUserText 回调 C# 参数 不能为 NULL
        CThostFtdcRspGenUserTextField zero0 = {0};
        if (!pRspGenUserText) pRspGenUserText = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspGenUserText(pRspGenUserText,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOrderInsert(struct CThostFtdcInputOrderField* pInputOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderField zero0 = {0};
        if (!pInputOrder) pInputOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOrderInsert(pInputOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspParkedOrderInsert(struct CThostFtdcParkedOrderField* pParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderField zero0 = {0};
        if (!pParkedOrder) pParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspParkedOrderInsert(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspParkedOrderAction(struct CThostFtdcParkedOrderActionField* pParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderActionField zero0 = {0};
        if (!pParkedOrderAction) pParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspParkedOrderAction(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOrderAction(struct CThostFtdcInputOrderActionField* pInputOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderActionField zero0 = {0};
        if (!pInputOrderAction) pInputOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOrderAction(pInputOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMaxOrderVolume(struct CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQryMaxOrderVolume 回调 C# 参数 不能为 NULL
        CThostFtdcQryMaxOrderVolumeField zero0 = {0};
        if (!pQryMaxOrderVolume) pQryMaxOrderVolume = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMaxOrderVolume(pQryMaxOrderVolume,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspSettlementInfoConfirm(struct CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfoConfirm 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoConfirmField zero0 = {0};
        if (!pSettlementInfoConfirm) pSettlementInfoConfirm = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspSettlementInfoConfirm(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspRemoveParkedOrder(struct CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRemoveParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcRemoveParkedOrderField zero0 = {0};
        if (!pRemoveParkedOrder) pRemoveParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspRemoveParkedOrder(pRemoveParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspRemoveParkedOrderAction(struct CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRemoveParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcRemoveParkedOrderActionField zero0 = {0};
        if (!pRemoveParkedOrderAction) pRemoveParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspRemoveParkedOrderAction(pRemoveParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspExecOrderInsert(struct CThostFtdcInputExecOrderField* pInputExecOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderField zero0 = {0};
        if (!pInputExecOrder) pInputExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspExecOrderInsert(pInputExecOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspExecOrderAction(struct CThostFtdcInputExecOrderActionField* pInputExecOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputExecOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderActionField zero0 = {0};
        if (!pInputExecOrderAction) pInputExecOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspExecOrderAction(pInputExecOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspForQuoteInsert(struct CThostFtdcInputForQuoteField* pInputForQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputForQuoteField zero0 = {0};
        if (!pInputForQuote) pInputForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspForQuoteInsert(pInputForQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQuoteInsert(struct CThostFtdcInputQuoteField* pInputQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteField zero0 = {0};
        if (!pInputQuote) pInputQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQuoteInsert(pInputQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQuoteAction(struct CThostFtdcInputQuoteActionField* pInputQuoteAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputQuoteAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteActionField zero0 = {0};
        if (!pInputQuoteAction) pInputQuoteAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQuoteAction(pInputQuoteAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspBatchOrderAction(struct CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputBatchOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputBatchOrderActionField zero0 = {0};
        if (!pInputBatchOrderAction) pInputBatchOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspBatchOrderAction(pInputBatchOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOptionSelfCloseInsert(struct CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseField zero0 = {0};
        if (!pInputOptionSelfClose) pInputOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOptionSelfCloseInsert(pInputOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspOptionSelfCloseAction(struct CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputOptionSelfCloseAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseActionField zero0 = {0};
        if (!pInputOptionSelfCloseAction) pInputOptionSelfCloseAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspOptionSelfCloseAction(pInputOptionSelfCloseAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspCombActionInsert(struct CThostFtdcInputCombActionField* pInputCombAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInputCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputCombActionField zero0 = {0};
        if (!pInputCombAction) pInputCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspCombActionInsert(pInputCombAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOrder(struct CThostFtdcOrderField* pOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOrder 回调 C# 参数 不能为 NULL
        CThostFtdcOrderField zero0 = {0};
        if (!pOrder) pOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOrder(pOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTrade(struct CThostFtdcTradeField* pTrade,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTrade 回调 C# 参数 不能为 NULL
        CThostFtdcTradeField zero0 = {0};
        if (!pTrade) pTrade = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTrade(pTrade,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPosition(struct CThostFtdcInvestorPositionField* pInvestorPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPosition 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionField zero0 = {0};
        if (!pInvestorPosition) pInvestorPosition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPosition(pInvestorPosition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingAccount(struct CThostFtdcTradingAccountField* pTradingAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccount 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountField zero0 = {0};
        if (!pTradingAccount) pTradingAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingAccount(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestor(struct CThostFtdcInvestorField* pInvestor,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestor 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorField zero0 = {0};
        if (!pInvestor) pInvestor = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestor(pInvestor,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingCode(struct CThostFtdcTradingCodeField* pTradingCode,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingCode 回调 C# 参数 不能为 NULL
        CThostFtdcTradingCodeField zero0 = {0};
        if (!pTradingCode) pTradingCode = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingCode(pTradingCode,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentMarginRate(struct CThostFtdcInstrumentMarginRateField* pInstrumentMarginRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentMarginRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentMarginRateField zero0 = {0};
        if (!pInstrumentMarginRate) pInstrumentMarginRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentMarginRate(pInstrumentMarginRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentCommissionRate(struct CThostFtdcInstrumentCommissionRateField* pInstrumentCommissionRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentCommissionRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentCommissionRateField zero0 = {0};
        if (!pInstrumentCommissionRate) pInstrumentCommissionRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentCommissionRate(pInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchange(struct CThostFtdcExchangeField* pExchange,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchange 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeField zero0 = {0};
        if (!pExchange) pExchange = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchange(pExchange,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProduct(struct CThostFtdcProductField* pProduct,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProduct 回调 C# 参数 不能为 NULL
        CThostFtdcProductField zero0 = {0};
        if (!pProduct) pProduct = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProduct(pProduct,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrument(struct CThostFtdcInstrumentField* pInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentField zero0 = {0};
        if (!pInstrument) pInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrument(pInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryDepthMarketData(struct CThostFtdcDepthMarketDataField* pDepthMarketData,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pDepthMarketData 回调 C# 参数 不能为 NULL
        CThostFtdcDepthMarketDataField zero0 = {0};
        if (!pDepthMarketData) pDepthMarketData = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryDepthMarketData(pDepthMarketData,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTraderOffer(struct CThostFtdcTraderOfferField* pTraderOffer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTraderOffer 回调 C# 参数 不能为 NULL
        CThostFtdcTraderOfferField zero0 = {0};
        if (!pTraderOffer) pTraderOffer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTraderOffer(pTraderOffer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySettlementInfo(struct CThostFtdcSettlementInfoField* pSettlementInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfo 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoField zero0 = {0};
        if (!pSettlementInfo) pSettlementInfo = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySettlementInfo(pSettlementInfo,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTransferBank(struct CThostFtdcTransferBankField* pTransferBank,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTransferBank 回调 C# 参数 不能为 NULL
        CThostFtdcTransferBankField zero0 = {0};
        if (!pTransferBank) pTransferBank = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTransferBank(pTransferBank,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPositionDetail(struct CThostFtdcInvestorPositionDetailField* pInvestorPositionDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPositionDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionDetailField zero0 = {0};
        if (!pInvestorPositionDetail) pInvestorPositionDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPositionDetail(pInvestorPositionDetail,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryNotice(struct CThostFtdcNoticeField* pNotice,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pNotice 回调 C# 参数 不能为 NULL
        CThostFtdcNoticeField zero0 = {0};
        if (!pNotice) pNotice = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryNotice(pNotice,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySettlementInfoConfirm(struct CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSettlementInfoConfirm 回调 C# 参数 不能为 NULL
        CThostFtdcSettlementInfoConfirmField zero0 = {0};
        if (!pSettlementInfoConfirm) pSettlementInfoConfirm = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySettlementInfoConfirm(pSettlementInfoConfirm,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPositionCombineDetail(struct CThostFtdcInvestorPositionCombineDetailField* pInvestorPositionCombineDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPositionCombineDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPositionCombineDetailField zero0 = {0};
        if (!pInvestorPositionCombineDetail) pInvestorPositionCombineDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPositionCombineDetail(pInvestorPositionCombineDetail,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCFMMCTradingAccountKey(struct CThostFtdcCFMMCTradingAccountKeyField* pCFMMCTradingAccountKey,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCFMMCTradingAccountKey 回调 C# 参数 不能为 NULL
        CThostFtdcCFMMCTradingAccountKeyField zero0 = {0};
        if (!pCFMMCTradingAccountKey) pCFMMCTradingAccountKey = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCFMMCTradingAccountKey(pCFMMCTradingAccountKey,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryEWarrantOffset(struct CThostFtdcEWarrantOffsetField* pEWarrantOffset,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pEWarrantOffset 回调 C# 参数 不能为 NULL
        CThostFtdcEWarrantOffsetField zero0 = {0};
        if (!pEWarrantOffset) pEWarrantOffset = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryEWarrantOffset(pEWarrantOffset,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProductGroupMargin(struct CThostFtdcInvestorProductGroupMarginField* pInvestorProductGroupMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProductGroupMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProductGroupMarginField zero0 = {0};
        if (!pInvestorProductGroupMargin) pInvestorProductGroupMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProductGroupMargin(pInvestorProductGroupMargin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeMarginRate(struct CThostFtdcExchangeMarginRateField* pExchangeMarginRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeMarginRate 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeMarginRateField zero0 = {0};
        if (!pExchangeMarginRate) pExchangeMarginRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeMarginRate(pExchangeMarginRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeMarginRateAdjust(struct CThostFtdcExchangeMarginRateAdjustField* pExchangeMarginRateAdjust,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeMarginRateAdjust 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeMarginRateAdjustField zero0 = {0};
        if (!pExchangeMarginRateAdjust) pExchangeMarginRateAdjust = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeMarginRateAdjust(pExchangeMarginRateAdjust,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExchangeRate(struct CThostFtdcExchangeRateField* pExchangeRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExchangeRate 回调 C# 参数 不能为 NULL
        CThostFtdcExchangeRateField zero0 = {0};
        if (!pExchangeRate) pExchangeRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExchangeRate(pExchangeRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentACIDMap(struct CThostFtdcSecAgentACIDMapField* pSecAgentACIDMap,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentACIDMap 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentACIDMapField zero0 = {0};
        if (!pSecAgentACIDMap) pSecAgentACIDMap = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentACIDMap(pSecAgentACIDMap,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProductExchRate(struct CThostFtdcProductExchRateField* pProductExchRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProductExchRate 回调 C# 参数 不能为 NULL
        CThostFtdcProductExchRateField zero0 = {0};
        if (!pProductExchRate) pProductExchRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProductExchRate(pProductExchRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryProductGroup(struct CThostFtdcProductGroupField* pProductGroup,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pProductGroup 回调 C# 参数 不能为 NULL
        CThostFtdcProductGroupField zero0 = {0};
        if (!pProductGroup) pProductGroup = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryProductGroup(pProductGroup,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMMInstrumentCommissionRate(struct CThostFtdcMMInstrumentCommissionRateField* pMMInstrumentCommissionRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMMInstrumentCommissionRate 回调 C# 参数 不能为 NULL
        CThostFtdcMMInstrumentCommissionRateField zero0 = {0};
        if (!pMMInstrumentCommissionRate) pMMInstrumentCommissionRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMMInstrumentCommissionRate(pMMInstrumentCommissionRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryMMOptionInstrCommRate(struct CThostFtdcMMOptionInstrCommRateField* pMMOptionInstrCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pMMOptionInstrCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcMMOptionInstrCommRateField zero0 = {0};
        if (!pMMOptionInstrCommRate) pMMOptionInstrCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryMMOptionInstrCommRate(pMMOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInstrumentOrderCommRate(struct CThostFtdcInstrumentOrderCommRateField* pInstrumentOrderCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrumentOrderCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentOrderCommRateField zero0 = {0};
        if (!pInstrumentOrderCommRate) pInstrumentOrderCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInstrumentOrderCommRate(pInstrumentOrderCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentTradingAccount(struct CThostFtdcTradingAccountField* pTradingAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingAccount 回调 C# 参数 不能为 NULL
        CThostFtdcTradingAccountField zero0 = {0};
        if (!pTradingAccount) pTradingAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentTradingAccount(pTradingAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentCheckMode(struct CThostFtdcSecAgentCheckModeField* pSecAgentCheckMode,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentCheckMode 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentCheckModeField zero0 = {0};
        if (!pSecAgentCheckMode) pSecAgentCheckMode = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentCheckMode(pSecAgentCheckMode,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySecAgentTradeInfo(struct CThostFtdcSecAgentTradeInfoField* pSecAgentTradeInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSecAgentTradeInfo 回调 C# 参数 不能为 NULL
        CThostFtdcSecAgentTradeInfoField zero0 = {0};
        if (!pSecAgentTradeInfo) pSecAgentTradeInfo = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySecAgentTradeInfo(pSecAgentTradeInfo,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionInstrTradeCost(struct CThostFtdcOptionInstrTradeCostField* pOptionInstrTradeCost,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionInstrTradeCost 回调 C# 参数 不能为 NULL
        CThostFtdcOptionInstrTradeCostField zero0 = {0};
        if (!pOptionInstrTradeCost) pOptionInstrTradeCost = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionInstrTradeCost(pOptionInstrTradeCost,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionInstrCommRate(struct CThostFtdcOptionInstrCommRateField* pOptionInstrCommRate,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionInstrCommRate 回调 C# 参数 不能为 NULL
        CThostFtdcOptionInstrCommRateField zero0 = {0};
        if (!pOptionInstrCommRate) pOptionInstrCommRate = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionInstrCommRate(pOptionInstrCommRate,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryExecOrder(struct CThostFtdcExecOrderField* pExecOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderField zero0 = {0};
        if (!pExecOrder) pExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryExecOrder(pExecOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryForQuote(struct CThostFtdcForQuoteField* pForQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteField zero0 = {0};
        if (!pForQuote) pForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryForQuote(pForQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryQuote(struct CThostFtdcQuoteField* pQuote,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQuote 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteField zero0 = {0};
        if (!pQuote) pQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryQuote(pQuote,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryOptionSelfClose(struct CThostFtdcOptionSelfCloseField* pOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseField zero0 = {0};
        if (!pOptionSelfClose) pOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryOptionSelfClose(pOptionSelfClose,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestUnit(struct CThostFtdcInvestUnitField* pInvestUnit,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestUnit 回调 C# 参数 不能为 NULL
        CThostFtdcInvestUnitField zero0 = {0};
        if (!pInvestUnit) pInvestUnit = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestUnit(pInvestUnit,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombInstrumentGuard(struct CThostFtdcCombInstrumentGuardField* pCombInstrumentGuard,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombInstrumentGuard 回调 C# 参数 不能为 NULL
        CThostFtdcCombInstrumentGuardField zero0 = {0};
        if (!pCombInstrumentGuard) pCombInstrumentGuard = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombInstrumentGuard(pCombInstrumentGuard,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombAction(struct CThostFtdcCombActionField* pCombAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcCombActionField zero0 = {0};
        if (!pCombAction) pCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombAction(pCombAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTransferSerial(struct CThostFtdcTransferSerialField* pTransferSerial,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTransferSerial 回调 C# 参数 不能为 NULL
        CThostFtdcTransferSerialField zero0 = {0};
        if (!pTransferSerial) pTransferSerial = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTransferSerial(pTransferSerial,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryAccountregister(struct CThostFtdcAccountregisterField* pAccountregister,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pAccountregister 回调 C# 参数 不能为 NULL
        CThostFtdcAccountregisterField zero0 = {0};
        if (!pAccountregister) pAccountregister = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryAccountregister(pAccountregister,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspError(struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero0 = {0};
        if (!pRspInfo) pRspInfo = &zero0;
        _callbacks.OnRspError(pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnOrder(struct CThostFtdcOrderField* pOrder)
    {
        //pOrder 回调 C# 参数 不能为 NULL
        CThostFtdcOrderField zero0 = {0};
        if (!pOrder) pOrder = &zero0;
        _callbacks.OnRtnOrder(pOrder);
    }

    virtual void OnRtnTrade(struct CThostFtdcTradeField* pTrade)
    {
        //pTrade 回调 C# 参数 不能为 NULL
        CThostFtdcTradeField zero0 = {0};
        if (!pTrade) pTrade = &zero0;
        _callbacks.OnRtnTrade(pTrade);
    }

    virtual void OnErrRtnOrderInsert(struct CThostFtdcInputOrderField* pInputOrder,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputOrderField zero0 = {0};
        if (!pInputOrder) pInputOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOrderInsert(pInputOrder,pRspInfo);
    }

    virtual void OnErrRtnOrderAction(struct CThostFtdcOrderActionField* pOrderAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcOrderActionField zero0 = {0};
        if (!pOrderAction) pOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOrderAction(pOrderAction,pRspInfo);
    }

    virtual void OnRtnInstrumentStatus(struct CThostFtdcInstrumentStatusField* pInstrumentStatus)
    {
        //pInstrumentStatus 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentStatusField zero0 = {0};
        if (!pInstrumentStatus) pInstrumentStatus = &zero0;
        _callbacks.OnRtnInstrumentStatus(pInstrumentStatus);
    }

    virtual void OnRtnBulletin(struct CThostFtdcBulletinField* pBulletin)
    {
        //pBulletin 回调 C# 参数 不能为 NULL
        CThostFtdcBulletinField zero0 = {0};
        if (!pBulletin) pBulletin = &zero0;
        _callbacks.OnRtnBulletin(pBulletin);
    }

    virtual void OnRtnTradingNotice(struct CThostFtdcTradingNoticeInfoField* pTradingNoticeInfo)
    {
        //pTradingNoticeInfo 回调 C# 参数 不能为 NULL
        CThostFtdcTradingNoticeInfoField zero0 = {0};
        if (!pTradingNoticeInfo) pTradingNoticeInfo = &zero0;
        _callbacks.OnRtnTradingNotice(pTradingNoticeInfo);
    }

    virtual void OnRtnErrorConditionalOrder(struct CThostFtdcErrorConditionalOrderField* pErrorConditionalOrder)
    {
        //pErrorConditionalOrder 回调 C# 参数 不能为 NULL
        CThostFtdcErrorConditionalOrderField zero0 = {0};
        if (!pErrorConditionalOrder) pErrorConditionalOrder = &zero0;
        _callbacks.OnRtnErrorConditionalOrder(pErrorConditionalOrder);
    }

    virtual void OnRtnExecOrder(struct CThostFtdcExecOrderField* pExecOrder)
    {
        //pExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderField zero0 = {0};
        if (!pExecOrder) pExecOrder = &zero0;
        _callbacks.OnRtnExecOrder(pExecOrder);
    }

    virtual void OnErrRtnExecOrderInsert(struct CThostFtdcInputExecOrderField* pInputExecOrder,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputExecOrder 回调 C# 参数 不能为 NULL
        CThostFtdcInputExecOrderField zero0 = {0};
        if (!pInputExecOrder) pInputExecOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnExecOrderInsert(pInputExecOrder,pRspInfo);
    }

    virtual void OnErrRtnExecOrderAction(struct CThostFtdcExecOrderActionField* pExecOrderAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pExecOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcExecOrderActionField zero0 = {0};
        if (!pExecOrderAction) pExecOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnExecOrderAction(pExecOrderAction,pRspInfo);
    }

    virtual void OnErrRtnForQuoteInsert(struct CThostFtdcInputForQuoteField* pInputForQuote,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputForQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputForQuoteField zero0 = {0};
        if (!pInputForQuote) pInputForQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnForQuoteInsert(pInputForQuote,pRspInfo);
    }

    virtual void OnRtnQuote(struct CThostFtdcQuoteField* pQuote)
    {
        //pQuote 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteField zero0 = {0};
        if (!pQuote) pQuote = &zero0;
        _callbacks.OnRtnQuote(pQuote);
    }

    virtual void OnErrRtnQuoteInsert(struct CThostFtdcInputQuoteField* pInputQuote,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputQuote 回调 C# 参数 不能为 NULL
        CThostFtdcInputQuoteField zero0 = {0};
        if (!pInputQuote) pInputQuote = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQuoteInsert(pInputQuote,pRspInfo);
    }

    virtual void OnErrRtnQuoteAction(struct CThostFtdcQuoteActionField* pQuoteAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pQuoteAction 回调 C# 参数 不能为 NULL
        CThostFtdcQuoteActionField zero0 = {0};
        if (!pQuoteAction) pQuoteAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQuoteAction(pQuoteAction,pRspInfo);
    }

    virtual void OnRtnForQuoteRsp(struct CThostFtdcForQuoteRspField* pForQuoteRsp)
    {
        //pForQuoteRsp 回调 C# 参数 不能为 NULL
        CThostFtdcForQuoteRspField zero0 = {0};
        if (!pForQuoteRsp) pForQuoteRsp = &zero0;
        _callbacks.OnRtnForQuoteRsp(pForQuoteRsp);
    }

    virtual void OnRtnCFMMCTradingAccountToken(struct CThostFtdcCFMMCTradingAccountTokenField* pCFMMCTradingAccountToken)
    {
        //pCFMMCTradingAccountToken 回调 C# 参数 不能为 NULL
        CThostFtdcCFMMCTradingAccountTokenField zero0 = {0};
        if (!pCFMMCTradingAccountToken) pCFMMCTradingAccountToken = &zero0;
        _callbacks.OnRtnCFMMCTradingAccountToken(pCFMMCTradingAccountToken);
    }

    virtual void OnErrRtnBatchOrderAction(struct CThostFtdcBatchOrderActionField* pBatchOrderAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pBatchOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcBatchOrderActionField zero0 = {0};
        if (!pBatchOrderAction) pBatchOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnBatchOrderAction(pBatchOrderAction,pRspInfo);
    }

    virtual void OnRtnOptionSelfClose(struct CThostFtdcOptionSelfCloseField* pOptionSelfClose)
    {
        //pOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseField zero0 = {0};
        if (!pOptionSelfClose) pOptionSelfClose = &zero0;
        _callbacks.OnRtnOptionSelfClose(pOptionSelfClose);
    }

    virtual void OnErrRtnOptionSelfCloseInsert(struct CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputOptionSelfClose 回调 C# 参数 不能为 NULL
        CThostFtdcInputOptionSelfCloseField zero0 = {0};
        if (!pInputOptionSelfClose) pInputOptionSelfClose = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOptionSelfCloseInsert(pInputOptionSelfClose,pRspInfo);
    }

    virtual void OnErrRtnOptionSelfCloseAction(struct CThostFtdcOptionSelfCloseActionField* pOptionSelfCloseAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pOptionSelfCloseAction 回调 C# 参数 不能为 NULL
        CThostFtdcOptionSelfCloseActionField zero0 = {0};
        if (!pOptionSelfCloseAction) pOptionSelfCloseAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnOptionSelfCloseAction(pOptionSelfCloseAction,pRspInfo);
    }

    virtual void OnRtnCombAction(struct CThostFtdcCombActionField* pCombAction)
    {
        //pCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcCombActionField zero0 = {0};
        if (!pCombAction) pCombAction = &zero0;
        _callbacks.OnRtnCombAction(pCombAction);
    }

    virtual void OnErrRtnCombActionInsert(struct CThostFtdcInputCombActionField* pInputCombAction,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pInputCombAction 回调 C# 参数 不能为 NULL
        CThostFtdcInputCombActionField zero0 = {0};
        if (!pInputCombAction) pInputCombAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnCombActionInsert(pInputCombAction,pRspInfo);
    }

    virtual void OnRspQryContractBank(struct CThostFtdcContractBankField* pContractBank,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pContractBank 回调 C# 参数 不能为 NULL
        CThostFtdcContractBankField zero0 = {0};
        if (!pContractBank) pContractBank = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryContractBank(pContractBank,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryParkedOrder(struct CThostFtdcParkedOrderField* pParkedOrder,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrder 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderField zero0 = {0};
        if (!pParkedOrder) pParkedOrder = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryParkedOrder(pParkedOrder,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryParkedOrderAction(struct CThostFtdcParkedOrderActionField* pParkedOrderAction,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pParkedOrderAction 回调 C# 参数 不能为 NULL
        CThostFtdcParkedOrderActionField zero0 = {0};
        if (!pParkedOrderAction) pParkedOrderAction = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryParkedOrderAction(pParkedOrderAction,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryTradingNotice(struct CThostFtdcTradingNoticeField* pTradingNotice,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pTradingNotice 回调 C# 参数 不能为 NULL
        CThostFtdcTradingNoticeField zero0 = {0};
        if (!pTradingNotice) pTradingNotice = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryTradingNotice(pTradingNotice,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryBrokerTradingParams(struct CThostFtdcBrokerTradingParamsField* pBrokerTradingParams,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pBrokerTradingParams 回调 C# 参数 不能为 NULL
        CThostFtdcBrokerTradingParamsField zero0 = {0};
        if (!pBrokerTradingParams) pBrokerTradingParams = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryBrokerTradingParams(pBrokerTradingParams,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryBrokerTradingAlgos(struct CThostFtdcBrokerTradingAlgosField* pBrokerTradingAlgos,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pBrokerTradingAlgos 回调 C# 参数 不能为 NULL
        CThostFtdcBrokerTradingAlgosField zero0 = {0};
        if (!pBrokerTradingAlgos) pBrokerTradingAlgos = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryBrokerTradingAlgos(pBrokerTradingAlgos,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQueryCFMMCTradingAccountToken(struct CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pQueryCFMMCTradingAccountToken 回调 C# 参数 不能为 NULL
        CThostFtdcQueryCFMMCTradingAccountTokenField zero0 = {0};
        if (!pQueryCFMMCTradingAccountToken) pQueryCFMMCTradingAccountToken = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnFromBankToFutureByBank(struct CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromBankToFutureByBank(pRspTransfer);
    }

    virtual void OnRtnFromFutureToBankByBank(struct CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromFutureToBankByBank(pRspTransfer);
    }

    virtual void OnRtnRepealFromBankToFutureByBank(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByBank(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByBank(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByBank(pRspRepeal);
    }

    virtual void OnRtnFromBankToFutureByFuture(struct CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromBankToFutureByFuture(pRspTransfer);
    }

    virtual void OnRtnFromFutureToBankByFuture(struct CThostFtdcRspTransferField* pRspTransfer)
    {
        //pRspTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcRspTransferField zero0 = {0};
        if (!pRspTransfer) pRspTransfer = &zero0;
        _callbacks.OnRtnFromFutureToBankByFuture(pRspTransfer);
    }

    virtual void OnRtnRepealFromBankToFutureByFutureManual(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByFutureManual(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByFutureManual(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByFutureManual(pRspRepeal);
    }

    virtual void OnRtnQueryBankBalanceByFuture(struct CThostFtdcNotifyQueryAccountField* pNotifyQueryAccount)
    {
        //pNotifyQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcNotifyQueryAccountField zero0 = {0};
        if (!pNotifyQueryAccount) pNotifyQueryAccount = &zero0;
        _callbacks.OnRtnQueryBankBalanceByFuture(pNotifyQueryAccount);
    }

    virtual void OnErrRtnBankToFutureByFuture(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnBankToFutureByFuture(pReqTransfer,pRspInfo);
    }

    virtual void OnErrRtnFutureToBankByFuture(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnFutureToBankByFuture(pReqTransfer,pRspInfo);
    }

    virtual void OnErrRtnRepealBankToFutureByFutureManual(struct CThostFtdcReqRepealField* pReqRepeal,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcReqRepealField zero0 = {0};
        if (!pReqRepeal) pReqRepeal = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnRepealBankToFutureByFutureManual(pReqRepeal,pRspInfo);
    }

    virtual void OnErrRtnRepealFutureToBankByFutureManual(struct CThostFtdcReqRepealField* pReqRepeal,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcReqRepealField zero0 = {0};
        if (!pReqRepeal) pReqRepeal = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnRepealFutureToBankByFutureManual(pReqRepeal,pRspInfo);
    }

    virtual void OnErrRtnQueryBankBalanceByFuture(struct CThostFtdcReqQueryAccountField* pReqQueryAccount,struct CThostFtdcRspInfoField* pRspInfo)
    {
        //pReqQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcReqQueryAccountField zero0 = {0};
        if (!pReqQueryAccount) pReqQueryAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnErrRtnQueryBankBalanceByFuture(pReqQueryAccount,pRspInfo);
    }

    virtual void OnRtnRepealFromBankToFutureByFuture(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromBankToFutureByFuture(pRspRepeal);
    }

    virtual void OnRtnRepealFromFutureToBankByFuture(struct CThostFtdcRspRepealField* pRspRepeal)
    {
        //pRspRepeal 回调 C# 参数 不能为 NULL
        CThostFtdcRspRepealField zero0 = {0};
        if (!pRspRepeal) pRspRepeal = &zero0;
        _callbacks.OnRtnRepealFromFutureToBankByFuture(pRspRepeal);
    }

    virtual void OnRspFromBankToFutureByFuture(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspFromBankToFutureByFuture(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspFromFutureToBankByFuture(struct CThostFtdcReqTransferField* pReqTransfer,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqTransfer 回调 C# 参数 不能为 NULL
        CThostFtdcReqTransferField zero0 = {0};
        if (!pReqTransfer) pReqTransfer = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspFromFutureToBankByFuture(pReqTransfer,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQueryBankAccountMoneyByFuture(struct CThostFtdcReqQueryAccountField* pReqQueryAccount,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pReqQueryAccount 回调 C# 参数 不能为 NULL
        CThostFtdcReqQueryAccountField zero0 = {0};
        if (!pReqQueryAccount) pReqQueryAccount = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQueryBankAccountMoneyByFuture(pReqQueryAccount,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRtnOpenAccountByBank(struct CThostFtdcOpenAccountField* pOpenAccount)
    {
        //pOpenAccount 回调 C# 参数 不能为 NULL
        CThostFtdcOpenAccountField zero0 = {0};
        if (!pOpenAccount) pOpenAccount = &zero0;
        _callbacks.OnRtnOpenAccountByBank(pOpenAccount);
    }

    virtual void OnRtnCancelAccountByBank(struct CThostFtdcCancelAccountField* pCancelAccount)
    {
        //pCancelAccount 回调 C# 参数 不能为 NULL
        CThostFtdcCancelAccountField zero0 = {0};
        if (!pCancelAccount) pCancelAccount = &zero0;
        _callbacks.OnRtnCancelAccountByBank(pCancelAccount);
    }

    virtual void OnRtnChangeAccountByBank(struct CThostFtdcChangeAccountField* pChangeAccount)
    {
        //pChangeAccount 回调 C# 参数 不能为 NULL
        CThostFtdcChangeAccountField zero0 = {0};
        if (!pChangeAccount) pChangeAccount = &zero0;
        _callbacks.OnRtnChangeAccountByBank(pChangeAccount);
    }

    virtual void OnRspQryClassifiedInstrument(struct CThostFtdcInstrumentField* pInstrument,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInstrument 回调 C# 参数 不能为 NULL
        CThostFtdcInstrumentField zero0 = {0};
        if (!pInstrument) pInstrument = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryClassifiedInstrument(pInstrument,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryCombPromotionParam(struct CThostFtdcCombPromotionParamField* pCombPromotionParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pCombPromotionParam 回调 C# 参数 不能为 NULL
        CThostFtdcCombPromotionParamField zero0 = {0};
        if (!pCombPromotionParam) pCombPromotionParam = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryCombPromotionParam(pCombPromotionParam,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRiskSettleInvstPosition(struct CThostFtdcRiskSettleInvstPositionField* pRiskSettleInvstPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRiskSettleInvstPosition 回调 C# 参数 不能为 NULL
        CThostFtdcRiskSettleInvstPositionField zero0 = {0};
        if (!pRiskSettleInvstPosition) pRiskSettleInvstPosition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRiskSettleInvstPosition(pRiskSettleInvstPosition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRiskSettleProductStatus(struct CThostFtdcRiskSettleProductStatusField* pRiskSettleProductStatus,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRiskSettleProductStatus 回调 C# 参数 不能为 NULL
        CThostFtdcRiskSettleProductStatusField zero0 = {0};
        if (!pRiskSettleProductStatus) pRiskSettleProductStatus = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRiskSettleProductStatus(pRiskSettleProductStatus,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMFutureParameter(struct CThostFtdcSPBMFutureParameterField* pSPBMFutureParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMFutureParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMFutureParameterField zero0 = {0};
        if (!pSPBMFutureParameter) pSPBMFutureParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMFutureParameter(pSPBMFutureParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMOptionParameter(struct CThostFtdcSPBMOptionParameterField* pSPBMOptionParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMOptionParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMOptionParameterField zero0 = {0};
        if (!pSPBMOptionParameter) pSPBMOptionParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMOptionParameter(pSPBMOptionParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMIntraParameter(struct CThostFtdcSPBMIntraParameterField* pSPBMIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMIntraParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMIntraParameterField zero0 = {0};
        if (!pSPBMIntraParameter) pSPBMIntraParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMIntraParameter(pSPBMIntraParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMInterParameter(struct CThostFtdcSPBMInterParameterField* pSPBMInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMInterParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMInterParameterField zero0 = {0};
        if (!pSPBMInterParameter) pSPBMInterParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMInterParameter(pSPBMInterParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMPortfDefinition(struct CThostFtdcSPBMPortfDefinitionField* pSPBMPortfDefinition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMPortfDefinition 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMPortfDefinitionField zero0 = {0};
        if (!pSPBMPortfDefinition) pSPBMPortfDefinition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMPortfDefinition(pSPBMPortfDefinition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMInvestorPortfDef(struct CThostFtdcSPBMInvestorPortfDefField* pSPBMInvestorPortfDef,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMInvestorPortfDef 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMInvestorPortfDefField zero0 = {0};
        if (!pSPBMInvestorPortfDef) pSPBMInvestorPortfDef = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMInvestorPortfDef(pSPBMInvestorPortfDef,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorPortfMarginRatio(struct CThostFtdcInvestorPortfMarginRatioField* pInvestorPortfMarginRatio,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorPortfMarginRatio 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorPortfMarginRatioField zero0 = {0};
        if (!pInvestorPortfMarginRatio) pInvestorPortfMarginRatio = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorPortfMarginRatio(pInvestorPortfMarginRatio,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProdSPBMDetail(struct CThostFtdcInvestorProdSPBMDetailField* pInvestorProdSPBMDetail,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProdSPBMDetail 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProdSPBMDetailField zero0 = {0};
        if (!pInvestorProdSPBMDetail) pInvestorProdSPBMDetail = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProdSPBMDetail(pInvestorProdSPBMDetail,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorCommoditySPMMMargin(struct CThostFtdcInvestorCommoditySPMMMarginField* pInvestorCommoditySPMMMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorCommoditySPMMMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorCommoditySPMMMarginField zero0 = {0};
        if (!pInvestorCommoditySPMMMargin) pInvestorCommoditySPMMMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorCommoditySPMMMargin(pInvestorCommoditySPMMMargin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorCommodityGroupSPMMMargin(struct CThostFtdcInvestorCommodityGroupSPMMMarginField* pInvestorCommodityGroupSPMMMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorCommodityGroupSPMMMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorCommodityGroupSPMMMarginField zero0 = {0};
        if (!pInvestorCommodityGroupSPMMMargin) pInvestorCommodityGroupSPMMMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorCommodityGroupSPMMMargin(pInvestorCommodityGroupSPMMMargin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPMMInstParam(struct CThostFtdcSPMMInstParamField* pSPMMInstParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPMMInstParam 回调 C# 参数 不能为 NULL
        CThostFtdcSPMMInstParamField zero0 = {0};
        if (!pSPMMInstParam) pSPMMInstParam = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPMMInstParam(pSPMMInstParam,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPMMProductParam(struct CThostFtdcSPMMProductParamField* pSPMMProductParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPMMProductParam 回调 C# 参数 不能为 NULL
        CThostFtdcSPMMProductParamField zero0 = {0};
        if (!pSPMMProductParam) pSPMMProductParam = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPMMProductParam(pSPMMProductParam,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQrySPBMAddOnInterParameter(struct CThostFtdcSPBMAddOnInterParameterField* pSPBMAddOnInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pSPBMAddOnInterParameter 回调 C# 参数 不能为 NULL
        CThostFtdcSPBMAddOnInterParameterField zero0 = {0};
        if (!pSPBMAddOnInterParameter) pSPBMAddOnInterParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQrySPBMAddOnInterParameter(pSPBMAddOnInterParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSCombProductInfo(struct CThostFtdcRCAMSCombProductInfoField* pRCAMSCombProductInfo,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSCombProductInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSCombProductInfoField zero0 = {0};
        if (!pRCAMSCombProductInfo) pRCAMSCombProductInfo = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSCombProductInfo(pRCAMSCombProductInfo,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSInstrParameter(struct CThostFtdcRCAMSInstrParameterField* pRCAMSInstrParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSInstrParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSInstrParameterField zero0 = {0};
        if (!pRCAMSInstrParameter) pRCAMSInstrParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSInstrParameter(pRCAMSInstrParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSIntraParameter(struct CThostFtdcRCAMSIntraParameterField* pRCAMSIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSIntraParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSIntraParameterField zero0 = {0};
        if (!pRCAMSIntraParameter) pRCAMSIntraParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSIntraParameter(pRCAMSIntraParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSInterParameter(struct CThostFtdcRCAMSInterParameterField* pRCAMSInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSInterParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSInterParameterField zero0 = {0};
        if (!pRCAMSInterParameter) pRCAMSInterParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSInterParameter(pRCAMSInterParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSShortOptAdjustParam(struct CThostFtdcRCAMSShortOptAdjustParamField* pRCAMSShortOptAdjustParam,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSShortOptAdjustParam 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSShortOptAdjustParamField zero0 = {0};
        if (!pRCAMSShortOptAdjustParam) pRCAMSShortOptAdjustParam = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSShortOptAdjustParam(pRCAMSShortOptAdjustParam,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRCAMSInvestorCombPosition(struct CThostFtdcRCAMSInvestorCombPositionField* pRCAMSInvestorCombPosition,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRCAMSInvestorCombPosition 回调 C# 参数 不能为 NULL
        CThostFtdcRCAMSInvestorCombPositionField zero0 = {0};
        if (!pRCAMSInvestorCombPosition) pRCAMSInvestorCombPosition = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRCAMSInvestorCombPosition(pRCAMSInvestorCombPosition,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProdRCAMSMargin(struct CThostFtdcInvestorProdRCAMSMarginField* pInvestorProdRCAMSMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProdRCAMSMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProdRCAMSMarginField zero0 = {0};
        if (!pInvestorProdRCAMSMargin) pInvestorProdRCAMSMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProdRCAMSMargin(pInvestorProdRCAMSMargin,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRULEInstrParameter(struct CThostFtdcRULEInstrParameterField* pRULEInstrParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRULEInstrParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRULEInstrParameterField zero0 = {0};
        if (!pRULEInstrParameter) pRULEInstrParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRULEInstrParameter(pRULEInstrParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRULEIntraParameter(struct CThostFtdcRULEIntraParameterField* pRULEIntraParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRULEIntraParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRULEIntraParameterField zero0 = {0};
        if (!pRULEIntraParameter) pRULEIntraParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRULEIntraParameter(pRULEIntraParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryRULEInterParameter(struct CThostFtdcRULEInterParameterField* pRULEInterParameter,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pRULEInterParameter 回调 C# 参数 不能为 NULL
        CThostFtdcRULEInterParameterField zero0 = {0};
        if (!pRULEInterParameter) pRULEInterParameter = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryRULEInterParameter(pRULEInterParameter,pRspInfo,nRequestID,bIsLast);
    }

    virtual void OnRspQryInvestorProdRULEMargin(struct CThostFtdcInvestorProdRULEMarginField* pInvestorProdRULEMargin,struct CThostFtdcRspInfoField* pRspInfo,int nRequestID,bool bIsLast)
    {
        //pInvestorProdRULEMargin 回调 C# 参数 不能为 NULL
        CThostFtdcInvestorProdRULEMarginField zero0 = {0};
        if (!pInvestorProdRULEMargin) pInvestorProdRULEMargin = &zero0;
        //pRspInfo 回调 C# 参数 不能为 NULL
        CThostFtdcRspInfoField zero1 = {0};
        if (!pRspInfo) pRspInfo = &zero1;
        _callbacks.OnRspQryInvestorProdRULEMargin(pInvestorProdRULEMargin,pRspInfo,nRequestID,bIsLast);
    }

};
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcTraderSpi_New(const struct CTPSharp_CThostFtdcTraderSpi* callbacks)
{
    return new CThostFtdcTraderSpi_Ex(callbacks);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderSpi_Delete(void* spi)
{
    delete static_cast<CThostFtdcTraderSpi_Ex*>(spi);
}
extern "C"
CTPSHARP_EXPORT void* CTPSHARP_STDCALL CThostFtdcTraderApi_Create(const char* pszFlowPath)
{
    return CThostFtdcTraderApi::CreateFtdcTraderApi(pszFlowPath);
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcTraderApi_GetApiVersion()
{
    return CThostFtdcTraderApi::GetApiVersion();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_Release(void* api)
{
    static_cast<CThostFtdcTraderApi*>(api)->Release();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_Init(void* api)
{
    static_cast<CThostFtdcTraderApi*>(api)->Init();
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_Join(void* api)
{
    return static_cast<CThostFtdcTraderApi*>(api)->Join();
}
extern "C"
CTPSHARP_EXPORT const char* CTPSHARP_STDCALL CThostFtdcTraderApi_GetTradingDay(void* api)
{
    return static_cast<CThostFtdcTraderApi*>(api)->GetTradingDay();
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterFront(void* api, char* pszFrontAddress)
{
    static_cast<CThostFtdcTraderApi*>(api)->RegisterFront(pszFrontAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterNameServer(void* api, char* pszNsAddress)
{
    static_cast<CThostFtdcTraderApi*>(api)->RegisterNameServer(pszNsAddress);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterFensUserInfo(void* api, struct CThostFtdcFensUserInfoField* pFensUserInfo)
{
    static_cast<CThostFtdcTraderApi*>(api)->RegisterFensUserInfo(pFensUserInfo);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterSpi(void* api, void* pSpi)
{
    static_cast<CThostFtdcTraderApi*>(api)->RegisterSpi(static_cast<CThostFtdcTraderSpi*>(pSpi));
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_SubscribePrivateTopic(void* api, enum THOST_TE_RESUME_TYPE nResumeType)
{
    static_cast<CThostFtdcTraderApi*>(api)->SubscribePrivateTopic(nResumeType);
}
extern "C"
CTPSHARP_EXPORT void CTPSHARP_STDCALL CThostFtdcTraderApi_SubscribePublicTopic(void* api, enum THOST_TE_RESUME_TYPE nResumeType)
{
    static_cast<CThostFtdcTraderApi*>(api)->SubscribePublicTopic(nResumeType);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqAuthenticate(void* api, struct CThostFtdcReqAuthenticateField* pReqAuthenticateField,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqAuthenticate(pReqAuthenticateField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_RegisterUserSystemInfo(void* api, struct CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    return static_cast<CThostFtdcTraderApi*>(api)->RegisterUserSystemInfo(pUserSystemInfo);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_SubmitUserSystemInfo(void* api, struct CThostFtdcUserSystemInfoField* pUserSystemInfo)
{
    return static_cast<CThostFtdcTraderApi*>(api)->SubmitUserSystemInfo(pUserSystemInfo);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLogin(void* api, struct CThostFtdcReqUserLoginField* pReqUserLoginField,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserLogin(pReqUserLoginField,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLogout(void* api, struct CThostFtdcUserLogoutField* pUserLogout,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserLogout(pUserLogout,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserPasswordUpdate(void* api, struct CThostFtdcUserPasswordUpdateField* pUserPasswordUpdate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserPasswordUpdate(pUserPasswordUpdate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqTradingAccountPasswordUpdate(void* api, struct CThostFtdcTradingAccountPasswordUpdateField* pTradingAccountPasswordUpdate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqTradingAccountPasswordUpdate(pTradingAccountPasswordUpdate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserAuthMethod(void* api, struct CThostFtdcReqUserAuthMethodField* pReqUserAuthMethod,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserAuthMethod(pReqUserAuthMethod,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqGenUserCaptcha(void* api, struct CThostFtdcReqGenUserCaptchaField* pReqGenUserCaptcha,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqGenUserCaptcha(pReqGenUserCaptcha,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqGenUserText(void* api, struct CThostFtdcReqGenUserTextField* pReqGenUserText,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqGenUserText(pReqGenUserText,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithCaptcha(void* api, struct CThostFtdcReqUserLoginWithCaptchaField* pReqUserLoginWithCaptcha,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserLoginWithCaptcha(pReqUserLoginWithCaptcha,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithText(void* api, struct CThostFtdcReqUserLoginWithTextField* pReqUserLoginWithText,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserLoginWithText(pReqUserLoginWithText,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqUserLoginWithOTP(void* api, struct CThostFtdcReqUserLoginWithOTPField* pReqUserLoginWithOTP,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqUserLoginWithOTP(pReqUserLoginWithOTP,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOrderInsert(void* api, struct CThostFtdcInputOrderField* pInputOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqOrderInsert(pInputOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqParkedOrderInsert(void* api, struct CThostFtdcParkedOrderField* pParkedOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqParkedOrderInsert(pParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqParkedOrderAction(void* api, struct CThostFtdcParkedOrderActionField* pParkedOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqParkedOrderAction(pParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOrderAction(void* api, struct CThostFtdcInputOrderActionField* pInputOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqOrderAction(pInputOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMaxOrderVolume(void* api, struct CThostFtdcQryMaxOrderVolumeField* pQryMaxOrderVolume,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryMaxOrderVolume(pQryMaxOrderVolume,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqSettlementInfoConfirm(void* api, struct CThostFtdcSettlementInfoConfirmField* pSettlementInfoConfirm,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqSettlementInfoConfirm(pSettlementInfoConfirm,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqRemoveParkedOrder(void* api, struct CThostFtdcRemoveParkedOrderField* pRemoveParkedOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqRemoveParkedOrder(pRemoveParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqRemoveParkedOrderAction(void* api, struct CThostFtdcRemoveParkedOrderActionField* pRemoveParkedOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqRemoveParkedOrderAction(pRemoveParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqExecOrderInsert(void* api, struct CThostFtdcInputExecOrderField* pInputExecOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqExecOrderInsert(pInputExecOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqExecOrderAction(void* api, struct CThostFtdcInputExecOrderActionField* pInputExecOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqExecOrderAction(pInputExecOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqForQuoteInsert(void* api, struct CThostFtdcInputForQuoteField* pInputForQuote,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqForQuoteInsert(pInputForQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQuoteInsert(void* api, struct CThostFtdcInputQuoteField* pInputQuote,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQuoteInsert(pInputQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQuoteAction(void* api, struct CThostFtdcInputQuoteActionField* pInputQuoteAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQuoteAction(pInputQuoteAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqBatchOrderAction(void* api, struct CThostFtdcInputBatchOrderActionField* pInputBatchOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqBatchOrderAction(pInputBatchOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOptionSelfCloseInsert(void* api, struct CThostFtdcInputOptionSelfCloseField* pInputOptionSelfClose,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqOptionSelfCloseInsert(pInputOptionSelfClose,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqOptionSelfCloseAction(void* api, struct CThostFtdcInputOptionSelfCloseActionField* pInputOptionSelfCloseAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqOptionSelfCloseAction(pInputOptionSelfCloseAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqCombActionInsert(void* api, struct CThostFtdcInputCombActionField* pInputCombAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqCombActionInsert(pInputCombAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOrder(void* api, struct CThostFtdcQryOrderField* pQryOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryOrder(pQryOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTrade(void* api, struct CThostFtdcQryTradeField* pQryTrade,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTrade(pQryTrade,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPosition(void* api, struct CThostFtdcQryInvestorPositionField* pQryInvestorPosition,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorPosition(pQryInvestorPosition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingAccount(void* api, struct CThostFtdcQryTradingAccountField* pQryTradingAccount,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTradingAccount(pQryTradingAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestor(void* api, struct CThostFtdcQryInvestorField* pQryInvestor,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestor(pQryInvestor,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingCode(void* api, struct CThostFtdcQryTradingCodeField* pQryTradingCode,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTradingCode(pQryTradingCode,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentMarginRate(void* api, struct CThostFtdcQryInstrumentMarginRateField* pQryInstrumentMarginRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInstrumentMarginRate(pQryInstrumentMarginRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentCommissionRate(void* api, struct CThostFtdcQryInstrumentCommissionRateField* pQryInstrumentCommissionRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInstrumentCommissionRate(pQryInstrumentCommissionRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchange(void* api, struct CThostFtdcQryExchangeField* pQryExchange,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryExchange(pQryExchange,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProduct(void* api, struct CThostFtdcQryProductField* pQryProduct,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryProduct(pQryProduct,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrument(void* api, struct CThostFtdcQryInstrumentField* pQryInstrument,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInstrument(pQryInstrument,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryDepthMarketData(void* api, struct CThostFtdcQryDepthMarketDataField* pQryDepthMarketData,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryDepthMarketData(pQryDepthMarketData,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTraderOffer(void* api, struct CThostFtdcQryTraderOfferField* pQryTraderOffer,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTraderOffer(pQryTraderOffer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySettlementInfo(void* api, struct CThostFtdcQrySettlementInfoField* pQrySettlementInfo,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySettlementInfo(pQrySettlementInfo,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTransferBank(void* api, struct CThostFtdcQryTransferBankField* pQryTransferBank,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTransferBank(pQryTransferBank,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPositionDetail(void* api, struct CThostFtdcQryInvestorPositionDetailField* pQryInvestorPositionDetail,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorPositionDetail(pQryInvestorPositionDetail,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryNotice(void* api, struct CThostFtdcQryNoticeField* pQryNotice,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryNotice(pQryNotice,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySettlementInfoConfirm(void* api, struct CThostFtdcQrySettlementInfoConfirmField* pQrySettlementInfoConfirm,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySettlementInfoConfirm(pQrySettlementInfoConfirm,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPositionCombineDetail(void* api, struct CThostFtdcQryInvestorPositionCombineDetailField* pQryInvestorPositionCombineDetail,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorPositionCombineDetail(pQryInvestorPositionCombineDetail,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCFMMCTradingAccountKey(void* api, struct CThostFtdcQryCFMMCTradingAccountKeyField* pQryCFMMCTradingAccountKey,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryCFMMCTradingAccountKey(pQryCFMMCTradingAccountKey,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryEWarrantOffset(void* api, struct CThostFtdcQryEWarrantOffsetField* pQryEWarrantOffset,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryEWarrantOffset(pQryEWarrantOffset,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProductGroupMargin(void* api, struct CThostFtdcQryInvestorProductGroupMarginField* pQryInvestorProductGroupMargin,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorProductGroupMargin(pQryInvestorProductGroupMargin,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeMarginRate(void* api, struct CThostFtdcQryExchangeMarginRateField* pQryExchangeMarginRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryExchangeMarginRate(pQryExchangeMarginRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeMarginRateAdjust(void* api, struct CThostFtdcQryExchangeMarginRateAdjustField* pQryExchangeMarginRateAdjust,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryExchangeMarginRateAdjust(pQryExchangeMarginRateAdjust,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExchangeRate(void* api, struct CThostFtdcQryExchangeRateField* pQryExchangeRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryExchangeRate(pQryExchangeRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentACIDMap(void* api, struct CThostFtdcQrySecAgentACIDMapField* pQrySecAgentACIDMap,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySecAgentACIDMap(pQrySecAgentACIDMap,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProductExchRate(void* api, struct CThostFtdcQryProductExchRateField* pQryProductExchRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryProductExchRate(pQryProductExchRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryProductGroup(void* api, struct CThostFtdcQryProductGroupField* pQryProductGroup,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryProductGroup(pQryProductGroup,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMMInstrumentCommissionRate(void* api, struct CThostFtdcQryMMInstrumentCommissionRateField* pQryMMInstrumentCommissionRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryMMInstrumentCommissionRate(pQryMMInstrumentCommissionRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryMMOptionInstrCommRate(void* api, struct CThostFtdcQryMMOptionInstrCommRateField* pQryMMOptionInstrCommRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryMMOptionInstrCommRate(pQryMMOptionInstrCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInstrumentOrderCommRate(void* api, struct CThostFtdcQryInstrumentOrderCommRateField* pQryInstrumentOrderCommRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInstrumentOrderCommRate(pQryInstrumentOrderCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentTradingAccount(void* api, struct CThostFtdcQryTradingAccountField* pQryTradingAccount,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySecAgentTradingAccount(pQryTradingAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentCheckMode(void* api, struct CThostFtdcQrySecAgentCheckModeField* pQrySecAgentCheckMode,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySecAgentCheckMode(pQrySecAgentCheckMode,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySecAgentTradeInfo(void* api, struct CThostFtdcQrySecAgentTradeInfoField* pQrySecAgentTradeInfo,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySecAgentTradeInfo(pQrySecAgentTradeInfo,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionInstrTradeCost(void* api, struct CThostFtdcQryOptionInstrTradeCostField* pQryOptionInstrTradeCost,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryOptionInstrTradeCost(pQryOptionInstrTradeCost,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionInstrCommRate(void* api, struct CThostFtdcQryOptionInstrCommRateField* pQryOptionInstrCommRate,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryOptionInstrCommRate(pQryOptionInstrCommRate,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryExecOrder(void* api, struct CThostFtdcQryExecOrderField* pQryExecOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryExecOrder(pQryExecOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryForQuote(void* api, struct CThostFtdcQryForQuoteField* pQryForQuote,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryForQuote(pQryForQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryQuote(void* api, struct CThostFtdcQryQuoteField* pQryQuote,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryQuote(pQryQuote,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryOptionSelfClose(void* api, struct CThostFtdcQryOptionSelfCloseField* pQryOptionSelfClose,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryOptionSelfClose(pQryOptionSelfClose,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestUnit(void* api, struct CThostFtdcQryInvestUnitField* pQryInvestUnit,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestUnit(pQryInvestUnit,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombInstrumentGuard(void* api, struct CThostFtdcQryCombInstrumentGuardField* pQryCombInstrumentGuard,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryCombInstrumentGuard(pQryCombInstrumentGuard,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombAction(void* api, struct CThostFtdcQryCombActionField* pQryCombAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryCombAction(pQryCombAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTransferSerial(void* api, struct CThostFtdcQryTransferSerialField* pQryTransferSerial,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTransferSerial(pQryTransferSerial,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryAccountregister(void* api, struct CThostFtdcQryAccountregisterField* pQryAccountregister,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryAccountregister(pQryAccountregister,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryContractBank(void* api, struct CThostFtdcQryContractBankField* pQryContractBank,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryContractBank(pQryContractBank,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryParkedOrder(void* api, struct CThostFtdcQryParkedOrderField* pQryParkedOrder,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryParkedOrder(pQryParkedOrder,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryParkedOrderAction(void* api, struct CThostFtdcQryParkedOrderActionField* pQryParkedOrderAction,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryParkedOrderAction(pQryParkedOrderAction,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryTradingNotice(void* api, struct CThostFtdcQryTradingNoticeField* pQryTradingNotice,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryTradingNotice(pQryTradingNotice,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryBrokerTradingParams(void* api, struct CThostFtdcQryBrokerTradingParamsField* pQryBrokerTradingParams,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryBrokerTradingParams(pQryBrokerTradingParams,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryBrokerTradingAlgos(void* api, struct CThostFtdcQryBrokerTradingAlgosField* pQryBrokerTradingAlgos,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryBrokerTradingAlgos(pQryBrokerTradingAlgos,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQueryCFMMCTradingAccountToken(void* api, struct CThostFtdcQueryCFMMCTradingAccountTokenField* pQueryCFMMCTradingAccountToken,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQueryCFMMCTradingAccountToken(pQueryCFMMCTradingAccountToken,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqFromBankToFutureByFuture(void* api, struct CThostFtdcReqTransferField* pReqTransfer,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqFromBankToFutureByFuture(pReqTransfer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqFromFutureToBankByFuture(void* api, struct CThostFtdcReqTransferField* pReqTransfer,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqFromFutureToBankByFuture(pReqTransfer,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQueryBankAccountMoneyByFuture(void* api, struct CThostFtdcReqQueryAccountField* pReqQueryAccount,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQueryBankAccountMoneyByFuture(pReqQueryAccount,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryClassifiedInstrument(void* api, struct CThostFtdcQryClassifiedInstrumentField* pQryClassifiedInstrument,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryClassifiedInstrument(pQryClassifiedInstrument,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryCombPromotionParam(void* api, struct CThostFtdcQryCombPromotionParamField* pQryCombPromotionParam,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryCombPromotionParam(pQryCombPromotionParam,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRiskSettleInvstPosition(void* api, struct CThostFtdcQryRiskSettleInvstPositionField* pQryRiskSettleInvstPosition,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRiskSettleInvstPosition(pQryRiskSettleInvstPosition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRiskSettleProductStatus(void* api, struct CThostFtdcQryRiskSettleProductStatusField* pQryRiskSettleProductStatus,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRiskSettleProductStatus(pQryRiskSettleProductStatus,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMFutureParameter(void* api, struct CThostFtdcQrySPBMFutureParameterField* pQrySPBMFutureParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMFutureParameter(pQrySPBMFutureParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMOptionParameter(void* api, struct CThostFtdcQrySPBMOptionParameterField* pQrySPBMOptionParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMOptionParameter(pQrySPBMOptionParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMIntraParameter(void* api, struct CThostFtdcQrySPBMIntraParameterField* pQrySPBMIntraParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMIntraParameter(pQrySPBMIntraParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMInterParameter(void* api, struct CThostFtdcQrySPBMInterParameterField* pQrySPBMInterParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMInterParameter(pQrySPBMInterParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMPortfDefinition(void* api, struct CThostFtdcQrySPBMPortfDefinitionField* pQrySPBMPortfDefinition,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMPortfDefinition(pQrySPBMPortfDefinition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMInvestorPortfDef(void* api, struct CThostFtdcQrySPBMInvestorPortfDefField* pQrySPBMInvestorPortfDef,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMInvestorPortfDef(pQrySPBMInvestorPortfDef,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorPortfMarginRatio(void* api, struct CThostFtdcQryInvestorPortfMarginRatioField* pQryInvestorPortfMarginRatio,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorPortfMarginRatio(pQryInvestorPortfMarginRatio,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProdSPBMDetail(void* api, struct CThostFtdcQryInvestorProdSPBMDetailField* pQryInvestorProdSPBMDetail,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorProdSPBMDetail(pQryInvestorProdSPBMDetail,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorCommoditySPMMMargin(void* api, struct CThostFtdcQryInvestorCommoditySPMMMarginField* pQryInvestorCommoditySPMMMargin,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorCommoditySPMMMargin(pQryInvestorCommoditySPMMMargin,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorCommodityGroupSPMMMargin(void* api, struct CThostFtdcQryInvestorCommodityGroupSPMMMarginField* pQryInvestorCommodityGroupSPMMMargin,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorCommodityGroupSPMMMargin(pQryInvestorCommodityGroupSPMMMargin,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPMMInstParam(void* api, struct CThostFtdcQrySPMMInstParamField* pQrySPMMInstParam,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPMMInstParam(pQrySPMMInstParam,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPMMProductParam(void* api, struct CThostFtdcQrySPMMProductParamField* pQrySPMMProductParam,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPMMProductParam(pQrySPMMProductParam,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQrySPBMAddOnInterParameter(void* api, struct CThostFtdcQrySPBMAddOnInterParameterField* pQrySPBMAddOnInterParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQrySPBMAddOnInterParameter(pQrySPBMAddOnInterParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSCombProductInfo(void* api, struct CThostFtdcQryRCAMSCombProductInfoField* pQryRCAMSCombProductInfo,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSCombProductInfo(pQryRCAMSCombProductInfo,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSInstrParameter(void* api, struct CThostFtdcQryRCAMSInstrParameterField* pQryRCAMSInstrParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSInstrParameter(pQryRCAMSInstrParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSIntraParameter(void* api, struct CThostFtdcQryRCAMSIntraParameterField* pQryRCAMSIntraParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSIntraParameter(pQryRCAMSIntraParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSInterParameter(void* api, struct CThostFtdcQryRCAMSInterParameterField* pQryRCAMSInterParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSInterParameter(pQryRCAMSInterParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSShortOptAdjustParam(void* api, struct CThostFtdcQryRCAMSShortOptAdjustParamField* pQryRCAMSShortOptAdjustParam,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSShortOptAdjustParam(pQryRCAMSShortOptAdjustParam,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRCAMSInvestorCombPosition(void* api, struct CThostFtdcQryRCAMSInvestorCombPositionField* pQryRCAMSInvestorCombPosition,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRCAMSInvestorCombPosition(pQryRCAMSInvestorCombPosition,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProdRCAMSMargin(void* api, struct CThostFtdcQryInvestorProdRCAMSMarginField* pQryInvestorProdRCAMSMargin,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorProdRCAMSMargin(pQryInvestorProdRCAMSMargin,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRULEInstrParameter(void* api, struct CThostFtdcQryRULEInstrParameterField* pQryRULEInstrParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRULEInstrParameter(pQryRULEInstrParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRULEIntraParameter(void* api, struct CThostFtdcQryRULEIntraParameterField* pQryRULEIntraParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRULEIntraParameter(pQryRULEIntraParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryRULEInterParameter(void* api, struct CThostFtdcQryRULEInterParameterField* pQryRULEInterParameter,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryRULEInterParameter(pQryRULEInterParameter,nRequestID);
}
extern "C"
CTPSHARP_EXPORT int CTPSHARP_STDCALL CThostFtdcTraderApi_ReqQryInvestorProdRULEMargin(void* api, struct CThostFtdcQryInvestorProdRULEMarginField* pQryInvestorProdRULEMargin,int nRequestID)
{
    return static_cast<CThostFtdcTraderApi*>(api)->ReqQryInvestorProdRULEMargin(pQryInvestorProdRULEMargin,nRequestID);
}

