﻿using Microsoft.AspNetCore.Mvc;

namespace FrontendBackend.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
