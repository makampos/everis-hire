using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface IJobRepository: IAsyncRepository<Job>
    {
        Task<List<Job>> GetJobWithInclude();
        Task<List<Job>> GetJobByStatusOpen();
        Task<Job> GetJobByEverjobAsync(int everJob);
    }
}