using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Technologies.Queries
{
    public class GetTechnologyListQuery: IRequest<List<TechnologyListVm>>
    {
        
    }
}