using AutoMapper;
using MediatR;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Persona.Application.Feature;
using Persona.Application.RequestManager.Commands;
using Persona.Domain.Services.Interfaces.Persona;

namespace Persona.Application.RequestManager.Handlers
{
    public class GetListPersonaCommandHandler : IRequestHandler<GetListPersonaCommand, IActionResult>
    {
        private readonly IPersonaRepository _personaRepository;
        private readonly IMapper _mapper;

        public GetListPersonaCommandHandler(IPersonaRepository personaRepository, IMapper mapper)
        {
            this._personaRepository = personaRepository;
            _mapper = mapper;
        }

        public async Task<IActionResult> Handle(GetListPersonaCommand request, CancellationToken cancellationToken)
        {
            return ResponseApiService.Response(StatusCodes.Status201Created, _personaRepository.GetAll()); 
        }
    }
}
