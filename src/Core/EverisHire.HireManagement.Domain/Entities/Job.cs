using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Job : AuditableEntity
    {
        public Guid JobId { get; set; }
        public string JobType { get; set; }
        public int EverJob { get; set; }
        public string Manager { get; set; }
        public string Ltf { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public string AllocationType { get; set; }
        public DateTime? ClosedDate { get; set; }
        public string Technology { get; set; }
        public int YearsOfExperience { get; set; }
        public decimal MaximumSalary { get; set; }
        public int? Priority { get; set; }
        public DateTime? PriorityDate { get; set; }
        public string Status { get; set; }
        public string Justification { get; set; }
        
        public virtual ICollection<Candidate> Candidates { get; set; }

        public virtual Project Project { get; set; }
        public Guid ProjectId { get; set; }
        
    }
}