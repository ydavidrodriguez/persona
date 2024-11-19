namespace Persona.Domain.Entities.Persona
{
    public class Persona
    {
        public Guid IdPersona { get; set; }
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public TipoPersona.TipoPersona TipoPersona { get; set; }
        public Guid TipoPersonaId { get; set; }
        public string? NumeroDocumento { get; set; } 
    }
}
