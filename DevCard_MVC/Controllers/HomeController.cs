using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly List<Service> _services = new()
        {
            new Service(1 , "نقره ای"),
            new Service(2, "طلایی"),
            new Service(1 , "پلاتین"),
            new Service(1 , " الماس"),
            
        };

        public IActionResult Index()
        {
            return View();
        }


        [HttpGet]
        public IActionResult Contact()
        {
            var model = new Contact
            {
                Services = new SelectList(_services , "Id" , "Name")
            };
            return View(model);
        }

        [HttpPost]
        public IActionResult Contact(Contact model)
        {
            
            if (!ModelState.IsValid)
            {
                ViewBag.Error = "اطلاعات وارد شده صحیح نیست . لطفا دوباره تلاش کنید";
                return View(model);
            }
            
            model = new Contact()
            {
                Services = new SelectList(_services, "Id", "Name")
            };

            ViewBag.Success = "اطلاعات با موفقیت ارسال شد.";
            ModelState.Clear();
            return View(model);
        }



        



        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
