using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.CreateProject
{
    public class CreateProjectCommand : IRequest<CreateProjectCommandResponse>
    {
        public string Name { get; set; }
        public string Description { get; set; }
    }
}