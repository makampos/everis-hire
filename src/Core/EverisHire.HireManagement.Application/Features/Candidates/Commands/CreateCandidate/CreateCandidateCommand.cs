using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateCommand : IRequest<Guid>
    {        
        public string Name { get; set; }
        public Guid StatusCandidateId { get; set; }
        public Guid AllocationTypeId { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }
        public decimal SalaryClaim { get; set; }
        public string City { get; set; }
        public string Technology { get; set; }
        public string LeaderCenters { get; set; }
        public string Recruiter { get; set; }
        public string Resume { get; set; }
    }
}