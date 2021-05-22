using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Exceptions;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands.UpdateCandidate
{
    public class UpdateCandidateCommandHandler :
        IRequestHandler<UpdateCandidateCommand>
    {
        private readonly IMapper mapper;
        private readonly ICandidateRepository candidateRepository;

        public UpdateCandidateCommandHandler(IMapper mapper, ICandidateRepository candidateRepository)
        {
            this.mapper = mapper;
            this.candidateRepository = candidateRepository;
        }
        public async Task<Unit> Handle(
            UpdateCandidateCommand request,
            CancellationToken cancellationToken)
        {
            var candidateUpdate = await candidateRepository.GetByIdAsync(request.CandidateId);

            if (candidateUpdate == null) 
            {
                throw new NotFoundException(nameof(Candidate), request.CandidateId);
            }

            mapper.Map(request, candidateUpdate,
            typeof(UpdateCandidateCommand),
            typeof(Candidate));

            await candidateRepository.UpdateAsync(candidateUpdate);

            return Unit.Value;
        }
    }
}