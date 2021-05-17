using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class CandidateConfiguration : IEntityTypeConfiguration<Candidate>
    {
        public void Configure(EntityTypeBuilder<Candidate> builder)
        {            
            builder.HasKey(value => value.CandidateId);
            builder.HasOne(value => value.Job);                                

            builder.Property(value => value.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.Status)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.AlocationType)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.YearsOfExperience)
                .IsRequired();
            builder.Property(value => value.SalaryClaim)
                .IsRequired();
                
        }
    }
}