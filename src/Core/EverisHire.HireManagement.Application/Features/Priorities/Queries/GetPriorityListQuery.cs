using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Priorities.Queries
{
    public class GetPriorityListQuery : IRequest<List<PriorityListVm>>
    {
        
    }
}