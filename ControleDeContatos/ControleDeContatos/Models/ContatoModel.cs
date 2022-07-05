using System;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Cargo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Display(Name = "Nome da Empresa")]
        public string NomeDaEmpresa { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string Celular { get; set; }
        public string Telefone { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido!")]
        [Display(Name = "E-mail")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string CEP { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Logradouro { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Display(Name = "Número")]
        public int Numero { get; set; }
                
        public string Complemento { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Bairro { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Cidade { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string UF { get; set; }

        [Display(Name = "Data de Cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
