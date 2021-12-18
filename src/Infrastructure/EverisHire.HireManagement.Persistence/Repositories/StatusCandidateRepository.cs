using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class StatusCandidateRepository: BaseRepository<StatusCandidate>, IStatusCandidateRepository
    {
        public StatusCandidateRepository(EverisHireDbContext dbContext)
            : base(dbContext)
        { }
    }
}