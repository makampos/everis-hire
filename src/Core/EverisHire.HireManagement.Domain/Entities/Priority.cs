using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Priority: AuditableEntity
    {
        public Guid PriorityId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
        
    }
}