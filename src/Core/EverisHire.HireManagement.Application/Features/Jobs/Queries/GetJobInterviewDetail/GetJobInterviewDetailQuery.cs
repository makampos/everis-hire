using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries.GetJobInterviewDetail
{
    public class GetJobInterviewDetailQuery: IRequest<JobInterviewDetailVm>
    {
        public int EverJob { get; set; }
    }
}