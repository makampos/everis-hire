using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries
{
    public class GetCandidateDetailQuery : IRequest<CandidateDetailVm>
    {
        public Guid CandidateId { get; set; }
        
    }
}