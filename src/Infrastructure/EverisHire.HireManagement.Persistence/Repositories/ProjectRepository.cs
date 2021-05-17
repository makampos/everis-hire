using EverisHire.HireManagement.Application.Contracts.Persistence;
using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class ProjectRepository: BaseRepository<Project>,
        IProjectRepository 
    {
        public ProjectRepository(EverisHireDbContext dbContext)
            : base(dbContext){}
                    
        
    }
}