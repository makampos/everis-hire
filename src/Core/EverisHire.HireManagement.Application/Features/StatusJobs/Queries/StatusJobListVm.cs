using System;

namespace EverisHire.HireManagement.Application.Features.StatusJobs.Queries
{
    public class StatusJobListVm
    {
         public Guid StatusJobId { get; set; } 
        public int Code { get; set; }
        public string Description { get; set; }  
        
    }
}