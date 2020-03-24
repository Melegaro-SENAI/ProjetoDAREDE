using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Senai.ProjetoDAREDE.Servico.ViewModel
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "Informe o e-mail")]
        [StringLength(100, MinimumLength = 4, ErrorMessage = "O e-mail deve ter no mínimo 4 caracteres")]
        public string Email { get; set; }

        [Required(ErrorMessage = "Informe a senha")]
        [StringLength(20, ErrorMessage = "Informe uma senha com mínimo de 8 e máximo de 20 caracteres")]
        public string Senha { get; set; }
    }
    
    
}
