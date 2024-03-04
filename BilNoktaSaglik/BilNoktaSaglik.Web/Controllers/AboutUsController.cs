using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class AboutUsController : Controller
    {
        public IActionResult AboutIndex()
        {
            return View();
        }
    }
}
