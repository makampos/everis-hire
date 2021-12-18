using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Job : AuditableEntity
    {
        public Guid JobId { get; set; }
        public Guid ProjectId { get; set; }
        public Guid AllocationTypeId { get; set; }
        public int EverJob { get; set; }        
        public string LeaderCenters { get; set; }
        public string LtfOrPl { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public string Squad { get; set; }
        public DateTime? OpeningDate { get; set; }
        public string Technology { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime? DesiredDate { get; set; }
        public decimal MaximumSalary { get; set; }
        public string Recruiter { get; set; }
        public int? Priority { get; set; }
        public DateTime? PriorityDate { get; set; }
        public Guid StatusJobId { get; set; }
        public string Justification { get; set; }
        public virtual Project Project { get; set; }
        public virtual Interview Interview { get; set; }
        public virtual AllocationType AllocationType { get; set; }
        public virtual StatusJob StatusJob { get; set; }

    }
}