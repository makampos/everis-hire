using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

using MediatR;

namespace EverisHire.HireManagement.Application.Features.Priorities.Queries
{
    public class GetPriorityListQueryHandler : IRequestHandler<GetPriorityListQuery, List<PriorityListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Priority> _priorityRepository;
        public GetPriorityListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Priority> priorityRepository)
        {
            _mapper = mapper;
            _priorityRepository = priorityRepository;
        }

        public async Task<List<PriorityListVm>> Handle(
            GetPriorityListQuery request,
            CancellationToken cancellationToken)
        {
            var allPriorities = (await _priorityRepository.ListAllAsync());
            return _mapper.Map<List<PriorityListVm>>(allPriorities);
        }
    }
}