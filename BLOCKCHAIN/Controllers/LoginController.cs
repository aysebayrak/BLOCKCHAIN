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
    public class LoginController : Controller
    {
     
        [Route("login")]
        [Route("login/index")]
        public IActionResult Login()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> LoginFun(Login login)
        {

            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Program.BASE_URL + "User?userName="+login.userName+ "&userPassword="+login.userPassword);
                var user = JsonConvert.DeserializeObject<List<User>>(response.Content.ReadAsStringAsync().Result);

                if (user == null)
                {
                    return Login();
                }
                else
                {
                    var res2 = await client.GetAsync(Program.BASE_URL + "Market");
                    var market = JsonConvert.DeserializeObject<List<Market>>(res2.Content.ReadAsStringAsync().Result);

                    return View(market);
                }
          
            }
        }



    }
}
