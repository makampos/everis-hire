using System.Collections.Generic;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Application.Contracts.Persistence
{
    public interface ICandidateRepository : IAsyncRepository<Candidate>
    {
        Task<List<Candidate>> GetCandidatesWithInclude();
        Task<List<Candidate>> GetCandidatesNotInInterview();
    }
}