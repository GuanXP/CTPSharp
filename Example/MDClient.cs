using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using XP.CTPSharp;

namespace Example
{
    internal class MDClient : IDisposable
    {
        private readonly MdAPI _api;
        private readonly Config _config;
        internal event Action<Boolean>? Connected;
        public MDClient(string flowPath, Config config)
        {
            _config = config;
            _api = new(flowPath);
            _api.FrontConnected += OnFrontConnected;
            _api.FrontDisconnected += OnFrontDisconnected;
            _api.DepthMarketDataArrived += OnDepthMarketData;            
        }

        public void Init()
        {
            _api.RegisterFront(_config.DataServer);
            // 连接行情服务器;
            _api.Init();
        }

        private void OnDepthMarketData(CThostFtdcDepthMarketDataField obj)
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            _api.Dispose();
        }

        private void OnFrontConnected()
        {
            LogDebug("服务器连接成功");
            ReqLoginAsync();
        }

        private async void ReqLoginAsync()
        {
            var req = new CThostFtdcReqUserLoginField
            {
                UserID = _config.User,
                Password = _config.Password,
                BrokerID = _config.Broker
            };
            var resp = await _api.ReqUserLoginAsync(req);
            if (resp.NoError)
            {
                LogWarning("登录成功");
                Connected?.Invoke(true);
            }
            else
            {
                LogWarning($"登录失败，{resp.InfoField.ErrorMsg}, code={resp.InfoField.ErrorID}");
            }
        }

        private void OnFrontDisconnected(int nReason)
        {
            LogDebug($"连接断开，代码{nReason}");
            Connected?.Invoke(false);
        }

        private void LogDebug(string msg) 
        { 
            System.Diagnostics.Debug.WriteLine(msg);
        }

        private void LogWarning(string msg) 
        {
            System.Diagnostics.Debug.WriteLine(msg);
        }
    }
}
