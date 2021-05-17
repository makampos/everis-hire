using System;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries
{
    public class ProjectListVm
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}