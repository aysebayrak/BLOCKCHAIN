using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class MarketController : Controller
    {
        public IActionResult Index()
        {
            

            return View();
        }
    }
}
