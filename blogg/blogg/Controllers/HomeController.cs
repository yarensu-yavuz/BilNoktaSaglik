using blogg.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace blogg.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

     
       public IActionResult List()
    {   
        var urun = new Blog()
        {
            ID = 1

        };
        return View ("Productlist", urun);
    }
}