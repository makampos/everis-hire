using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class StatusJob: AuditableEntity
    {
        public Guid StatusJobId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Job> Jobs { get; set; }
        
    }
}