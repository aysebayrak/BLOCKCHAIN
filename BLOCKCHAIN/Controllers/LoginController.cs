using BLOCKCHAIN.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class LoginController : Controller
    {

        [Route("")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginFun(Login login)
        {
            var values = new Dictionary<string, string>
            {
                {"userName" , login.userName },
                {"userPassword" , login.userPassword }
            };

            var content = new FormUrlEncodedContent(values);



            using (var client = new HttpClient())
            {
                var response = await client.PostAsync(Program.BASE_URL + "user", content);
                var token = response.Content.ReadAsStringAsync().Result;

                if (token == null)
                {
                    return Login();
                }
                else
                {
                    var res2 = await client.GetAsync(Program.BASE_URL + "market");
                    var market = JsonConvert.DeserializeObject<List<Market>>(res2.Content.ReadAsStringAsync().Result);
                  
                    return View(market);
                }
          
            }
        }
        [Route("satınal")]
        public ActionResult SatınAl()
        {
            return View();
        }





    }
}
