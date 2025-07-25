using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class ProductConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
    {
        builder.ToTable("productos");

        builder.HasKey(s => s.ProductId);
        builder.Property(e => e.ProductId).HasColumnName("codigoProducto");
        builder.Property(e => e.ProductName).HasColumnName("nombreProducto");
        builder.Property(e => e.StockQuantity).HasColumnName("cantidadStorage");
    }
}
