using System;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Candidates.Commands;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class CandidateController: ControllerBase
    {
        private readonly IMediator _mediator;

        public CandidateController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost(Name = "AddCandidate")]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateCandidateCommand createCandidateCommand)
        {
            var id = await _mediator.Send(createCandidateCommand);
            return Ok(id);
        }
    }
}