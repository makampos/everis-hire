using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class ProjectConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(value => value.ProjectId);
            builder.HasMany(value => value.Jobs);
                    
            builder.Property(value => value.Name)
                .IsRequired()
                .HasMaxLength(30);

            builder.Property(value => value.Description)
                .IsRequired()
                .HasMaxLength(1000);                                   
        }
    }
}