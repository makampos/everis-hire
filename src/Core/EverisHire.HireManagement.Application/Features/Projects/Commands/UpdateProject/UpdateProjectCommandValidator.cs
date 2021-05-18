using EverisHire.HireManagement.Application.Contracts.Persistence;
using FluentValidation;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommandValidator :
        AbstractValidator<UpdateProjectCommand>
    {
        private readonly IProjectRepository _projectRepository;

        public UpdateProjectCommandValidator(IProjectRepository projectRepository)
        {
            _projectRepository = projectRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characteres.");            
        }
    }
}