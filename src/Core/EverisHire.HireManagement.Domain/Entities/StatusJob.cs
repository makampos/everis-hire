using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class StatusJob: AuditableEntity
    {
        public Guid StatusJobId { get; set; } 
        public int Code { get; set; }
        public string Description { get; set; }  
        
    }
}