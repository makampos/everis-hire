using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Candidates.Commands;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.DeleteCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Commands.UpdateCandidate;
using EverisHire.HireManagement.Application.Features.Candidates.Queries;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateInterviewDetail;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
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
        
        [HttpGet("all", Name = "GetAllCandidates")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CandidateListVm>>> GetAllCandidates()
        {
            var dto = await _mediator.Send(new GetCandidateListQuery());
            return Ok(dto);
        }
        
        [HttpGet("notInInterview", Name = "GetAllCandidatesWhereNotInInterview")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<CandidateListVm>>> GetAllCandidatesNotInInterview()
        {
            var dto = await _mediator.Send(new GetCandidateNotInInterviewListQuery());
            return Ok(dto);
        }

        [HttpGet("{id}", Name = "GetCandidateById")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CandidateDetailVm>> GetCandidateById(Guid id) 
        {
            var getCandidateDetailQuery = new GetCandidateDetailQuery() { CandidateId = id} ;
            return Ok(await _mediator.Send(getCandidateDetailQuery));
        }
        
        [HttpGet("interview/{id}", Name = "GetCandidateByIdWithInclude")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<CandidateInterviewDetailVm>> GetCandidateByIdWithInclude(Guid id) 
        {
            var getCandidateInterviewDetailQuery = new GetCandidateInterviewDetailQuery() { CandidateId = id} ;
            return Ok(await _mediator.Send(getCandidateInterviewDetailQuery));
        }

        [HttpPost(Name = "AddCandidate")]
        public async Task<ActionResult<Guid>> Create(
            [FromBody] CreateCandidateCommand createCandidateCommand)
        {
            var id = await _mediator.Send(createCandidateCommand);
            return Ok(id);
        }
        
        [HttpPut(Name = "UpdateCandidate")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateCandidateCommand updateCandidateCommand)
        {
            await _mediator.Send(updateCandidateCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteCandidate")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteProjectCommand = new DeleteCandidateCommand() { CandidateId = id };
            await _mediator.Send(deleteProjectCommand);
            return NoContent();
        }

    }
}