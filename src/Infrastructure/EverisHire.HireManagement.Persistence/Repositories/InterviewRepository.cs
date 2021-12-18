using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class InterviewRepository: BaseRepository<Interview>, IInterviewRepository
    {
        public InterviewRepository(EverisHireDbContext dbContext)
            : base(dbContext) {}
        
    }
}