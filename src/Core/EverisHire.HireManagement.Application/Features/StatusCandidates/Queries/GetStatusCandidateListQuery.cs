using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusCandidates.Queries
{
    public class GetStatusCandidateListQuery : IRequest<List<StatusCandidateListVm>>
    {
        
    }
}