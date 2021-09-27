using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Models.Mail;

namespace EverisHire.HireManagement.Application.Contracts.Infrastructure
{
    public interface IEmailService
    {
        Task<bool> SendEmail(Email email);
    }
}