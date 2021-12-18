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
            builder.HasOne(value => value.Interview)
                .WithOne(value => value.Candidate)
                .HasForeignKey<Interview>(value => value.CandidateId);
            
            builder.HasKey(value => value.CandidateId);
            builder.HasOne(value => value.StatusCandidate)
                .WithMany(value => value.Candidates)
                .HasForeignKey(value => value.StatusCandidateId)
                .IsRequired();
            
            builder.HasKey(value => value.CandidateId);
            builder.HasOne(value => value.AllocationType)
                .WithMany(value => value.Candidates)
                .HasForeignKey(value => value.AllocationTypeId)
                .IsRequired();
            
            builder.Property(value => value.Name)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.StatusCandidateId)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.AllocationTypeId)
                .IsRequired()
                .HasMaxLength(50);
            builder.Property(value => value.YearsOfExperience)
                .IsRequired();
            builder.Property(value => value.SalaryClaim)
                .IsRequired();
                
        }
    }
}