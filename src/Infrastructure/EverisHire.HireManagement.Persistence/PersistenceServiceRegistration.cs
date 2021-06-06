
using EverisHire.HireManagement.Persistence.Repositories;
using EverisHire.HireManagement.Application.Contracts.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EverisHire.HireManagement.Persistence
{
    public static class PersistenceServiceRegistration
    {
         public static IServiceCollection AddPersistenceServices(
             this IServiceCollection services, IConfiguration configuration)
        {
            services.AddDbContext<EverisHireDbContext>(options => {
                options.UseMySql(configuration.GetConnectionString("DefaultConnection"));
            });
            services.AddScoped(typeof(IAsyncRepository<>), 
            typeof(BaseRepository<>));

            services.AddScoped<ICategoryRepository, CategoryRepository>();
            services.AddScoped<IEventRepository, EventRepository>();
            services.AddScoped<IOrderRepository, OrderRepository>();

            services.AddScoped<IProjectRepository, ProjectRepository>();
            services.AddScoped<ICandidateRepository, CandidateRepository>();

            services.AddScoped<IJobRepository, JobRepository>();
            services.AddScoped<IRecruiterRepository, RecruiterRepository>();        
            services.AddScoped<ITechnologyRepository, TechnologyRespository>();   


            return services;    
        }
    }
}