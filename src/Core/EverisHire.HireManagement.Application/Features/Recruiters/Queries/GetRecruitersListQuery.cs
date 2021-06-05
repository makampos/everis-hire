using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Recruiters.Queries
{
    public class GetRecruitersListQuery : IRequest<List<RecruiterListVm>>
    {
        
    }
}