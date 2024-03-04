using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
     
        public IActionResult PageLayoutDesign()


        {
            return View();
        }
    }
}
