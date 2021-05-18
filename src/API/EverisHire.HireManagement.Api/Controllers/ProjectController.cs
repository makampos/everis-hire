using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject;
using EverisHire.HireManagement.Application.Features.Projects.Commands.DeleteProject;
using EverisHire.HireManagement.Application.Features.Projects.Commands.UpdateProject;
using EverisHire.HireManagement.Application.Features.Projects.Queries;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace EverisHire.HireManagement.Api.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController] 
    public class ProjectController : ControllerBase
    {
        private readonly IMediator _mediator;

        public ProjectController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("all", Name = "GetAllProjects")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        public async Task<ActionResult<List<ProjectListVm>>> GetAllProjects()
        {
            var dtos = await _mediator.Send(new GetProjectsListQuery());
            return Ok(dtos);
        }
        
        [HttpPost(Name = "AddProject")]
        public async Task<ActionResult<CreateProjectCommandResponse>> Create(
            [FromBody] CreateProjectCommand createProjectCommand)
        {
            var response = await _mediator.Send(createProjectCommand);
            return Ok(response);
        }

        [HttpPut(Name = "UpdateProject")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Update([FromBody] UpdateProjectCommand updateProjectCommand)
        {
            await _mediator.Send(updateProjectCommand);
            return NoContent();
        }

        [HttpDelete("{id}", Name = "DeleteProject")]
        [ProducesResponseType(StatusCodes.Status204NoContent)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesDefaultResponseType]
        public async Task<ActionResult> Delete(Guid id)
        {
            var deleteProjectCommand = new DeleteProjectCommand() { ProjectId = id };
            await _mediator.Send(deleteProjectCommand);
            return NoContent();
        }
    }
}