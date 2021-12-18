using System;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateInterviewDetail
{
    public class CandidateInterviewDetailVm
    {
        public Guid CandidateId { get; set; }
        public string CandidateName { get; set; }
        public string AllocationTypeDescription  { get; set; }
        public int YearsOfExperience  { get; set; }
        public decimal SalaryClaim { get; set; }
        
        public string City { get; set; }
        public string Technology  { get; set; }
        public string LeaderCenters { get; set; }
        public string RecruiterName { get; set; }
        public string StatusDescription { get; set; }
        public DateTime CreatedDate { get; set; }
        
        
        
        
    }
}