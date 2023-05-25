using Front_ToBackHW.Models;
using Front_ToBackHW.ViewModels.Home;
using Microsoft.AspNetCore.Mvc;

namespace Front_ToBackHW.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var works = new List<Work>
        {
            new Work { Id = 1, Title="Social Media", Description = "SM Desctiption", PhotoPath="/assets/img/recent-work-01.jpg"},
            new Work { Id = 2, Title="Web Marketing", Description="WM Description", PhotoPath="/assets/img/recent-work-02.jpg"},
            new Work { Id = 3, Title="R & D", Description="R&D Description", PhotoPath="/assets/img/recent-work-03.jpg"}
        };

            //ViewBag.WorksTitle = "Recent Works";

            var model = new HomeIndexVM
            {
                WorkTitle = "Recent Works",
                Works = works
            };
            return View(model);
        }
    }
}
