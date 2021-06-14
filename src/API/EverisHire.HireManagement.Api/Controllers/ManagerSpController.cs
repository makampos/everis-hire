using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.ManagersSp.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class ManagerSpController : ControllerBase
    {
        private readonly IMediator _mediator;
        public ManagerSpController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name ="GetAllManagerSp")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ManagerSpListVm>>> GetAllManagerSp()
        {
            var dtos = await _mediator.Send(new GetManagerSpListQuery());
            return Ok(dtos);
        }

    }
}