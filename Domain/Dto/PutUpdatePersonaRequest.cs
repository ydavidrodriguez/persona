namespace Persona.Domain.Dto
{
    public class PutUpdatePersonaRequest
    {
        public Guid IdPersona { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public Guid TipoPersonaId { get; set; }
        public string? NumeroDocumento { get; set; }

    }
}
