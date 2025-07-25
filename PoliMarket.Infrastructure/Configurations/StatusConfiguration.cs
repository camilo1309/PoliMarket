using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class StatusConfiguration : IEntityTypeConfiguration<Status>
{
    public void Configure(EntityTypeBuilder<Status> builder)
    {
        builder.ToTable("estado");

        builder.HasKey(s => s.StatusId);
        builder.Property(e => e.StatusId).HasColumnName("codEstado");
        builder.Property(e => e.StatusName).HasColumnName("nomEstado");
    }
}
