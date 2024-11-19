using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persona.Domain.Dto;

namespace Persona.Application.RequestManager.Commands
{
    public class PutDeletePersonaCommand : IRequest<IActionResult>
    {
        public Guid IdPersona { get; set; }

    }
}
