

using System;
using System.Threading;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using FluentValidation;

namespace EverisHire.HireManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateEventCommandValidator : 
        AbstractValidator<CreateEventCommand>
    {

        private readonly IEventRepository _eventRepository;
        public CreateEventCommandValidator(IEventRepository eventRepository)
        {
            _eventRepository = eventRepository;

            RuleFor(p => p.Name)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .MaximumLength(50)
                .WithMessage("{PropertyName} must not exceed 50 characters.");
            
            RuleFor(p => p.Date)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .NotNull()
                .GreaterThan(DateTime.Now);

            RuleFor(e => e)
                .MustAsync(EventNameAndDateUnique)
                .WithMessage("And event with the same name and date already exist.");


            RuleFor(p => p.Price)
                .NotEmpty().WithMessage("{PropertyName} is required.")
                .GreaterThan(0);
        }
       

        private async Task<bool> EventNameAndDateUnique(
            CreateEventCommand e,
            CancellationToken token)
        {
            return !(await _eventRepository.IsEventNameAndDateUnique(e.Name, e.Date));
        }       
    }
}