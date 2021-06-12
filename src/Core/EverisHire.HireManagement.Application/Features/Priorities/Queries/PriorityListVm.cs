using System;

namespace EverisHire.HireManagement.Application.Features.Priorities.Queries
{
    public class PriorityListVm
    {
        public Guid PriorityId { get; set; }
        public int Code { get; set; }
        public string Description { get; set; }
    }
}