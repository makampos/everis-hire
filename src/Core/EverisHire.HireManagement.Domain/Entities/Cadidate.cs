using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Candidate : AuditableEntity
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public string AlocationType { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }        
        public decimal SalaryClaim { get; set; }
        public virtual Job Job { get; set; }
        public Guid? JobId { get; set; }
        
    }
}