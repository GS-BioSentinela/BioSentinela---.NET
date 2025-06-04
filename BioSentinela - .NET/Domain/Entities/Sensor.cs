using System.Security.Cryptography.Pkcs;

namespace NET___BioSentinela.Domain.Entities
{
    public class Sensor : SensorAudit
    {
        public Guid Id { get; private set; }
        public string Tipo { get; private set; }
        public string Localizacao { get; private set; }

        public Guid RegiaoId { get; private set; }
        public Regiao Regiao { get; private set; }
        
        public List<Alerta> Alertas { get; private set; }      

        public Sensor() { }
    }
}
