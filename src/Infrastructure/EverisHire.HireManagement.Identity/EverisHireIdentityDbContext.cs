using EverisHire.HireManagement.Identity.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace EverisHire.HireManagement.Identity
{
    public class EverisHireIdentityDbContext :IdentityDbContext<ApplicationUser>
    {
        public EverisHireIdentityDbContext(DbContextOptions<EverisHireIdentityDbContext> options) 
            : base(options)
        {
        }
    }
}