using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery
{
    public class GetCandidateListQueryHandler : 
        IRequestHandler<GetCandidateListQuery,
        List<CandidateListVm>>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;
        public GetCandidateListQueryHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }

        public async Task<List<CandidateListVm>> Handle(
            GetCandidateListQuery request,
            CancellationToken cancellationToken)
        {
            var allCandidates = await _candidateRepository.GetCandidatesWithInclude();
            var checkMapping = _mapper.Map<List<CandidateListVm>>(allCandidates);
            return checkMapping;
        }
    }
}