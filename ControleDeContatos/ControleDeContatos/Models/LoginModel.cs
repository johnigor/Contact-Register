using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace ControleDeContatos.Models
{
    public class LoginModel
    {

        [Required(ErrorMessage = "Digite o login!")]
        public string Login { get; set; }

        [Required(ErrorMessage = "Digite a senha!")]
        public string Senha { get; set; }
    }
}
