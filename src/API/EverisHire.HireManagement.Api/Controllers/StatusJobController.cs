using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.StatusJobs.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StatusJobController : ControllerBase
    {
        private readonly IMediator _mediator;
        public StatusJobController( IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllStatusJobs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<StatusJobListVm>>> GetAllJobs()
        {
            var dtos = await _mediator.Send(new GetStatusJobListQuery());
            return Ok(dtos);
        }
    }
}