using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Squads.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class SquadController : ControllerBase
    {
        private readonly IMediator _mediator;
        public SquadController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllSquads")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<SquadListVm>>> GetAllSquads()
        {
            var dto = await _mediator.Send(new GetSquadListQuery());
            return Ok(dto);
        }

    }
}