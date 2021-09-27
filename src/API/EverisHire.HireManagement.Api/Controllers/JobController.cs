using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob;
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
    public class JobController : ControllerBase
    {
        private readonly IMediator _mediator;
        
        public JobController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllJobs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<JobListVm>>> GetAllJobs()
        {
            var dto = await _mediator.Send(new GetJobListQuery());
            return Ok(dto);
        }

        [HttpPost(Name = "AddJob")]
        public async Task<ActionResult<CreateJobCommandResponse>> Create(
            [FromBody] CreateJobCommand createJobCommand)
        {
            var response = await _mediator.Send(createJobCommand);
            return Ok(response);
        }
    }
}