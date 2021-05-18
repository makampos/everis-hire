using EverisHire.HireManagement.Application.Contracts.Persistence;
using FluentValidation;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject
{
    public class CreateProjectCommandValidator 
        : AbstractValidator<CreateProjectCommand>
    {        
        public CreateProjectCommandValidator()
        {
           

            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyName} Must not exceed 50 characters.");

            RuleFor(p => p.Description)
                .NotEmpty()
                .WithMessage("{PropertyName} is required")
                .MaximumLength(200)
                .WithMessage("{PropertyName} Must no exceed 200 characters.");
        }
    }
}