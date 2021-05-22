using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries.GetProjectDetail
{
    public class GetProjectDetailQuery : IRequest<ProjectDetailVm>
    {
        public Guid Id { get; set; }
    }
}