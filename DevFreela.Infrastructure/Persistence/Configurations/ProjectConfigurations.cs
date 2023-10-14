using DevFreela.Core.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DevFreela.Infrastructure.Persistence.Configurations
{
    public class ProjectConfigurations: IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.HasKey(p => p.Id);

            builder.HasOne(f => f.Freelancer)
                .WithMany(f => f.FreelanceProjects)
                .HasForeignKey(f => f.IdFreelancer)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(c => c.Client)
                .WithMany(c => c.OwnedProjects)
                .HasForeignKey(c => c.IdClient)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
