﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace RecursoHumano_ProyectoFinal.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Matenimiento() {
            return View();
        }

        public ActionResult Procesos()
        {
            return View();
        }

        public ActionResult Informes()
        {
            return View();
        }
    }
}