using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class RoleConfiguration : IEntityTypeConfiguration<Role>
{
    public void Configure(EntityTypeBuilder<Role> builder)
    {
        builder.ToTable("roles");

        builder.HasKey(s => s.RoleId);
        builder.Property(e => e.RoleId).HasColumnName("codRol");
        builder.Property(e => e.RoleName).HasColumnName("nombreRol");
    }
}
