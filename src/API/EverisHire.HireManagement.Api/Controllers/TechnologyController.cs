using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Technologies.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class TechnologyController: ControllerBase
    {
        private readonly IMediator _mediator;
        public TechnologyController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name="GetAllTechnologies")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<TechnologyListVm>>> GetAllTechnologies()
        {
            var dtos = await _mediator.Send(new GetTechnologyListQuery());
            return Ok(dtos);
        }

    }
}