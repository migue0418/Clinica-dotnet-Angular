﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Clinica.Controllers
{
    public class DiagnosticoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}