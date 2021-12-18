using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class StatusInterviewConfiguration: IEntityTypeConfiguration<StatusInterview>
    {
        public void Configure(EntityTypeBuilder<StatusInterview> builder)
        {
            builder.HasKey(value => value.StatusInterviewId);
        }
    }
}