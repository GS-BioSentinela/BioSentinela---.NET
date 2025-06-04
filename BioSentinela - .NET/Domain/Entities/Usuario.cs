namespace NET___BioSentinela.Domain.Entities
{
    public class Usuario : UserAudit
    {
        public Guid Id { get; private set; }
        public string Username { get; private set; }
        public string Password { get; private set; }

        public Usuario() { }
    }
}
