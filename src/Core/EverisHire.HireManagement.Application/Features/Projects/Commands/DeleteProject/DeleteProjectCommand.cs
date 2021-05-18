using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Commands.DeleteProject
{
    public class DeleteProjectCommand : IRequest
    {
        public Guid ProjectId { get; set; }
    }
}