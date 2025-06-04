namespace NET___BioSentinela.Domain.Entities
{
    public class Regiao : UserAudit
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string Bioma { get; private set; }

        public Regiao() { }
    }
}
