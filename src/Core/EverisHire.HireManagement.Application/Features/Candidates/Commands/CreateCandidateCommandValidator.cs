using FluentValidation;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    internal class CreateCandidateCommandValidator 
        : AbstractValidator<CreateCandidateCommand>
    {
        public CreateCandidateCommandValidator()
        {

            RuleFor(p => p.Name)
            .NotEmpty()
            .WithMessage("{PropertyName} is required")
            .NotNull()
            .MaximumLength(50)
            .WithMessage("{PropertyName} Must not exceed 50 characters.");
        }
    }
}