﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FirstREST.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Register()
        {
            return View();
        }

        public ActionResult Logout() {
            return View();
        }

        public ActionResult WishList()
        {
            return View();
        }
        public ActionResult OrderHistory()
        {
            return View();
        }
        public ActionResult Single()
        {
            return View();
        }
        public ActionResult Checkout()
        {
            return View();
        }
    }
}
