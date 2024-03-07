using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class BlogController : Controller
    {
        public IActionResult BlogIndex()
        {
            return View();
        }
    }
}
