using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class YearsOfExperienceRepository : BaseRepository<YearsOfExperience>, IYearsOfExperienceRepository
    {
        public YearsOfExperienceRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}