using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class WalletController : Controller
    {

        
        [Route("wallet")]
      //  [Route("wallet/index")]
        public ActionResult Index()
        {
            return View();
        }
    }
}
