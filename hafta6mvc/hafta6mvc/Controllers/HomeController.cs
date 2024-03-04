using hafta6mvc.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace hafta6mvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View("Gizlilik");
            //Bu parametreyi koydğumuz zaman Controller Views'de aynı adlı bir sayfa görmek istiyor.Bu parametreyi koymasak privacyden bekleyecekti
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}