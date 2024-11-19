namespace Persona.Domain.Entities.TipoPersona
{
    public class TipoPersona
    {
        public Guid IdTipoPersona { get; set; }
        public string? Nombre { get; set; }
        public DateTime FechaActualizacion { get; set; }
        public DateTime FechaCreacion { get; set; }
        public bool Activo { get; set; }

    }
}
