using System;
using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class StatusJobConfiguration: IEntityTypeConfiguration<StatusJob>
    {
        public void Configure(EntityTypeBuilder<StatusJob> builder)
        {
            builder.HasKey(value => value.StatusJobId);
            
        }
    }
}