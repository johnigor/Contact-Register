using ControleDeContatos.Helper;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleDeContatos.Controllers
{
    public class RelatorioController : Controller
    {
        private readonly RelatorioService _relatorioService;

        public RelatorioController(RelatorioService relatorioService)
        {
            _relatorioService = relatorioService;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult BuscarPorData(DateTime? minDate, DateTime? maxDate)
        {
            var result = _relatorioService.FindByDate(minDate, maxDate);
            return View(result);
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
