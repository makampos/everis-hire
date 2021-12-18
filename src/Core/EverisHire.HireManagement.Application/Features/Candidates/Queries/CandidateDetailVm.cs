using System;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries
{
    public class CandidateDetailVm
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string AlocationType { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }        
        public decimal SalaryClaim { get; set; }
        public string City { get; set; }
        public string Technology { get; set; }
        public string Leader { get; set; }
        public string Recruiter { get; set; }
        public string Resume { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}