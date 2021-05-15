using System.Threading.Tasks;
using EverisHire.HireManagement.Application.Models.Authentication;

namespace EverisHire.HireManagement.Application.Contracts.Identity
{
    public interface IAuthenticationService
    {
        Task<AuthenticationResponse> AuthenticateAsync(AuthenticationRequest request);
        Task<RegistrationResponse> RegisterAsync(RegistrationRequest request);
    }
}