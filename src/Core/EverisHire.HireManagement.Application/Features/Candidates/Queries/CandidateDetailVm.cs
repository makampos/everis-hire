using System;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries
{
    public class CandidateDetailVm
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
    }
}