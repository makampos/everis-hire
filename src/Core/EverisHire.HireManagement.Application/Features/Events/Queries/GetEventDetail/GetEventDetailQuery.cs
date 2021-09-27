using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Contracts.Feature.Events
{
    public class GetEventDetailQuery : IRequest<EventDetailVm>
    {
        public Guid Id { get; set; }
    }
}