using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Contracts.Feature.Events
{
    public class GetEventsListQuery : IRequest<List<EventListVm>>
    {
        
    }
}