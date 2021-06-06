using System;
using System.Collections.Generic;
using MediatR;

namespace EverisHire.HireManagement.Application.Features.YearsOfExperiences.Queries
{
    public class YearsOfExperienceListVm
    {
        public Guid YearsOfExperienceId { get; set; }
        public string ViewValue { get; set; }
        
    }
}