using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class AppointmentController : Controller
    {
        public IActionResult AppointmentIndex()
        {
            return View();
        }
    }
}
