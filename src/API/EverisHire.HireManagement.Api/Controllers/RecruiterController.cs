using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Recruiters.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class RecruiterController: ControllerBase
    {
        private readonly IMediator _mediator;
        public RecruiterController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllRecruiters")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<RecruiterListVm>>> GetAllRecruiters()
        {
            var dtos = await _mediator.Send(new GetRecruitersListQuery());
            return Ok(dtos);
        }
    }
}