using Microsoft.EntityFrameworkCore;
using Persona.Application;
using Persona.Infraestructure.Configuration;

namespace Persona.Infraestructure.DataBase
{
    public class DataBaseService : DbContext, IDataBaseService
    {
        public DataBaseService(DbContextOptions<DataBaseService> options) : base(options)
        {


        }

        public DbSet<Domain.Entities.Persona.Persona> Persona { get; set; }
        public DbSet<Domain.Entities.TipoPersona.TipoPersona> TipoPersona { get; set; }

        public async Task<bool> SaveAsync()
        {
            return await SaveChangesAsync() > 0;
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            EntityConfuguration(modelBuilder);
        }
        private void EntityConfuguration(ModelBuilder modelBuilder)
        {
            new PersonaConfiguration(modelBuilder.Entity<Domain.Entities.Persona.Persona>());
            new TipoPersonaConfiguration(modelBuilder.Entity<Domain.Entities.TipoPersona.TipoPersona>());

        }

    }
}
