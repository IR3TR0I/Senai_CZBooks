using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Senai_CZBooksWebAPI.ViewModel
{
    //Modelo de Login
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe seu Email de Usuário!")]
        public String Email { get; set; }

        [Required(ErrorMessage = "Informe sua Senha de Usuário!")]
        public string Senha { get; set; }
    }
}
