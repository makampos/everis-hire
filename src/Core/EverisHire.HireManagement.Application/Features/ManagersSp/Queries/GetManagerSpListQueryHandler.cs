using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.ManagersSp.Queries
{
    public class GetManagerSpListQueryHandler :
     IRequestHandler<GetManagerSpListQuery, List<ManagerSpListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<ManagerSp> _managerSpRepository;
        public GetManagerSpListQueryHandler(IMapper mapper, IAsyncRepository<ManagerSp> managerSpRepository)
        {
            _mapper = mapper;
            _managerSpRepository = managerSpRepository;
        }

        public async Task<List<ManagerSpListVm>> Handle(
            GetManagerSpListQuery request,
            CancellationToken cancellationToken)
        {
            var allManagersSp = await _managerSpRepository.ListAllAsync();
            return _mapper.Map<List<ManagerSpListVm>>(allManagersSp);
        }
    }
}