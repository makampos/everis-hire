
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Priorities.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class PriorityController: ControllerBase
    {
        private readonly IMediator _mediator;
        public PriorityController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("all", Name = "GetAllPriorities")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<PriorityListVm>>> getAllPriority()
        {
            var dtos = await _mediator.Send(new GetPriorityListQuery());
            return Ok(dtos);
        }
    }
}