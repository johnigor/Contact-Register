﻿using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Controllers
{
    public class RelatorioController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscarPorData()
        {
            return View();
        }
        public IActionResult BuscarPorEstado()
        {
            return View();
        }
        public IActionResult BuscarPorNome()
        {
            return View();
        }
        public IActionResult BuscarPorNomeDaEmpresa()
        {
            return View();
        }
    }
}
