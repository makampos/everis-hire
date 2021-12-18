using System;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery
{
    public class CandidateListVm
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public string AllocationTypeDescription { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }        
        public decimal SalaryClaim { get; set; }
        public string City { get; set; }
        public string Technology { get; set; }
        public string LeaderCenters { get; set; }
        public string Recruiter { get; set; }
        public string Resume { get; set; }
        public string StatusDescription { get; set; }
    }
}