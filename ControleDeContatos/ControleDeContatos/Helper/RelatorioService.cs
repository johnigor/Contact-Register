using ControleDeContatos.Data;
using ControleDeContatos.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeContatos.Helper
{
    public class RelatorioService
    {
        private readonly BancoContext _context;

        public RelatorioService(BancoContext context)
        {
            _context = context;
        }
        public List<ContatoModel> FindByDate(DateTime? minDate, DateTime? maxDate)
        {
            var result = from obj in _context.Contatos select obj;
            if (minDate.HasValue)
            {
                result = result.Where(x => x.DataCadastro >= minDate.Value);
            }
            if (maxDate.HasValue)
            {
                result = result.Where(x => x.DataCadastro <= maxDate.Value);
            }
            return result
                .OrderByDescending(x => x.DataCadastro)
                .ToList();
        }

        public List<ContatoModel> FindByName(string nome)
        {
            var result = from obj in _context.Contatos select obj;

            result = result.Where(x => x.Nome.ToUpper() == nome.ToUpper());

            return result
                .OrderByDescending(x => x.Nome)
                .ToList();
        }
    }
}
