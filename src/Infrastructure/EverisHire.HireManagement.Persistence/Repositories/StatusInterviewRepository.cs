using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class StatusInterviewRepository: BaseRepository<StatusInterview>, IStatusInterviewRepository
    {
        public StatusInterviewRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}