using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class JobRepository : BaseRepository<Job>
    {
        public JobRepository(EverisHireDbContext dbContext) 
            : base(dbContext){}        
    }
}