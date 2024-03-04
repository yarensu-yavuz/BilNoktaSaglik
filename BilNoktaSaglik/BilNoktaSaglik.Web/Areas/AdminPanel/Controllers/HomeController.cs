using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult LayoutPageIndex()
        {
            return View();
        }

    }
}
