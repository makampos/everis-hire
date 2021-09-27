using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class LtfRepository : BaseRepository<Ltf>, ILtfRepository
    {
        public LtfRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}