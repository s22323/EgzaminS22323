using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using EgzaminS22323.Models;
using Task = EgzaminS22323.Models.Task;

namespace EgzaminS22323.Configurations
{
    public class TaskConfig : IEntityTypeConfiguration<Task>
    {
        public void Configure(EntityTypeBuilder<Task> builder)
        {
            builder.HasKey(e => e.IdTask);
            builder.Property(e => e.IdTask).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Description).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Deadline).IsRequired();

            builder.HasOne(e => e.IProjectNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTeam)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.ITaskTypeNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdTaskType)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(e => e.IAssignedToNavigation)
                .WithMany(e => e.Tasks)
                .HasForeignKey(e => e.IdAssignedTo)
                .OnDelete(DeleteBehavior.Restrict);

        }
    }
}
