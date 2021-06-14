using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Squads.Queries
{
    public class GetSquadListQueryHandler : IRequestHandler<GetSquadListQuery, List<SquadListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Squad> _squadRepository;
        public GetSquadListQueryHandler(IMapper mapper, IAsyncRepository<Squad> squadRepository)
        {
            _mapper = mapper;
            _squadRepository = squadRepository;
        }
        public async Task<List<SquadListVm>> Handle(
            GetSquadListQuery request,
            CancellationToken cancellationToken)
        {
            var allSquads = await _squadRepository.ListAllAsync();
            return _mapper.Map<List<SquadListVm>>(allSquads);
        }
    }
}