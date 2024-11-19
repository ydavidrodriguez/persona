using Microsoft.EntityFrameworkCore;

namespace Persona.Application
{
    public interface IDataBaseService
    {
        public DbSet<Domain.Entities.Persona.Persona> Persona { get; set; }
        public DbSet<Domain.Entities.TipoPersona.TipoPersona> TipoPersona { get; set; }
        Task<bool> SaveAsync();

    }
}
