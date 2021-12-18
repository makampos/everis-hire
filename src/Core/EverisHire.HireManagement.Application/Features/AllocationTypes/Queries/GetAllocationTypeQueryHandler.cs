using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.AllocationTypes.Queries
{
    public class GetAllocationTypeQueryHandler :
        IRequestHandler<GetAllocationTypeListQuery, List<AllocationTypeListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<AllocationType> _allocationTypeRepository;

        public GetAllocationTypeQueryHandler(IMapper mapper, IAsyncRepository<AllocationType> allocationTypeRepository)
        {
            _mapper = mapper;
            _allocationTypeRepository = allocationTypeRepository;
        }
        public async Task<List<AllocationTypeListVm>> Handle(
            GetAllocationTypeListQuery request, CancellationToken cancellationToken)
        {
            var allAllocationType = (await _allocationTypeRepository.ListAllAsync());
            return _mapper.Map<List<AllocationTypeListVm>>(allAllocationType);
        }
    }
}