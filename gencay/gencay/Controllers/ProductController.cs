using Microsoft.AspNetCore.Mvc;

namespace gencay.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()

        {
            var products = new List<Product>
              new Product{ Id = 1, ProductName = "A Product", Quantity = 10 }
  

            };
    
     return View(products);
    }
}
