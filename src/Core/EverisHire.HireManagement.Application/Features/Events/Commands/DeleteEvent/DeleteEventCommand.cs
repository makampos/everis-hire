using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Events.Commands.DeleteEvent
{
    public class DeleteEventCommand : IRequest
    {
        public Guid EventId { get; set; }
        
    }
}