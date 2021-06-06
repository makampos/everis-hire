using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Technology: AuditableEntity
    {
        public Guid TechnologyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }        
    }
}