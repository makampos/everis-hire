using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands.DeleteCandidate
{
    public class DeleteCandidateCommand : IRequest
    {
        public Guid CandidateId { get; set; }
    }
}