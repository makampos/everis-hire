using EverisHire.HireManagement.Domain.Entities;

namespace EverisHire.HireManagement.Persistence.Repositories
{
    public class ProjectRepository: BaseRepository<Project>
    {
        public ProjectRepository(EverisHireDbContext dbContext)
            : base(dbContext){}
                    
        
    }
}