using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace YarenSuYavuzFinal.Controllers
{
    public class RestorantController : Controller
    {
        // GET: RestorantController
        public ActionResult Index()
        {
            return View();
        }

        // GET: RestorantController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: RestorantController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: RestorantController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestorantController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: RestorantController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: RestorantController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: RestorantController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
