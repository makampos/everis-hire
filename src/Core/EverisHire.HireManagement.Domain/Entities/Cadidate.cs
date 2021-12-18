using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Candidate : AuditableEntity
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }        
        public decimal SalaryClaim { get; set; }
        public string City { get; set; }
        public string Technology { get; set; }
        public string LeaderCenters { get; set; }
        public string Recruiter { get; set; }
        public string Resume { get; set; }
        public Guid StatusCandidateId { get; set; }
        public Guid AllocationTypeId { get; set; }
        
        /*Navigation Property for interview entity*/
        public virtual Interview Interview { get; set; }
        public virtual StatusCandidate StatusCandidate { get; set; }
        public virtual AllocationType AllocationType { get; set; }
        
        
    }
}