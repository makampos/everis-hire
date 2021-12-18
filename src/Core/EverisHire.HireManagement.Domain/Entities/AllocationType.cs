using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class AllocationType: AuditableEntity
    {
        public Guid AllocationTypeId { get; set; }
        public string Description { get; set; }
        public ICollection<Candidate> Candidates { get; set; }
        public ICollection<Job> Jobs { get; set; }
        public Job Job { get; set; }
    }
}