using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class InvoiceConfiguration : IEntityTypeConfiguration<Invoice>
{
    public void Configure(EntityTypeBuilder<Invoice> builder)
    {
        builder.ToTable("facturas");

        builder.HasKey(s => s.InvoiceId);
        builder.Property(e => e.InvoiceId).HasColumnName("codigoFactura");
        builder.Property(e => e.CustomerId).HasColumnName("codigoCli");
        builder.Property(e => e.ProductId).HasColumnName("codigoProducto");
        builder.Property(e => e.QuantitySold).HasColumnName("cantidadVenta");
        builder.Property(e => e.InvoiceDate).HasColumnName("fecFactura");
    }
}
