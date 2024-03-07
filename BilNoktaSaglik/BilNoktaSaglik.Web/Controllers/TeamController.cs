using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class TeamController : Controller
    {
        public IActionResult TeamIndex()
        {
            return View();
        }
    }
}
