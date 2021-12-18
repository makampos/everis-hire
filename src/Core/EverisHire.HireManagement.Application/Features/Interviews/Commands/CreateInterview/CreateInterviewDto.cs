using System;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Features.Interviews.Commands.CreateInterviewCommand
{
    public class CreateInterviewDto
    {
        public Guid InterviewId { get; set; }
        public string CandidateName { get; set; }
        public int EverJob { get; set; }
        
        /*Candidate Data*/
        public string AllocationType { get; set; }
        public string City { get; set; }
        public string CandidateRecruiterName { get; set; }
        public string CandidateTechnology { get; set; }
        public int CandidateYearsOfExperience { get; set; }
        public DateTime CandidateCreatedDate { get; set; }
        public string CandidateStatus { get; set; }
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
        public string InterViewLeaderCenters { get; set; }
        public string TechnicalInterviewer { get; set; }
        public decimal Offer { get; set; }
       

        /*Navigation Property and FK*/
        public Guid StatusInterviewId { get; set; }
        public Guid CandidateId { get; set; }
        public Guid JobId { get; set; }
        
    }
}