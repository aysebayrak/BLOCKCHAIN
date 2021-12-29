using BLOCKCHAIN.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class HomeController1 : Controller
    {
        


        public async Task<IActionResult> Index(List<User> model)
        {
            return View(model);
        }


        
    }


    /*
         public class HomeController1 : Controller
    {
        


        [Route("")]
        [Route("home")]
        [Route("home/index")]
        public async Task<IActionResult> Index()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Program.BASE_URL + "User");
                var model = JsonConvert.DeserializeObject<List<User>>(
                    response.Content.ReadAsStringAsync().Result);
                return View(model);
            }
        }


        
    }
     
     */
}
