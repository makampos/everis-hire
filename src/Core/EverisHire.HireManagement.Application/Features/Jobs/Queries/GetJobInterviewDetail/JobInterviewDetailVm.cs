using System;

namespace EverisHire.HireManagement.Application.Features.Jobs.Queries.GetJobInterviewDetail
{
    public class JobInterviewDetailVm
    {
        public Guid JobId { get; set; }
        public Guid ProjectId { get; set; }
        public int EverJob { get; set; }
        public string LtfOrPl { get; set; }
        public string ManagerSp { get; set; }
        public string Community { get; set; }
        public string Technology { get; set; }
        public int JobYearsOfExperience { get; set; }
        public decimal MaximumSalary { get; set; }
        public string JobRecruiterName { get; set; }
    }
}