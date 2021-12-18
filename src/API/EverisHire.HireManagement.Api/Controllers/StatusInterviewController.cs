using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.StatusCandidates.Queries;
using EverisHire.HireManagement.Application.Features.StatusInterviews.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StatusInterviewController: ControllerBase
    {
        private readonly IMediator _mediator;

        public StatusInterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("all", Name = "GetAllStatusInterview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<StatusInterviewListVm>>> GetAllStatusInterview()
        {
            var dtos = await _mediator.Send(new GetStatusInterviewListQuery());
            return Ok(dtos);
        }
    }
}