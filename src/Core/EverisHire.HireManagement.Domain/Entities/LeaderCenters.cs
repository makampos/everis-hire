using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class LeaderCenters: AuditableEntity
    {
        public Guid LeaderCentersId { get; set; }
        public string Name { get; set; }
        
    }
}