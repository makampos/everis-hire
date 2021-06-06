using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class YearsOfExperience: AuditableEntity
    {
        public Guid YearsOfExperienceId { get; set; }
        public string ViewValue { get; set; }
        
    }
}