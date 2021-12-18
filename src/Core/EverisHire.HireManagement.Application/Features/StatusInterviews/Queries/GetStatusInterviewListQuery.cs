using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusInterviews.Queries
{
    public class GetStatusInterviewListQuery: IRequest<List<StatusInterviewListVm>>
    {
        
    }
}