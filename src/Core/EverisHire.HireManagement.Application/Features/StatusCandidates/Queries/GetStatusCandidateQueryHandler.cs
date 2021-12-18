using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.StatusCandidates.Queries
{
    public class GetStatusCandidateQueryHandler :
        IRequestHandler<GetStatusCandidateListQuery, List<StatusCandidateListVm>>
    {
        private readonly IMapper _mapper;
        private readonly IAsyncRepository<StatusCandidate> _statusCandidateRepository;

        public GetStatusCandidateQueryHandler(IMapper mapper, IAsyncRepository<StatusCandidate> statusCandidateRepository)
        {
            _mapper = mapper;
            _statusCandidateRepository = statusCandidateRepository;
        }

        public async Task<List<StatusCandidateListVm>> Handle(
            GetStatusCandidateListQuery request, CancellationToken cancellationToken)
        {
            var allStatusCadidates = (await _statusCandidateRepository.ListAllAsync());
            return _mapper.Map<List<StatusCandidateListVm>>(allStatusCadidates);
        }
    }
}