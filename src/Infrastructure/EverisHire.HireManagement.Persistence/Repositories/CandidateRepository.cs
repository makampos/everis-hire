using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class CandidateRepository: BaseRepository<Candidate>
    {
        public CandidateRepository(EverisHireDbContext dbContext) 
            : base(dbContext){}
    }
}