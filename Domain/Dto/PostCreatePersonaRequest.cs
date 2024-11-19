using Persona.Domain.Entities.TipoPersona;

namespace Persona.Domain.Dto
{
    public class PostCreatePersonaRequest
    {
      
        public string? Nombres { get; set; }
        public string? Apellidos { get; set; }
        public Guid TipoPersonaId { get; set; }
        public string? NumeroDocumento { get; set; }

    }
}
