using System;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject
{
    public class CreateProjectDto
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}