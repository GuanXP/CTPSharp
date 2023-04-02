using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Example
{
    internal class Config
    {
        public string User { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
        public string Broker { get; set; } = string.Empty;
        public string DataServer { get; set; } = string.Empty;
        public string TradeServer { get; set; } = string.Empty;
        public string AuthCode { get; set; } = string.Empty;
        public string AppId { get; set; } = string.Empty;
        public string ProductInfo { get; set; } = string.Empty;
    }
}
