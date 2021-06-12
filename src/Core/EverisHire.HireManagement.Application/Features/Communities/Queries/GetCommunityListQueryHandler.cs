using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Communities.Queries
{
    public class GetCommunityListQueryHandler : IRequestHandler<GetCommunityListQuery, List<CommunityListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Community> _communityRepository;
        public GetCommunityListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Community> communityRepository)
        {
            _mapper = mapper;
            _communityRepository = communityRepository;
        }

        public async Task<List<CommunityListVm>> Handle(
            GetCommunityListQuery request,
            CancellationToken cancellationToken)
        {
            var allCommunities = (await _communityRepository.ListAllAsync());
            return  _mapper.Map<List<CommunityListVm>>(allCommunities);
        }
    }
}