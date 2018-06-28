using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using API_WorldCup.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace API_WorldCup.Controllers
{
    [Route("api/[controller]/[action]")]
    public class WorldCupController : Controller
    {
        // GET: api/<controller>
        [HttpGet]
        public IEnumerable<string> Get()
        {
            return new string[] { "http://localhost:62696/api/Values/Method", "http://localhost:62696/api/WorldCup/Method" };
        }

        // GET api/<controller>/GetPriceAsync
        //[HttpGet("coin={coin}")]
        [HttpGet]
        public async Task<IActionResult> GetWorldCupGamesAsync()
        {
            // string url = "https://www.mercadobitcoin.net/api/" + coin + "/ticker/";
            var apikey = "jE7yBJVRNAwdDesMgTzTXUUSx1It41Fq";
            var WorldCupId = "12";
            var hoje = "20180626";
            hoje = DateTime.Today.ToString("yyyyMMdd");
            string url = "https://api.foxsports.com/sportsdata/v1/soccer/wc/events.json?group="+ WorldCupId + "&date=" + hoje + "&enable=s&apikey=" + apikey;

            var ret = await GetData(url);
            //ret.coin = coin;
            return Json(ret);
        }

        

        private async Task<FoxResponse> GetData(string url)
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
    }
}
