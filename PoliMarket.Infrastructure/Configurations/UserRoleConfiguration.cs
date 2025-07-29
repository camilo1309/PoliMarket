using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class UserRoleConfiguration : IEntityTypeConfiguration<UserRole>
{
    public void Configure(EntityTypeBuilder<UserRole> builder)
    {
        builder.ToTable("UsuarioRol");

        builder.HasKey(pp => new { pp.UserId, pp.RoleId });
        builder.Property(e => e.UserId).HasColumnName("codUsuario");
        builder.Property(e => e.RoleId).HasColumnName("codRol");
    }
}
