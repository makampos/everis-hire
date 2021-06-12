using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Community: AuditableEntity
    {
        public Guid CommunityId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}