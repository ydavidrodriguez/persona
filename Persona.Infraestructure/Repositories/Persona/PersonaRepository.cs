using Persona.Domain.Services.Interfaces.Persona;
using Persona.Infraestructure.DataBase;

namespace Persona.Infraestructure.Repositories.Persona
{
    public class PersonaRepository : EntityRepository<Domain.Entities.Persona.Persona>, IPersonaRepository
    {
        private readonly DataBaseService _context;

        public PersonaRepository(DataBaseService context) : base(context)
        {
            this._context = context;
        }

        public Domain.Entities.Persona.Persona GetByNumeroDocumentoPesona(string numeroDocumento)
        {
            return _context.Persona.Where(x => x.NumeroDocumento == numeroDocumento).FirstOrDefault();
        }

        public Domain.Entities.Persona.Persona GetByIdPesona(Guid Id)
        {
            return _context.Persona.Where(x => x.IdPersona == Id).FirstOrDefault();
        }

        public List<Domain.Entities.Persona.Persona> GetverifyPesona(Guid Id,string NumeroDocumento)
        {
            return _context.Persona.Where(x => x.NumeroDocumento == NumeroDocumento && x.IdPersona != Id).ToList();
        }

    }
}
