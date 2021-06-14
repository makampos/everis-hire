using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.LeadersCenters.Queries
{
    public class GetLeaderCentersListQueryHandler : IRequestHandler<GetLeaderCentersListQuery, List<LeaderCentersListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<LeaderCenters> _leaderCentersRepository;
        public GetLeaderCentersListQueryHandler(IMapper mapper, IAsyncRepository<LeaderCenters> leaderCentersRepository)
        {
            _mapper = mapper;
            _leaderCentersRepository = leaderCentersRepository;
        }

        public async Task<List<LeaderCentersListVm>> Handle(
            GetLeaderCentersListQuery request,
            CancellationToken cancellationToken)
        {
            var allLeaderCenters = await _leaderCentersRepository.ListAllAsync();
            return _mapper.Map<List<LeaderCentersListVm>>(allLeaderCenters);
        }
    }
}