using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class RecruiterRepository : BaseRepository<Recruiter>, IRecruiterRepository
    {
        public RecruiterRepository(EverisHireDbContext dbContext)
             : base(dbContext)
        {
        }
    }
}