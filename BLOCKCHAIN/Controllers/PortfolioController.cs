using BLOCKCHAIN.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class PortfolioController : Controller
    {

        [Route("portfolio")]
        public IActionResult Portfolio()
        {
            return View();
        }

      
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Program.BASE_URL + "portfolio");
                var portfolio = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);

                return View(portfolio);


            }
        }
    }
}
