using System;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Jobs.Commands.CreateJob
{
    public class CreateJobCommand : IRequest<CreateJobCommandResponse>
    {
        public int EverJob { get; set; }        
        public string LeaderCenters { get; set; }
        public string LtfOrPl { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public string Squad { get; set; }
        public Guid ProjectId { get; set; }
        public Guid AllocationTypeId { get; set; }
        public DateTime? OpeningDate { get; set; }
        public string Technology { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime? DesiredDate { get; set; }
        public decimal MaximumSalary { get; set; }
        public string Recruiter { get; set; }
        public int? Priority { get; set; }
        public DateTime? PriorityDate { get; set; }
        public Guid StatusJobId { get; set; }
        public string Justification { get; set; }           
    }
}