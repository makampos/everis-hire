using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Ltf: AuditableEntity
    {
        public Guid LtfId { get; set; }
        public string Name { get; set; }
        
    }
}