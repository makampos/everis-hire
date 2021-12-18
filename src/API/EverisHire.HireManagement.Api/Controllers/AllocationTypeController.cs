using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.AllocationTypes.Queries;
using EverisHire.HireManagement.Application.Features.StatusCandidates.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AllocationTypeController: ControllerBase
    {
        private readonly IMediator _mediator;

        public AllocationTypeController(IMediator mediator)
        {
            _mediator = mediator;
        }
        
        [HttpGet("all", Name = "GetAllAllocationType")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<AllocationTypeListVm>>> GetAllAllocationType()
        {
            var dtos = await _mediator.Send(new GetAllocationTypeListQuery());
            return Ok(dtos);
        }
    }
}