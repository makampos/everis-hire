using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusJobs.Queries
{
    public class GetStatusJobListQueryHandler : 
        IRequestHandler<GetStatusJobListQuery, List<StatusJobListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<StatusJob> _statusJobRepository;
        public GetStatusJobListQueryHandler(IAsyncRepository<StatusJob> statusJobRepository, IMapper mapper)
        {
            _statusJobRepository = statusJobRepository;
            _mapper = mapper;
        }

        public async Task<List<StatusJobListVm>> Handle(
            GetStatusJobListQuery request,
            CancellationToken cancellationToken)
        {
            var allStatusJobs = (await _statusJobRepository.ListAllAsync());
            return _mapper.Map<List<StatusJobListVm>>(allStatusJobs);
        }
        
    }
}