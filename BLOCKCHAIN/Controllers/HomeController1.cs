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
    public class HomeController1 : Controller
    {
        [Route("api/[controller]")]
        public IActionResult Index()
        {
            return View();
        
        }



        [HttpGet]
        public async Task<List<User>> Get()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync("http://localhost:");
                var data = JsonConvert.DeserializeObject<UserCollection>(response.Content.ReadAsStringAsync().Result);
                List<User> result = new List<User>();

                return result;

            }


        }
        [HttpGet("{userKey}")]
        public async Task<User> Get(string userKey)
        {
            using (var client = new HttpClient())
            {
                User result = new User();
                var response = await client.GetAsync("http://localhost:");
                var data = JsonConvert.DeserializeObject<UserCollection>(response.Content.ReadAsStringAsync().Result);
                result = data.Users.Where(U => U.userKey == userKey).First();

                return result;
            }


        }
    }
}
