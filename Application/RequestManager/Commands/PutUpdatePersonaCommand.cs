using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persona.Domain.Dto;

namespace Persona.Application.RequestManager.Commands
{
    public class PutUpdatePersonaCommand : IRequest<IActionResult>
    {
        public PutUpdatePersonaRequest putUpdatePersonaRequest { get; set; }

    }
}
