using Microsoft.AspNetCore.Mvc;

namespace hafta6mvc.Controllers
{
    public class loginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult GirisYap() //Eğer metodun adını Giris yapsaydım zaten Login View'ünde Giris.cshtml dosyası bulunduğu için oraya yönlenecekti,sıkıntı k almayacaktı lakin
                                        //fmetota farklı bir isim yazdığım için metot içinde yönlendirme yapmam gerekecek.
        {
            return View("Giris");

        }
        public RedirectResult Adresegit()
        {
            return Redirect("http://google.com");
        }


         public IActionResult BilgileriTasi()
        {
            string[] bilgiler = new string[] { "Güncel Sarıman", "Muğla Sıtkı Koçman", "şifre" };
            return View("GirisYap", bilgiler);/* bunu giriş yap fonkstioynu sayesinde Giris viewuine a yönlendirdik*/
        }
        public IActionResult LoginBilgileri()
        {
            Models.Kullanici entity = new Models.Kullanici();
            entity.KullaniciAdi = "Guncel";
            entity.kullaniciSifre = "1234";
            entity.kullanicieposta = "guncelsariman@mu.edu.tr";
            entity.kullaniciadres = "MSKU";
            var bilgi = entity;
        }
    }
}