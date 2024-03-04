using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Areas.AdminPanel.Controllers
{
    public class SiteManagementController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
