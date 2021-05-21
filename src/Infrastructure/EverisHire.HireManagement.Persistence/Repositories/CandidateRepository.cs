using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class CandidateRepository: BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(EverisHireDbContext dbContext) 
            : base(dbContext){}

        public Task<Candidate> GetCandidateWithJob(int id)
        {
            throw new System.NotImplementedException();
        }
    }
}