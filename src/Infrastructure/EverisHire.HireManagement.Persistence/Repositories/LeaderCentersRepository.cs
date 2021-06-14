using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class LeaderCentersRepository : BaseRepository<LeaderCenters>, ILeaderCentersRepository
    {
        public LeaderCentersRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}