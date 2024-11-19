using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persona.Infraestructure.Configuration
{
    public class TipoPersonaConfiguration
    {
        public TipoPersonaConfiguration(EntityTypeBuilder<Domain.Entities.TipoPersona.TipoPersona> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdTipoPersona);
        }

    }
}
