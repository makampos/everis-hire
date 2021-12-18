using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateInterviewDetail
{
    public class GetCandidateInterviewDetailQueryHandler : 
        IRequestHandler<GetCandidateInterviewDetailQuery, CandidateInterviewDetailVm>
    {
        private readonly IMapper _mapper;
        private readonly ICandidateRepository _candidateRepository;
        
        public GetCandidateInterviewDetailQueryHandler(IMapper mapper,
            ICandidateRepository candidateRepository)
        {
            _mapper = mapper;
            _candidateRepository = candidateRepository;
        }
        
        public async Task<CandidateInterviewDetailVm> Handle(
            GetCandidateInterviewDetailQuery request,
            CancellationToken cancellationToken)
        {
            var candidateToReturn = await _candidateRepository.GetCandidatesWithInclude();
            var candidateToReturnWithInclude = candidateToReturn.Where(
                x => x.CandidateId == request.CandidateId);
            var candidate = candidateToReturnWithInclude.FirstOrDefault();

            if (candidate == null)
            {
                throw new NotFoundException(nameof(Candidate), request.CandidateId);
            }

            var candidateInterviewDetailDto = _mapper.Map<CandidateInterviewDetailVm>(candidate);
            return candidateInterviewDetailDto;
        }
    }
}