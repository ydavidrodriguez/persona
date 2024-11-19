using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Application.Feature;
using Persona.Application.RequestManager.Commands;
using Persona.Domain.Services.Interfaces.Persona;

namespace Persona.Application.RequestManager.Handlers
{
    public class PutDeletePersonaCommandHandler : IRequestHandler<PutDeletePersonaCommand, IActionResult>
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PutDeletePersonaCommandHandler(IPersonaRepository personaRepository, IMapper mapper)
        {
            this._personaRepository = personaRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(PutDeletePersonaCommand request, CancellationToken cancellationToken)
        {
            Domain.Entities.Persona.Persona persona = _personaRepository.GetByIdPesona(request.IdPersona);
            if (persona != null)
            {
                _personaRepository.Delete(persona);
                _personaRepository.Save();

                return ResponseApiService.Response(StatusCodes.Status201Created, request.IdPersona);

            }
            else 
            {
                return ResponseApiService.Response(StatusCodes.Status202Accepted, null, "la  persona  no se encuentra Registrada");

            }


        }
    }
}
