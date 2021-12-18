using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Features.Jobs.Queries;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Interviews.Queries
{
    public class GetInterviewListQueryHandler: IRequestHandler<GetInterviewListQuery, List<InterviewListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IInterviewRepository _interviewRepository;
        public GetInterviewListQueryHandler(IMapper mapper, IInterviewRepository interviewRepository)
        {
            _mapper = mapper;
            _interviewRepository = interviewRepository;

        }
       

        public async Task<List<InterviewListVm>> Handle(
            GetInterviewListQuery request
            , CancellationToken cancellationToken)
        {
            var allInterviews = await _interviewRepository.ListAllAsync();
            var allInterviewsToReturn = _mapper.Map<List<InterviewListVm>>(allInterviews);
            return allInterviewsToReturn;
        }
    }
}