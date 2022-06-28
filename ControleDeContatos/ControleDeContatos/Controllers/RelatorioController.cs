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
            //if (!minDate.HasValue) minDate = new DateTime(DateTime.Now.Year, 1, 1);
            //if (!maxDate.HasValue) maxDate = DateTime.Now;

            //ViewData["minDate"] = minDate.Value.ToString("yyyy-MM-dd");
            //ViewData["maxDate"] = maxDate.Value.ToString("yyyy-MM-dd");

            var result = _relatorioService.FindByDate(minDate, maxDate);
            return View(result);
        }
        public IActionResult BuscarPorEstado(string uf)
        {
            var result = _relatorioService.FindByState(uf);
            return View(result);
        }

        public IActionResult BuscarPorNome(string nome)
        {
            var result = _relatorioService.FindByName(nome);
            return View(result);
        }

        public IActionResult BuscarPorNomeDaEmpresa(string nomeDaEmpresa)
        {
            var result = _relatorioService.FindByEnterpriseName(nomeDaEmpresa);
            return View(result);
        }
    }
}
