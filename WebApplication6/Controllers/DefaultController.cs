﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication6.Controllers
{
    public class DefaultController : Controller
    {
        public ActionResult Default()
        {
            ViewBag.View = "day la trang chu ";
            return View();
        }
    }
}