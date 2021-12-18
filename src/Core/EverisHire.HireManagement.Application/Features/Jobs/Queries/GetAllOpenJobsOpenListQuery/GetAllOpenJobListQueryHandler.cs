using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetAllOpenJobListQueryHandler: IRequestHandler<GetAllOpenJobsOpenListQuery, List<JobOpenListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;
        
        public GetAllOpenJobListQueryHandler(IMapper mapper, IJobRepository jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }
        
        public async Task<List<JobOpenListVm>> Handle(
            GetAllOpenJobsOpenListQuery request,
            CancellationToken cancellationToken)
        {
            var allJobs = await _jobRepository.GetJobByStatusOpen();
            // if (allJobs.Count == 0)
            // {
            //     throw new NotFoundException(nameof(List<JobOpenListVm>), request.EverJob);
            // }

            var jobsToReturn = _mapper.Map<List<JobOpenListVm>>(allJobs);
            return jobsToReturn;
        }
    }
}