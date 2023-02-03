using EgzaminS22323.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EgzaminS22323.Configurations
{
    public class TaskTypeConfig : IEntityTypeConfiguration<TaskType>
    {
        public void Configure(EntityTypeBuilder<TaskType> builder)
        {
            builder.HasKey(e => e.IdTaskType);
            builder.Property(e => e.IdTaskType).UseIdentityColumn();

            builder.Property(e => e.Name).HasMaxLength(100).IsRequired();
        }
    }
}
