using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class AllocationTypeRepository: BaseRepository<AllocationType>, IAllocationTypeRepository
    {
        public AllocationTypeRepository(EverisHireDbContext dbContext) : base(dbContext)
        {
        }
    }
}