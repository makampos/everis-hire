using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.UpdateProject
{
    public class UpdateProjectCommand: IRequest
    {
        public Guid ProjectId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        
    }
}