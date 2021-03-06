using EverisHire.HireManagement.Application.Contracts.Infrastructure;
using EverisHire.HireManagement.Application.Models.Mail;
using EverisHire.HireManagement.Infrastructure.Mail;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace EverisHire.HireManagement.Infrastructure
{
    public static class InfrastructureServiceRegistration
    {

        public static IServiceCollection AddInfrastructureServices(
            this IServiceCollection services, IConfiguration configuration)
        {
            services.Configure<EmailSettings>(configuration.GetSection(
                "EmailSettings"));
            services.AddTransient<IEmailService, EmailService>();

            return services;
        }
        
    }
}