using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Areas.AdminPanel.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult HomeIndex()
        {
            return View();
        }

        public IActionResult LayoutPageIndex()
        {
            return View();
        }

    }
}
