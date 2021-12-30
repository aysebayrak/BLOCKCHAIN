using BLOCKCHAIN.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace BLOCKCHAIN.Controllers
{
    public class RegisterController : Controller
    {
       
        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> RegisterFun(Register register)
        {
            var values = new Dictionary<string, string>
            {
                {"userName" , register.userName },
                {"userPassword" , register.userPassword }
            };

            var content = new FormUrlEncodedContent(values);


            return View();
        }
    }
}
