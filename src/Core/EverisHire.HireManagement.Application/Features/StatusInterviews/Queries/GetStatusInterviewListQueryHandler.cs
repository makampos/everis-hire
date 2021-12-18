using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusInterviews.Queries
{
    public class GetStatusInterviewListQueryHandler: 
        IRequestHandler<GetStatusInterviewListQuery, List<StatusInterviewListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<StatusInterview> _StatusInterviewRepository;
        
        public GetStatusInterviewListQueryHandler(IAsyncRepository<StatusInterview> statusInterviewRepository, IMapper mapper)
        {
            _StatusInterviewRepository = statusInterviewRepository;
            _mapper = mapper;
        }
        public async Task<List<StatusInterviewListVm>> Handle(
            GetStatusInterviewListQuery request,
            CancellationToken cancellationToken)
        {
            var allStatusInterview = (await _StatusInterviewRepository.ListAllAsync());
            return _mapper.Map<List<StatusInterviewListVm>>(allStatusInterview);
        }
    }
}