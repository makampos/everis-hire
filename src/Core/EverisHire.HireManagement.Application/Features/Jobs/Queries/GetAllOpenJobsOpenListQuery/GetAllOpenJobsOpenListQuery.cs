using System;
using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetAllOpenJobsOpenListQuery : IRequest<List<JobOpenListVm>>
    {
        public Guid EverJob { get; set; }
    }
}