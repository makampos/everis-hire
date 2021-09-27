using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            builder.HasKey(value => value.JobId);
            builder.HasMany(value => value.Candidates);
            
            builder.Property(value => value.ManagerSp)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(value => value.EverJob)
                .IsRequired();    

            builder.Property(value => value.Status)
                .IsRequired()
                .HasMaxLength(20);  

            builder.Property(value => value.Technology)
                .HasMaxLength(30); 

            builder.Property(value => value.Technology)
                .HasMaxLength(20);
                
            builder.Property(value => value.MaximumSalary)
                .IsRequired();    

            builder.Property(value => value.Justification)
                .HasMaxLength(1000);
                
        }
    }
}