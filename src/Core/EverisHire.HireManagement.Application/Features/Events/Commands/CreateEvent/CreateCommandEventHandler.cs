using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Infrastructure;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Models.Mail;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace EverisHire.HireManagement.Application.Features.Events.Commands.CreateEvent
{
    public class CreateCommandEventHandler : 
        IRequestHandler<CreateEventCommand, Guid>
    {

        private readonly IEventRepository _eventRepository;
        private readonly IMapper _mapper;
        private readonly IEmailService _emailService;

        public CreateCommandEventHandler(
            IEventRepository eventRepository,
            IMapper mapper, IEmailService emailService)
        {
            _eventRepository = eventRepository;
            _mapper = mapper;
            _emailService = emailService;
        }
        public async Task<Guid> Handle(
            CreateEventCommand request,
            CancellationToken cancellationToken)
        {
            var validator = new CreateEventCommandValidator(_eventRepository);
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0) 
            {
                 throw new Exceptions.ValidationException(validationResult);
            }               

            var @event = _mapper.Map<Event>(request);

            @event = await _eventRepository.AddAsync(@event);

            var email = new Email() 
            { To = "matheus.campos@edu.unifil.br",
              Body = $"A new event was created: {request}",
              Subject = "A new event was created"
            };

            try
            {
                await _emailService.SendEmail(email);
            }
            catch (System.Exception)
            {
                
                //This should't stop the API from doing else so this 
                //can be logged
            }

            return @event.EventId;
        }
    }
}