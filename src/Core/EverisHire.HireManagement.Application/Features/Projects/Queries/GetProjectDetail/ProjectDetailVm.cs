using System;
using System.Collections.Generic;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Features.Projects.Queries.GetProjectDetail
{
    public class ProjectDetailVm
    {
        public Guid ProjectId { get; set; }
        public string name { get; set; }
        public string Description { get; set; }
                
    }
}