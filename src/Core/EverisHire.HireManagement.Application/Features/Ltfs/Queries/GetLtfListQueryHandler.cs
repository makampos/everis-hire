using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Ltfs.Queries
{
    public class GetLtfListQueryHandler : IRequestHandler<GetLtfListQuery, List<LtfListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Ltf> _ltfRepository;
        public GetLtfListQueryHandler(IMapper mapper, IAsyncRepository<Ltf> ltfRepository)
        {
            _mapper = mapper;
            _ltfRepository = ltfRepository;
        }
        public async Task<List<LtfListVm>> Handle(
            GetLtfListQuery request,
            CancellationToken cancellationToken)
        {
            var allLtf = await _ltfRepository.ListAllAsync();
            return _mapper.Map<List<LtfListVm>>(allLtf);
        }
    }
}