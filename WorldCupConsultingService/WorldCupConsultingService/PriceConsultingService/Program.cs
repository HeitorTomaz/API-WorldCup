using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using PriceConsultingServiceBLL;
using WorldCupConsultingServiceVO.Models;
using System.Globalization;

namespace WorldCupConsultingService
{
    class Program
    {
        private static NumberFormatInfo provider = new NumberFormatInfo();
        public static void Main(string[] args)
        {
            
            provider.NumberDecimalSeparator = ".";
            while (true)
            {
                try
                {
                    MainAsync(args).Wait();
                    Console.WriteLine("OK - "+ DateTime.Now +" \n");
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.WriteLine(ex.InnerException);
                }
                Thread.Sleep(60000);
            }
            return;
        }
        static async Task MainAsync(string[] args)
        {
            //DAO dao = new DAO();
            Util ut = new Util();

            string url = "http://localhost:62696/api/WorldCup/GetWorldCupGamesAsync";
            var ret = await ut.GetData(url);
            Console.WriteLine("Quantidade de retornos: " + ret.page.Count);
        }

    }
}
