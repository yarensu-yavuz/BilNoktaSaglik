using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult HomeIndex()
        {
            return View();
        }
     
        public IActionResult PageLayoutDesign()


        {
            return View();
        }
    }
}
