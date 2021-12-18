using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateInterviewDetail
{
    public class GetCandidateInterviewDetailQuery: IRequest<CandidateInterviewDetailVm>
    {
        public Guid CandidateId { get; set; }
    }
}