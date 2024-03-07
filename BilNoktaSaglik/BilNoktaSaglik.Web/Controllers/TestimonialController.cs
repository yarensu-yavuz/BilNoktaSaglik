using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class TestimonialController : Controller
    {
        public IActionResult TestimonialIndex()
        {
            return View();
        }
    }
}
