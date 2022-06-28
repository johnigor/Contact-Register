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
            try
            {
                var result = from obj in _context.Contatos select obj;

                if (minDate.HasValue) result = result.Where(x => x.DataCadastro >= minDate.Value);
                if (maxDate.HasValue) result = result.Where(x => x.DataCadastro <= maxDate.Value);

                return result
                    .OrderByDescending(x => x.DataCadastro)
                    .ToList();
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possível realizar a busca" + erro);
            }
        }

        public List<ContatoModel> FindByState(string uf)
        {
            var result = _context.Contatos.Where(x => x.UF.ToUpper() == uf.ToUpper()).ToList();
            return result;
        }

        public List<ContatoModel> FindByEnterpriseName(string nomeDaEmpresa)
        {
            try
            {
                var result = _context.Contatos.Where(x => x.NomeDaEmpresa.ToUpper().Contains(nomeDaEmpresa.ToUpper()));

                return result
                    .OrderByDescending(x => x.NomeDaEmpresa)
                    .ToList();
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possível realizar a busca" + erro);
            }
        }

        public List<ContatoModel> FindByName(string nome)
        {
            try
            {
                var result = _context.Contatos.Where(x => x.Nome.ToUpper().Contains(nome));

                return result
                    .OrderByDescending(x => x.Nome)
                    .ToList();
            }
            catch (Exception erro)
            {
                throw new Exception("Não foi possível realizar a busca" + erro);
            }
        }
    }
}
