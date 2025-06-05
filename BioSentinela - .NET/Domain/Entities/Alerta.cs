using NET___BioSentinela.Infrastructure.DTO.Request;

namespace NET___BioSentinela.Domain.Entities
{
    public class Alerta : SensorAudit
    {
        public Guid Id { get; private set; }
        public string Tipo { get; private set; }
        public string Mensagem { get; private set; }

        public Guid SensorId { get; private set; }
        public Sensor Sensor { get; private set; }

        public Alerta()
        {

        }

        public Alerta(AlertaRequest alertaRequest)
        {
            Id = Guid.NewGuid();
            Tipo = alertaRequest.Tipo;  
            Mensagem = alertaRequest.Mesagem;
        }
    }
}
