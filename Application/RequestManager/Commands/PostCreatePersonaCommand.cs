using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persona.Domain.Dto;

namespace Persona.Application.RequestManager.Commands
{
    public class PostCreatePersonaCommand : IRequest<IActionResult>
    {
        public PostCreatePersonaRequest postCreatePersonaRequest { get; set; }

    }
}
