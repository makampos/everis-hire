using System.Collections.Generic;
using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;


namespace EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject
{
    public class CreateProjectCommandHandler
        : IRequestHandler<CreateProjectCommand, CreateProjectCommandResponse>
    {
        private readonly IAsyncRepository<Project> _projectRepository;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IMapper _mapper;

        public CreateProjectCommandHandler(IAsyncRepository<Project> projectRepository,
             IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }


        public async Task<CreateProjectCommandResponse> Handle(
            CreateProjectCommand request, 
            CancellationToken cancellationToken)
        {
            var createProjectCommandResponse = new CreateProjectCommandResponse();

            var validator = new CreateProjectCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0) 
            {
                createProjectCommandResponse.Success = false;
                createProjectCommandResponse.ValidationErrors = new List<string>();
                foreach (var error in validationResult.Errors)
                {
                    createProjectCommandResponse.ValidationErrors
                        .Add(error.ErrorMessage);
                }
            }
            if (createProjectCommandResponse.Success)
            {
                
                var project = new Project() 
                { 
                    Name = request.Name,
                    Description = request.Description,
                    CreatedBy = _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier)
                };
                
                project = await _projectRepository.AddAsync(project);
                createProjectCommandResponse.Project = _mapper.Map
                <CreateProjectDto>(project);
            }

            return createProjectCommandResponse;
        }
    }
}