using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Job : AuditableEntity
    {
        public Guid JobId { get; set; }
        public int EverJob { get; set; }        
        public string LeaderCenters { get; set; }
        public string LtfOrPl { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public string Squad { get; set; }
        public Guid ProjectId { get; set; }
        public string AllocationType { get; set; }
        public DateTime? OpeningDate { get; set; }
        public string Technology { get; set; }
        public Guid YearsOfExperience { get; set; }
        public DateTime? DesiredDate { get; set; }
        public decimal MaximumSalary { get; set; }
        public string Recruiter { get; set; }
        public int? Priority { get; set; }
        public DateTime? PriorityDate { get; set; }
        public string Status { get; set; }
        public string Justification { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; } 
        public virtual Project Project { get; set; }           
                        
    }
}