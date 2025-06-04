using NET___BioSentinela.Infrastructure.DTO.Request;

namespace NET___BioSentinela.Domain.Entities
{
    public class Regiao : UserAudit
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Bioma { get; private set; }

        public Regiao(RegiaoRequest regiaoRequest)
        {
            Id = Guid.NewGuid();
            Nome = regiaoRequest.Nome;
            Bioma = regiaoRequest.Bioma;
        }
    }
}
