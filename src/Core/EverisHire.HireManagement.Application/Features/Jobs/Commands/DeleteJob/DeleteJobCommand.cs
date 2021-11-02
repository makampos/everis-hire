using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.DeleteJob
{
    public class DeleteJobCommand : IRequest
    {
        public Guid JobId { get; set; }
    }
}