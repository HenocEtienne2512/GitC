﻿using ProjetoPadawanTCC.Migrations;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ProjetoPadawanTCC.Controllers {
    public class HomeController : Controller {
        public ActionResult Index() {
            ViewBag.Title = "Home Page";

            return View();
        }
    }
}
