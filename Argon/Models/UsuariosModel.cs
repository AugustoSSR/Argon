using Argon.Enums;
using System.ComponentModel.DataAnnotations;

namespace Argon.Models
{
    public class UsuariosModel
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Digite o nome completo.")]
        public string Nome { get; set; }
        [Required(ErrorMessage = "Digite o login do usuario.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "Digite o e-mail do usuario.")]
        [EmailAddress(ErrorMessage = "O e-mail informando não é valido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "Digite o telefone de contato")]
        [Phone(ErrorMessage = "O celular informado está errado")]
        public string Telefone { get; set; }
        [Required(ErrorMessage = "Digite sua senha por favor.")]
        
        public string Senha { get; set; }
        public PerfilEnum Perfil { get; set; }
        public DateTime dataCadastro { get; set; }
        public DateTime? dataAlteracao { get; set; }
        public string nomeAlteracao { get; set; }

    }
}
