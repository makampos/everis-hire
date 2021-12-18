using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class AllocationTypeConfiguration: IEntityTypeConfiguration<AllocationType>
    {
        public void Configure(EntityTypeBuilder<AllocationType> builder)
        {
            builder.HasKey(value => value.AllocationTypeId);
        }
    }
}