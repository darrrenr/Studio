﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class SecondController : Controller
    {
        // GET: Second
        public ActionResult HelloWorld()
        {
            ViewBag.Message = "Your hhhhhhhtion description page.";

            return View();
        }
    }
}