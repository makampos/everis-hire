using Microsoft.AspNetCore.Identity;

namespace EverisHire.HireManagement.Identity.Models
{
    public class ApplicationUser : IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}