﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebTabanlıProgramlamaOdev2.Models.Entity;

namespace WebTabanlıProgramlamaOdev2.Controllers
{
    public class kategoriController : Controller
    {
        // GET: kategori
        public ActionResult Index()
        {
            return View();
        }
    }
}