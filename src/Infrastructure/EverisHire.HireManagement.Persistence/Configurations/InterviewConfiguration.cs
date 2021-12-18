using EverisHire.HireManagement.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EverisHire.HireManagement.Persistence.Configurations
{
    public class InterviewConfiguration: IEntityTypeConfiguration<Interview>
    {
        public void Configure(EntityTypeBuilder<Interview> builder)
        {
            builder.HasKey(x => x.InterviewId);
            builder.HasOne(value => value.StatusInterview)
                .WithMany(value => value.Interviews)
                .HasForeignKey(value => value.StatusInterviewId)
                .IsRequired();
            builder.HasKey(x => x.InterviewId);
            builder.HasOne(x => x.Job)
                .WithOne(s => s.Interview)
                .HasForeignKey<Interview>(y => y.JobId)
                .IsRequired();
        }
    }
}