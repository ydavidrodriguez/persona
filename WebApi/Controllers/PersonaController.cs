using MediatR;
using Microsoft.AspNetCore.Mvc;
using Persona.Application.ExceptionManager;
using Persona.Application.RequestManager.Commands;
using Persona.Domain.Dto;

namespace Persona.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [TypeFilter(typeof(ExceptionManager))]
    public class PersonaController : Controller
    {
        #region
        private readonly IMediator _mediator;
        #endregion

        public PersonaController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost("PostCreatePersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExceptionManager))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ExceptionManager))]
        public async Task<IActionResult> PostCreatePersona([FromBody] PostCreatePersonaRequest postCreatePersonaRequest)
        {
            return await _mediator.Send(new PostCreatePersonaCommand
            {
                postCreatePersonaRequest = postCreatePersonaRequest
            });
        }
        [HttpPut("PutUpdatePersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExceptionManager))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ExceptionManager))]
        public async Task<IActionResult> PutUpdatePersona([FromBody] PutUpdatePersonaRequest putUpdatePersonaRequest)
        {
            return await _mediator.Send(new PutUpdatePersonaCommand
            {
                putUpdatePersonaRequest = putUpdatePersonaRequest
            });
        }
        [HttpGet("getlistpersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExceptionManager))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ExceptionManager))]
        public async Task<IActionResult> getlistpersona()
        {
            return await _mediator.Send(new GetListPersonaCommand
            {

            });
        }
        [HttpPost("PostDeletePersona")]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest, Type = typeof(ExceptionManager))]
        [ProducesResponseType(StatusCodes.Status409Conflict, Type = typeof(ExceptionManager))]
        public async Task<IActionResult> PostDeletePersona([FromQuery] Guid IdPersona)
        {
            return await _mediator.Send(new PutDeletePersonaCommand
            {
                IdPersona = IdPersona
            });
        }
    }
}
