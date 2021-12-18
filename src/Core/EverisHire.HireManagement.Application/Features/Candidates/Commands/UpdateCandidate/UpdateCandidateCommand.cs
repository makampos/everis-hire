using System;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands.UpdateCandidate
{
    public class UpdateCandidateCommand : IRequest
    {
        public Guid CandidateId { get; set; }
        public string Name { get; set; }
        public Guid StatusCandidateId { get; set; }
        public string AlocationType { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }
        public string City { get; set; }
        public decimal SalaryClaim { get; set; }

        public string Technology { get; set; }

        public string leaderCenters { get; set; }

        public string Recruiter { get; set; }

        public string Resume { get; set; }
        // public virtual Job Job { get; set; }
        // public Guid JobId { get; set; }
        
    }
}