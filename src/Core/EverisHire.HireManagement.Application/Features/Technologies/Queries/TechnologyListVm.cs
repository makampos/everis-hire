using System;

namespace EverisHire.HireManagement.Application.Features.Technologies.Queries
{
    public class TechnologyListVm
    {
        public Guid TechnologyId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Type { get; set; }
        
    }
}