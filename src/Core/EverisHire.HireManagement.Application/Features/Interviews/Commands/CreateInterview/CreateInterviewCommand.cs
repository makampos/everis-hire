using System;
using EverisHire.HireManagement.Domain.Entities;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand
{
    public class CreateInterviewCommand : IRequest<Guid>
    {
        public string CandidateName { get; set; }
        public int EverJob { get; set; }
        
        /*Candidate Data*/
        public string AllocationTypeDescription { get; set; }
        public string City { get; set; }
        public string RecruiterName { get; set; }
        public string Technology { get; set; }
        public int YearsOfExperience { get; set; }
        public DateTime CandidateCreatedDate { get; set; }
        public string StatusDescription { get; set; }
        public decimal SalaryClaim { get; set; }
        
        /*Job Data*/
        public string LeaderCenters { get; set; }
        public string LtfOrPl { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public Guid ProjectId { get; set; }
        public string JobRecruiterName { get; set; }
        public string JobTechnology { get; set; }
        public int JobYearsOfExperience { get; set; }
        public decimal MaximumSalary { get; set; }
        
        /*InterView Data*/
        public DateTime DateInterView { get; set; }
        public DateTime AvailableDate { get; set; }
        public string InterviewerLeaderCenters { get; set; }
        public string TechnicalInterviewer { get; set; }
        public decimal Offer { get; set; }
        public Guid StatusInterviewId { get; set; }

        /*Navigation Property*/
        public Guid CandidateId { get; set; }
        public Guid JobId { get; set; }
        // public virtual Candidate Candidate { get; set; }
        // public virtual Job Job { get; set; }
    }
}