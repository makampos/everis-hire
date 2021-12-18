using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Application.Features.Candidates.Queries.GetCandidateListQuery;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class CandidateRepository: BaseRepository<Candidate>, ICandidateRepository
    {
        public CandidateRepository(EverisHireDbContext dbContext) 
            : base(dbContext){}

        public async Task<List<Candidate>> GetCandidatesWithInclude()
        {
            return await _dbContext.Candidates
                .Include(x => x.StatusCandidate)
                .Include(x => x.AllocationType)
                .ToListAsync();
        }

        public async Task<List<Candidate>> GetCandidatesNotInInterview()
        {
            /*SETAR O GUID "DISPONÍVEL"*/
            var candidates = await (from candidate in _dbContext.Candidates
                where _dbContext.Candidates.Any(x => 
                    x.StatusCandidateId == Guid.Parse("86829568-fa06-497a-9179-d88ebd1ff876") 
                    && !_dbContext.Interviews.Any(f => f.CandidateId == candidate.CandidateId)
                    ) select candidate).ToListAsync();
            return candidates;
        }
    }
}