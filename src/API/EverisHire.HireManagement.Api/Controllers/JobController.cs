using System;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class JobController : ControllerBase
    {
        private readonly IMediator mediator;
        
        public JobController(IMediator mediator)
        {
            this.mediator = mediator;
        }

        [HttpPost(Name = "AddJob")]
        public async Task<ActionResult<CreateJobCommandResponse>> Create(
            [FromBody] CreateJobCommand createJobCommand)
        {
            var response = await mediator.Send(createJobCommand);
            return Ok(response);
        }
    }
}