using System.ComponentModel.DataAnnotations;

namespace Argon.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Digite seu usuario")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite sua senha")]
        public string Senha { get; set; } 
    }
}
