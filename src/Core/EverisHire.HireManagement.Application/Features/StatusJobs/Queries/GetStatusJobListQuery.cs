using System;
using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusJobs.Queries
{
    public class GetStatusJobListQuery : IRequest<List<StatusJobListVm>>
    {
       
    }
}