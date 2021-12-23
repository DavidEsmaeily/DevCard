using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DevCard_MVC.Controllers
{
    public class TestController : Controller
    {
        public TestController()
        {
            
        }
        public IActionResult Index()
        {
            //return RedirectToAction("Contact", "Home");
            return new JsonResult(500);
        }
        
    }
}
