using System;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Features.Candidates.Commands
{
    public class CreateCandidateDto
    {
         public Guid CandidateId { get; set; }       
         public string Name { get; set; }
         public Job Job { get; set; }
    }
}