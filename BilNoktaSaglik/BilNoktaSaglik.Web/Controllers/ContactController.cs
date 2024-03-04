using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult ContactIndex()
        {
            return View();
        }
    }
}
