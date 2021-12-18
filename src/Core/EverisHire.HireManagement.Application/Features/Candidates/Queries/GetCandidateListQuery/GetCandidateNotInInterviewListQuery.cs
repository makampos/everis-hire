using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery
{
    public class GetCandidateNotInInterviewListQuery: IRequest<List<CandidateListVm>>
    {
        
    }
}