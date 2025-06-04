using NET___BioSentinela.Infrastructure.DTO.Request;
using Oracle.EntityFrameworkCore.Query.Internal;

namespace NET___BioSentinela.Domain.Entities
{
    public class Usuario : UserAudit
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Usuario(UsuarioRequest userRequest)
        {
            Id = Guid.NewGuid();
            Username = userRequest.Username;
            Password = userRequest.Password;
        }
    }
}
