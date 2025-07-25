using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class UserConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder.ToTable("usuarios");

        builder.HasKey(s => s.UserId);
        builder.Property(e => e.UserId).HasColumnName("codUsuario");
        builder.Property(e => e.FirstName).HasColumnName("nomUsuario");
        builder.Property(e => e.LastName).HasColumnName("apeUsuario");
        builder.Property(e => e.Password).HasColumnName("contraseña");
        builder.Property(e => e.StatusId).HasColumnName("codEstado");
        builder.Property(e => e.StartDate).HasColumnName("fecInicio");
    }
}
