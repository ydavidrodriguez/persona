using MediatR;
using Microsoft.AspNetCore.Mvc;

namespace Persona.Application.RequestManager.Commands
{
    public class GetListPersonaCommand : IRequest<IActionResult>
    {
    }
}
