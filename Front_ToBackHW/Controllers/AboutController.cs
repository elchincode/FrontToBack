using Front_ToBackHW.Models;
using Front_ToBackHW.ViewModels.About;
using Microsoft.AspNetCore.Mvc;

namespace Front_ToBackHW.Controllers
{
    public class AboutController : Controller
    {
        public IActionResult Index()
        {
            var ourPart = new List<Our>
             {
                 new Our {Id = 1, Title="Our Vision" , Description="Incididunt ut labore et dolore magna aliqua. Quis ipsum suspendisse commodo viverra.", PhotoPath="bxs-bulb"},
                 new Our {Id = 2, Title="Our Mission" , Description="Eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam quis.", PhotoPath="bx-revision"},
                 new Our {Id = 3, Title="Our Goal" , Description="Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor.", PhotoPath="bxs-select-multiple"}
             };

            ViewBag.WorksTitle = "bx-revision";

            var our = new AboutIndexVM
            {
                Ours = ourPart
            };
            return View(our);
        }
    }
}
