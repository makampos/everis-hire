using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Ltfs.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class LtfController : ControllerBase
    {
        private readonly IMediator _mediator;
        public LtfController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name ="GetAllLtf")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<LtfListVm>>> GetAllLtf()
        {
            var dto = await _mediator.Send(new GetLtfListQuery());
            return Ok(dto);
        }
    }
}