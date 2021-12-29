using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class PortfolioController : Controller
    {


        public IActionResult Portfolio()
        {
            return View();
        }
    }
}
