﻿using Microsoft.AspNetCore.Mvc;

namespace EasyCacheUI.Controllers
{
    public class MyProfileController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
