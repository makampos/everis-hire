using System.Threading.Tasks;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface ICandidateRepository : IAsyncRepository<Candidate>
    {
        Task<Candidate> GetCandidateWithJob(int id);
    }
}