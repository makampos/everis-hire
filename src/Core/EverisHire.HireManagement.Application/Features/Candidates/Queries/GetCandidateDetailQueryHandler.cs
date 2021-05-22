using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries
{
    public class GetCandidateDetailQueryHandler
        : IRequestHandler<GetCandidateDetailQuery, CandidateDetailVm>
    {
        private readonly IMapper mapper;
        private readonly ICandidateRepository candidateRepository;

        public GetCandidateDetailQueryHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            this.mapper = mapper;
            this.candidateRepository = candidateRepository;
        }
        public async Task<CandidateDetailVm> Handle(
            GetCandidateDetailQuery request,
             CancellationToken cancellationToken)
        {
            var @candidateToReturn = await candidateRepository.GetByIdAsync(request.CandidateId);

            if (candidateToReturn == null) 
            {
                throw new NotFoundException(nameof(Candidate),request.CandidateId);
            }

            var candidateDetailDto = mapper.Map<CandidateDetailVm>(@candidateToReturn);
            
            return candidateDetailDto;
        }
    }
}