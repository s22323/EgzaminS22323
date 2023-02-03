using EgzaminS22323.Models;
using Microsoft.EntityFrameworkCore;

namespace EgzaminS22323.Configurations
{
    public class TeamMemberConfig : IEntityTypeConfiguration<TeamMember>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<TeamMember> builder)
        {
            builder.HasKey(e => e.IdTeamMember);
            builder.Property(e => e.IdTeamMember).UseIdentityColumn();

            builder.Property(e => e.FirstName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.LastName).HasMaxLength(100).IsRequired();
            builder.Property(e => e.Email).HasMaxLength(100).IsRequired();
        }
    }
}
