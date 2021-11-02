using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries
{
    public class GetJobDetailQueryHandler : IRequestHandler<GetJobDetailQuery, JobDetailVm>
    {
        private readonly IAsyncRepository<Job> _jobRepository;
        private readonly IMapper _mapper;

        public GetJobDetailQueryHandler(IAsyncRepository<Job> jobRepository, IMapper mapper)
        {
            _jobRepository = jobRepository;
            _mapper = mapper;

        }

        public async Task<JobDetailVm> Handle(
            GetJobDetailQuery request,
            CancellationToken cancellationToken)
        {
            var @job = await _jobRepository.GetByIdAsync(request.JobId);
            var jobDetailDto = _mapper.Map<JobDetailVm>(@job);

            return jobDetailDto;
        }
    }
}