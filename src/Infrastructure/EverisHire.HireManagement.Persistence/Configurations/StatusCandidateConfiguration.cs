using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class StatusCandidateConfiguration : IEntityTypeConfiguration<StatusCandidate>
    {
        public void Configure(EntityTypeBuilder<StatusCandidate> builder)
        {
            builder.HasKey(value => value.StatusCandidateId);
           
        }
    }
}