﻿using Microsoft.AspNetCore.Mvc;

namespace BilNoktaSaglik.Web.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult ServicesIndex()
        {
            return View();
        }
    }
}
