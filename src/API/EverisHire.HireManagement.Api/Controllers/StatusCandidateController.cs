using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.StatusCandidates.Queries;
using EverisHire.HireManagement.Application.Features.StatusJobs.Queries;
using MediatR;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class StatusCandidateController: ControllerBase
    {
      private readonly IMediator _mediator;

      public StatusCandidateController(IMediator mediator)
      {
          _mediator = mediator;
      }
      
      [HttpGet("all", Name = "GetAllStatusCandidate")]
      [ProducesResponseType(StatusCodes.Status200OK)]
      public async Task<ActionResult<List<StatusCandidateListVm>>> GetAllStatusCandidates()
      {
          var dtos = await _mediator.Send(new GetStatusCandidateListQuery());
          return Ok(dtos);
      }
      
    }
}