using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Squad: AuditableEntity
    {
        public Guid SquadId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}