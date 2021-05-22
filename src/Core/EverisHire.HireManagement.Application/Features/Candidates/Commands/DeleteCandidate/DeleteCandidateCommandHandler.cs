using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands.DeleteCandidate
{
    public class DeleteCandidateCommandHandler :
        IRequestHandler<DeleteCandidateCommand>
    {
        private readonly IMapper mapper;
        private readonly ICandidateRepository candidateRepository;
        public DeleteCandidateCommandHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            this.mapper = mapper;
            this.candidateRepository = candidateRepository;
        }
        public async Task<Unit> Handle(
            DeleteCandidateCommand request,
            CancellationToken cancellationToken)
        {
            var candidateToDelete = await candidateRepository.GetByIdAsync(request.CandidateId);
            if (candidateToDelete == null) 
            {
                throw new NotFoundException(nameof(Candidate), request.CandidateId);
            }
            await candidateRepository.DeleteAsync(candidateToDelete);
            
            return Unit.Value;
        }
    }
}