using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class JobConfiguration : IEntityTypeConfiguration<Job>
    {
        public void Configure(EntityTypeBuilder<Job> builder)
        {
            
            builder.HasKey(x => x.JobId);
            
            
            builder.HasKey(x => x.JobId);
            builder.HasOne(x => x.Project)
                .WithMany(x => x.Jobs)
                .HasForeignKey(e => e.ProjectId)
                .IsRequired();

            builder.HasKey(x => x.JobId);
            builder.HasOne(value => value.StatusJob)
                .WithMany(value => value.Jobs)
                .HasForeignKey(value => value.StatusJobId)
                .IsRequired();
            
            builder.HasKey(x => x.JobId);
            builder.HasOne(value => value.AllocationType)
                .WithMany(value => value.Jobs)
                .HasForeignKey(value => value.AllocationTypeId)
                .IsRequired();
            
            builder.Property(value => value.ManagerSp)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(value => value.EverJob)
                .IsRequired();    

            builder.Property(value => value.StatusJobId)
                .IsRequired()
                .HasMaxLength(50);  

            builder.Property(value => value.Technology)
                .HasMaxLength(30); 
            
            builder.Property(value => value.MaximumSalary)
                .IsRequired();    

            builder.Property(value => value.Justification)
                .HasMaxLength(1000);
                
        }
    }
}