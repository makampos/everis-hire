using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.DeleteJob;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.UpdateJob;
using EverisHire.HireManagement.Application.Features.Jobs.Queries;
using EverisHire.HireManagement.Application.Features.Jobs.Queries.GetJobInterviewDetail;
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
        
        [HttpGet("all/open", Name = "GetAllOpenJobs")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<JobOpenListVm>>> GetAllOpenJobs()
        {
            var dto = await _mediator.Send(new GetAllOpenJobsOpenListQuery());
            return Ok(dto);
        }

        [HttpGet("{id}", Name = "GetJobById")]
        public async Task<ActionResult<JobDetailVm>> GetJobById(Guid id)
        {
            var getJobDetailQuery = new GetJobDetailQuery() {JobId = id};
            return Ok(await _mediator.Send(getJobDetailQuery));
        }
        
        [HttpGet("interview/{everJob}", Name = "GetJobByEverJob")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<JobInterviewDetailVm>> GetJobByEverJob(int everJob)
        {
            var getJobInterviewDetailQuery = new GetJobInterviewDetailQuery() { EverJob = everJob };
            return Ok(await _mediator.Send(getJobInterviewDetailQuery));
        }

        [HttpPost(Name = "AddJob")]
        public async Task<ActionResult<CreateJobCommandResponse>> Create(
            [FromBody] CreateJobCommand createJobCommand)
        {
            var response = await _mediator.Send(createJobCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateJob")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateJobCommand updateJobCommand)
        {
            await _mediator.Send(updateJobCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteJob")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteJobCommand = new DeleteJobCommand() {JobId = id};
            await _mediator.Send(deleteJobCommand);
            return NoContent();
        }

    }
}