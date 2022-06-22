using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class ContatoModel
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [EmailAddress(ErrorMessage = "O e-mail informado não é válido!")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório!")]
        [Phone(ErrorMessage = "O celular informado não é válido")]
        public string Celular { get; set; }
    }
}
