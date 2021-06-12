using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class StatusJobRepository : BaseRepository<StatusJob>, IStatusJobRepository
    {
        public StatusJobRepository(EverisHireDbContext dbContext) 
            : base(dbContext)
        {
        }
    }
}