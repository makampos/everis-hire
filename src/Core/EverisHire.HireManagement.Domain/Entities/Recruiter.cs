using System;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class Recruiter: AuditableEntity
    {
        public Guid RecruiterId { get; set; }
        public string Name { get; set; }
        
    }
}