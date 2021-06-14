using System;

namespace EverisHire.HireManagement.Application.Features.Squads.Queries
{
    public class SquadListVm
    {
        public Guid SquadId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
    }
}