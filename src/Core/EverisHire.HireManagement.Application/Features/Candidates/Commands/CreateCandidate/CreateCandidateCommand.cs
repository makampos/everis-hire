using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateCommand : IRequest<Guid>
    {        
        public string Name { get; set; }
        public string Status { get; set; }
        public string AlocationType { get; set; }
        public int YearsOfExperience { get; set; }
        public string WhoIndicated { get; set; }
        public decimal SalaryClaim { get; set; }
        public Guid JobId { get; set; }
    }
}