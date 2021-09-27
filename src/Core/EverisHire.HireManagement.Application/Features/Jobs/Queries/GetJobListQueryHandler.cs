using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetJobListQueryHandler : IRequestHandler<GetJobListQuery, List<JobListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Job> _jobRepository;
        public GetJobListQueryHandler(IMapper mapper, IAsyncRepository<Job> jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }
        public async Task<List<JobListVm>> Handle(
            GetJobListQuery request,
            CancellationToken cancellationToken)
        {
            var allJobs = await _jobRepository.ListAllAsync();
            return _mapper.Map<List<JobListVm>>(allJobs);

        }
    }
}