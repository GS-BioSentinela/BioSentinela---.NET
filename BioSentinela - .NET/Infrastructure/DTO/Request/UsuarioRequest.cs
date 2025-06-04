using System.ComponentModel.DataAnnotations;

namespace NET___BioSentinela.Infrastructure.DTO.Request
{
    public class UsuarioRequest
    {
        [Required(ErrorMessage = "Nome de úsuario é obrigatório")]
        public string Username { get; set; }
        [Required(ErrorMessage = "Senha é obrigatória")]
        public string Password { get; set; }
    }
}
