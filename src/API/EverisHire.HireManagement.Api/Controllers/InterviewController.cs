using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand;
using EverisHire.HireManagement.Application.Features.Interviews.Commands.UpdateInterview;
using EverisHire.HireManagement.Application.Features.Interviews.Queries;
using EverisHire.HireManagement.Application.Features.Jobs.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{   
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class InterviewController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InterviewController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddInterview")]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateInterviewCommand createInterviewCommand)
        {
            var id = await _mediator.Send(createInterviewCommand);
            return Ok(id);
        }
        
        [HttpGet("all", Name = "GetAllInterview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<InterviewListVm>>> GetAllInterviews()
        {
            var dto = await _mediator.Send(new GetInterviewListQuery());
            return Ok(dto);
        }
        
        [HttpPut(Name = "InterviewUpdate")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateInterviewCommand updaterInterviewCommand)
        {
            await _mediator.Send(updaterInterviewCommand);
            return NoContent();
        }
    }
}