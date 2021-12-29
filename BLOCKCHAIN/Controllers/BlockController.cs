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
    public class BlockController : Controller
    {



        [Route("block")]
        public async Task<IActionResult> Block()
        {
            using (var client = new HttpClient())
            {
                var response = await client.GetAsync(Program.BASE_URL + "block");
                var block = JsonConvert.DeserializeObject<List<Block>>(response.Content.ReadAsStringAsync().Result);

                return View(block);


            }
        }
    }

}
