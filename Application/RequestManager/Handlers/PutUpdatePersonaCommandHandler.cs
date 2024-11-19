using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Application.Feature;
using Persona.Application.RequestManager.Commands;
using Persona.Domain.Services.Interfaces.Persona;

namespace Persona.Application.RequestManager.Handlers
{
    public class PutUpdatePersonaCommandHandler : IRequestHandler<PutUpdatePersonaCommand, IActionResult>
    {

        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PutUpdatePersonaCommandHandler(IPersonaRepository personaRepository, IMapper mapper)
        {
            this._personaRepository = personaRepository;
            _mapper = mapper;
        }
        public async Task<IActionResult> Handle(PutUpdatePersonaCommand request, CancellationToken cancellationToken)
        {

            Domain.Entities.Persona.Persona persona = _personaRepository.GetByIdPesona(request.putUpdatePersonaRequest.IdPersona);
            if (persona != null)
            {
                if (_personaRepository.GetverifyPesona(request.putUpdatePersonaRequest.IdPersona, request.putUpdatePersonaRequest.NumeroDocumento).Count == 0)
                {

                    persona.Nombres = request.putUpdatePersonaRequest.Nombres;
                    persona.Apellidos = request.putUpdatePersonaRequest.Apellidos;
                    persona.IdPersona = request.putUpdatePersonaRequest.IdPersona;
                    persona.TipoPersonaId = request.putUpdatePersonaRequest.TipoPersonaId;
                    _personaRepository.Update(persona);
                    _personaRepository.Save();

                    return ResponseApiService.Response(StatusCodes.Status201Created, request.putUpdatePersonaRequest);

                }
                else
                {
                    return ResponseApiService.Response(StatusCodes.Status202Accepted, null, "la  persona  Ya Esta Registrada");
                }
            }
            else { return ResponseApiService.Response(StatusCodes.Status202Accepted, "la  persona Ya Esta Registrada"); }


        }


    }
}
