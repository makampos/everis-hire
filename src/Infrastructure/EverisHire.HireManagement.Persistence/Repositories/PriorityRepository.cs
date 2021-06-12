using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class PriorityRepository :BaseRepository<Priority>, 
        IPriorityRepository
    {
        public PriorityRepository(EverisHireDbContext dbContext)
             : base(dbContext)
        {
        }
    }
}