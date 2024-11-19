using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persona.Infraestructure.Configuration
{
    public class PersonaConfiguration
    {
        public PersonaConfiguration(EntityTypeBuilder<Domain.Entities.Persona.Persona> entityBuilder)
        {
            entityBuilder.HasKey(x => x.IdPersona);
        }

    }
}
