using ControleDeContatos.Data;
using ControleDeContatos.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ControleDeContatos.Repositorio
{
    public class ContatoRepositorio : IContatoRepositorio
    {
        private readonly BancoContext _bancoContext;
        public ContatoRepositorio(BancoContext bancoContext)
        {
            _bancoContext = bancoContext;
        }

        public ContatoModel BuscarPorId(int id)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Id == id);
        }

        public ContatoModel BuscarPorNome(string nome)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.Nome == nome);
        }

        public ContatoModel BuscarPorNomeDaEmpresa(string nomeDaEmpresa)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.NomeDaEmpresa == nomeDaEmpresa);
        }

        public ContatoModel BuscarPorUF(string uf)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.UF == uf);
        }

        public ContatoModel BuscarPorDataDeCadastro(DateTime dataCadastro)
        {
            return _bancoContext.Contatos.FirstOrDefault(x => x.DataCadastro == dataCadastro);
        }

        public List<ContatoModel> BuscarTodos()
        {
            return _bancoContext.Contatos.ToList();
        }

        public ContatoModel Adicionar(ContatoModel contato)
        {
            contato.DataCadastro = DateTime.Now;
            _bancoContext.Contatos.Add(contato);
            _bancoContext.SaveChanges();
            return contato;
        }

        public ContatoModel Atualizar(ContatoModel contato)
        {
            ContatoModel contatoDB = BuscarPorId(contato.Id);

            if (contatoDB == null) throw new Exception("Houve um erro na atualização do contato");

            contatoDB.Nome = contato.Nome;
            contatoDB.Email = contato.Email;
            contatoDB.Celular = contato.Celular;
            contatoDB.Telefone = contato.Telefone;
            contatoDB.NomeDaEmpresa = contato.NomeDaEmpresa;
            contatoDB.Cargo = contato.Cargo;
            contatoDB.CEP = contato.CEP;
            contatoDB.Logradouro = contato.Logradouro;
            contatoDB.Numero = contato.Numero;
            contatoDB.Complemento = contato.Complemento;
            contatoDB.Cidade = contato.Cidade;
            contatoDB.UF = contato.UF;
            contatoDB.Bairro = contato.Bairro;

            _bancoContext.Contatos.Update(contatoDB);
            _bancoContext.SaveChanges();

            return contatoDB;

        }

        public bool Apagar(int id)
        {
            ContatoModel contatoDB = BuscarPorId(id);

            if (contatoDB == null) throw new Exception("Houve um erro na deleção do contato");

            _bancoContext.Remove(contatoDB);
            _bancoContext.SaveChanges();

            return true;
        }
    }
}
