

using System;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;
using Microsoft.AspNetCore.Http;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateCommandHandler
        : IRequestHandler<CreateCandidateCommand, Guid>
    {
        private readonly IAsyncRepository<Candidate> _candidateRepository;
        private readonly IMapper _mapper;
        private readonly IHttpContextAccessor _httpContextAccessor;
        public CreateCandidateCommandHandler(IMapper mapper, IHttpContextAccessor httpContextAccessor, IAsyncRepository<Candidate> candidateRepository)
        {
            _mapper = mapper;
            _httpContextAccessor = httpContextAccessor;
            _candidateRepository = candidateRepository;
        }
        public async Task<Guid> Handle(
            CreateCandidateCommand request,
            CancellationToken cancellationToken)
        {
            var createCandidateCommandResponse = new CreateCandidateCommandResponse();

            var validator = new CreateCandidateCommandValidator();
            var validationResult = await validator.ValidateAsync(request);

            if (validationResult.Errors.Count > 0 )
            {
                throw new Exceptions.ValidationException(validationResult);
            }

            var @candidate = _mapper.Map<Candidate>(request);

            @candidate = await _candidateRepository.AddAsync(@candidate);
            
            return @candidate.CandidateId;
        }

    }
}