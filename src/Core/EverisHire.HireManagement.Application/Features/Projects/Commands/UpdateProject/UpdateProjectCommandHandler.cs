using System.Security.Claims;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommandHandler : 
        IRequestHandler<UpdateProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public UpdateProjectCommandHandler(IProjectRepository projectRepository, 
            IMapper mapper, IHttpContextAccessor httpContextAccessor)
        {
            _projectRepository = projectRepository;
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
        }

        public async Task<Unit> Handle(
            UpdateProjectCommand request,
            CancellationToken cancellationToken)
        {
            var projectToUpdate = await _projectRepository.GetByIdAsync(request.ProjectId);
            projectToUpdate.CreatedBy =  _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.NameIdentifier);

            if (projectToUpdate == null)
            {
                throw new NotFoundException(nameof(Project), request.ProjectId);
            }

            var validator = new UpdateProjectCommandValidator(_projectRepository);
            var validationResult = await validator.ValidateAsync(request);

            if(validationResult.Errors.Count > 0)
            {
                throw new ValidationException(validationResult);
            }
                        
            _mapper.Map(request, projectToUpdate,
            typeof(UpdateProjectCommand),
            typeof(Project));

            await _projectRepository.UpdateAsync(projectToUpdate);

            return Unit.Value;
        }
    }
}