using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class ManagerSpRepository : BaseRepository<ManagerSp>, IManagerSpRepository
    {
        public ManagerSpRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}