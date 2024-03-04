using Microsoft.AspNetCore.Mvc;

namespace YarenSuYavuz2.Controllers
{
    public class KasiyerTakip : Controller
    {
        public IActionResult KasiyerBilgileri()
        {
            return View("Kasiyer",param=parametre);
          
            
        }
    }
}
