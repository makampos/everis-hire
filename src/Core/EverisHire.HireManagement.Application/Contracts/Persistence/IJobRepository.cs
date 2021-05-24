using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface IJobRepository: IAsyncRepository<Job>
    {
        
    }
}