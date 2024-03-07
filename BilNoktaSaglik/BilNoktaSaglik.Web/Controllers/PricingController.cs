using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class PricingController : Controller
    {
        public IActionResult PricingIndex()
        {
            return View();
        }
    }
}
