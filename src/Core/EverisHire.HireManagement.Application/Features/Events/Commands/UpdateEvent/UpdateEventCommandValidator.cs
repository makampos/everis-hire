using System.Threading;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Features.Events.Commands.CreateEvent;
using FluentValidation;

namespace EverisHire.HireManagement.Application.Features.Events.Commands.UpdateEvent
{
    public class UpdateEventCommandValidator :
         AbstractValidator<UpdateEventCommand>
    {

        private readonly IEventRepository _eventRepository;
        public UpdateEventCommandValidator(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;

             RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50).WithMessage("{PropertyName} must not exceed 50 characters.");

            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);

        }        
       
    }
}