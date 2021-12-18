using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class JobRepository : BaseRepository<Job>, IJobRepository
    {
        public JobRepository(EverisHireDbContext dbContext) 
            : base(dbContext){}

        public async Task<List<Job>> GetJobWithInclude()
        {
            return await _dbContext.Jobs
                .Include(x => x.AllocationType)
                .Include(x => x.Project)
                .Include(x => x.StatusJob)
                .ToListAsync();
        }

        public async Task<List<Job>> GetJobByStatusOpen()
        {
            /*SETAR O GUID "EM ABERTO"*/
            var jobs = await (from job in _dbContext.Jobs
                where _dbContext.Jobs.Any(x => 
                    x.StatusJobId == Guid.Parse("8b5b6de5-7af8-497a-b4a9-af51dbde126f") 
                    && !_dbContext.Interviews.Any(f => f.JobId == job.JobId)
                ) select job).ToListAsync();

            return jobs;
        }

        public  async Task<Job> GetJobByEverjobAsync(int everjob)
        {
            return  await _dbContext.Jobs.FirstOrDefaultAsync(x => x.EverJob == everjob);
        }
    }
}