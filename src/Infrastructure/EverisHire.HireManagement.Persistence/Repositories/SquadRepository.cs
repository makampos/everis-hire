using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class SquadRepository : BaseRepository<Squad>, ISquadRepository
    {
        public SquadRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}