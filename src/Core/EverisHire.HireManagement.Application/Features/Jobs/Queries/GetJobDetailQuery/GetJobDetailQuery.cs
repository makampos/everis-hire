using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetJobDetailQuery : IRequest<JobDetailVm>
    {
        public Guid JobId { get; set; }
    }
}