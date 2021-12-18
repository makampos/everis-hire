using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Common;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class StatusCandidate : AuditableEntity
    {
        public Guid StatusCandidateId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Candidate> Candidates { get; set; }
    }
}