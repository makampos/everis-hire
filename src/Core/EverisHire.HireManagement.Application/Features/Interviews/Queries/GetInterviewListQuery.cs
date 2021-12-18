using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Interviews.Queries
{
    public class GetInterviewListQuery: IRequest<List<InterviewListVm>>
    {
        
    }
}