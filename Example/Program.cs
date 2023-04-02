namespace Example
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new Config()
            {
                User = "XXX",
                Password = "YYY",
                Broker = "9999",
                DataServer = "tcp://180.168.146.187:10211",
                TradeServer = "tcp://180.168.146.187:10201",
                AuthCode = "0000000000000000",
                AppId = "simnow_client_test",
                ProductInfo = "XXX"
            };

            var flowPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ctpExample");
            Directory.CreateDirectory(flowPath);
            using var mdClient = new MDClient(flowPath, config);
            mdClient.Connected += MdClientConnected;

            Console.WriteLine("开始连接行情服务器");
            mdClient.Init();
            Console.ReadLine();
        }

        private static void MdClientConnected(bool obj)
        {
            throw new NotImplementedException();
        }
    }
}