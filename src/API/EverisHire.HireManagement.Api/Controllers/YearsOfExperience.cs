using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.YearsOfExperiences.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class YearsOfExperienceController: ControllerBase
    {

        private readonly IMediator _mediator;
        public YearsOfExperienceController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name="GetAllYearsOfExperience")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<YearsOfExperienceListVm>>> GetAllYearsOfExpriences() 
        {
            var dtos = await _mediator.Send(new GetYearsOfExperienceListQuery());
            return Ok(dtos);
        }

    }
}