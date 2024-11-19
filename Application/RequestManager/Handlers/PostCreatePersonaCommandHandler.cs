using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Application.Feature;
using Persona.Application.RequestManager.Commands;
using Persona.Domain.Services.Interfaces.Persona;

namespace Persona.Application.RequestManager.Handlers
{
    public class PostCreatePersonaCommandHandler : IRequestHandler<PostCreatePersonaCommand, IActionResult>
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public PostCreatePersonaCommandHandler(IPersonaRepository personaRepository, IMapper mapper)
        {
            this._personaRepository = personaRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(PostCreatePersonaCommand request, CancellationToken cancellationToken)
        {
            if ( this._personaRepository.GetByNumeroDocumentoPesona(request.postCreatePersonaRequest.NumeroDocumento) == null)
            {
                var Entitymapper = _mapper.Map<Domain.Entities.Persona.Persona>(request.postCreatePersonaRequest);
                Entitymapper.IdPersona = Guid.NewGuid();
                this._personaRepository.Add(Entitymapper);
                this._personaRepository.Save();
                return ResponseApiService.Response(StatusCodes.Status201Created, Entitymapper);
            }
            else 
            {
                return ResponseApiService.Response(StatusCodes.Status202Accepted, null, "Persona Ya Registrada");
            }

        }

    }
}
