using DevCard_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace DevCard_MVC.ViewComponents
{
    public class ProjectsViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            List<Project> _projects = new()
            {
                new Project(1, "تاکسی", "درخواست آنلاین تاکسی برای سفر های درون شهری", "project-1.jpg", "Atriya"),
                new Project(2, "زودفود", "درخواست آنلاین غذا برای سراسر کشور", "project-2.jpg", "ZoodFood"),
                new Project(3, "مدارس", "سیستم مدیریت یکپارچه مدارس", "project-3.jpg", "MONOP"),
                new Project(4, "فضاپیما", "برنامه مدیریت فضاپیما های ناسا", "project-4.jpg", "NASA"),
            };
            return View("_Projects" , _projects);
        }
    }
}
