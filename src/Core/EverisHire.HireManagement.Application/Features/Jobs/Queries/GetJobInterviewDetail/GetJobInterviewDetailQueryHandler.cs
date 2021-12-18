using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries.GetJobInterviewDetail
{
    public class GetJobInterviewDetailQueryHandler : 
        IRequestHandler<GetJobInterviewDetailQuery, JobInterviewDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly IJobRepository _jobRepository;

        public GetJobInterviewDetailQueryHandler(IMapper mapper, IJobRepository jobRepository)
        {
            _mapper = mapper;
            _jobRepository = jobRepository;
        }
        
        public async Task<JobInterviewDetailVm> Handle(
            GetJobInterviewDetailQuery request,
            CancellationToken cancellationToken)
        {
            var jobToReturn = await _jobRepository.GetJobByEverjobAsync(request.EverJob);

            if (jobToReturn == null)
            {
                throw new NotFoundException(nameof(Job), request.EverJob);
            }

            var jobInterviewDetailDto = _mapper.Map<JobInterviewDetailVm>(jobToReturn);
            return jobInterviewDetailDto;
        }
    }
}