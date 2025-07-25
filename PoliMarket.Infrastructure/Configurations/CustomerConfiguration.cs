using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class CustomerConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder.ToTable("clientes");

        builder.HasKey(s => s.CustomerId);
        builder.Property(e => e.CustomerId).HasColumnName("codigoCli");
        builder.Property(e => e.IdType).HasColumnName("tipoIdentificacionCli");
        builder.Property(e => e.Identification).HasColumnName("identificacionCli");
        builder.Property(e => e.Name).HasColumnName("nombreCli");
        builder.Property(e => e.Address).HasColumnName("direccionCli");
        builder.Property(e => e.StatusId).HasColumnName("codEstado");
    }
}
