using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class SearchController : Controller
    {
        public IActionResult SearchIndex()
        {
            return View();
        }
    }
}
