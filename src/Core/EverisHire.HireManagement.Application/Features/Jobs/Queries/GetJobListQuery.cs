using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetJobListQuery : IRequest<List<JobListVm>>
    {
        
    }
}