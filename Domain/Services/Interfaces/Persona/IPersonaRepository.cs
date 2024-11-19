using Persona.Domain.Services.IRepository;

namespace Persona.Domain.Services.Interfaces.Persona
{
    public interface IPersonaRepository : IRepository<Entities.Persona.Persona>
    {
        Entities.Persona.Persona GetByNumeroDocumentoPesona(string NumeroDocumento);

        Entities.Persona.Persona GetByIdPesona(Guid Id);

        List<Domain.Entities.Persona.Persona> GetverifyPesona(Guid Id, string NumeroDocumento);

    }
}
