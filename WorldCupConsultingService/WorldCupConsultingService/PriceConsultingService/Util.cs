using System;
using System.Net.Http;
using System.Threading.Tasks;
using WorldCupConsultingServiceVO.Models;

namespace PriceConsultingServiceBLL
{
    class Util
    {

        public async Task<FoxResponse> GetData(string url)
        {
            try
            {
                //We will make a GET request to a really cool website...

                //string baseUrl = "https://www.mercadobitcoin.net/api/BTC/ticker/";
                //The 'using' will help to prevent memory leaks.
                //Create a new instance of HttpClient
                using (HttpClient client = new HttpClient())

                //Setting up the response...         

                using (HttpResponseMessage res = await client.GetAsync(url))
                using (HttpContent content = res.Content)
                {
                    var data = await content.ReadAsAsync<FoxResponse>();
                    return data;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.WriteLine(ex.InnerException);
            }
            return null;
        }
    }
}
