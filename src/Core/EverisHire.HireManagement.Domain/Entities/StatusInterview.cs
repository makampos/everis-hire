using System;
using System.Collections.Generic;

namespace EverisHire.HireManagement.Domain.Entities
{
    public class StatusInterview
    {
        public Guid StatusInterviewId { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Interview> Interviews { get; set; }
    }
}