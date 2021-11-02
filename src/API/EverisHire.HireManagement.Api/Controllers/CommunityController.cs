using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Communities.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CommunityController : ControllerBase
    {
        private readonly IMediator _mediator;
        public CommunityController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllCommunities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CommunityListVm>>> GetAllCommunities()
        {
            var dtos = await _mediator.Send(new GetCommunityListQuery());
            return Ok(dtos);
        }

    }
}