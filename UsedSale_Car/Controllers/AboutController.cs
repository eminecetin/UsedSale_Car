﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace UsedSale_Car.Controllers
{
    public class AboutController : Controller
    {
        // GET: About
        public ActionResult AIndex()
        {
            return View();
        }
        public ActionResult AboutDetail()
        {
            return View();
        }

    }
}