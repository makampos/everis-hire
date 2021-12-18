using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.AllocationTypes.Queries
{
    public class GetAllocationTypeListQuery: IRequest<List<AllocationTypeListVm>>
    {
        
    }
}