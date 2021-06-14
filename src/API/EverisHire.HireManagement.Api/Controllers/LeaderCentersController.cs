using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.LeadersCenters.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LeaderCentersController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LeaderCentersController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllLeaderCenters")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<LeaderCentersListVm>>> GetAllLeaderCenters()
        {
            var dto = await _mediator.Send(new GetLeaderCentersListQuery());
            return Ok(dto);
        }
    }
}