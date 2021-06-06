using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class TechnologyRespository : BaseRepository<Technology>, ITechnologyRepository
    {
        public TechnologyRespository(EverisHireDbContext dbContext)
             : base(dbContext)
        {
        }
    }
}