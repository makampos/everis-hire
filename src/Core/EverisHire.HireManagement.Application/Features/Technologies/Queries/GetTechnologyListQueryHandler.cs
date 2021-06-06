using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Technologies.Queries
{
    public class GetTechnologyListQueryHandler : 
        IRequestHandler<GetTechnologyListQuery, List<TechnologyListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<Technology> _technologyRepository;

        public GetTechnologyListQueryHandler(
            IMapper mapper,
            IAsyncRepository<Technology> technologyRepository)
        {
            _mapper = mapper;
            _technologyRepository = technologyRepository;
        }

        public async Task<List<TechnologyListVm>> Handle(
            GetTechnologyListQuery request,
            CancellationToken cancellationToken)
        {
            var allTechnologies = (await _technologyRepository.ListAllAsync());
            return _mapper.Map<List<TechnologyListVm>>(allTechnologies);
        }
    }
}