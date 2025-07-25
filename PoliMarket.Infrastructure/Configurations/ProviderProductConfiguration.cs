using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations
{
    public class ProviderProductConfiguration : IEntityTypeConfiguration<ProviderProduct>
    {
        public void Configure(EntityTypeBuilder<ProviderProduct> builder)
        {
            builder.ToTable("ProveedorProducto");

            builder.HasKey(pp => new { pp.ProviderId, pp.ProductId });

            builder.Property(pp => pp.ProviderId).HasColumnName("codigoProve");
            builder.Property(pp => pp.ProductId).HasColumnName("codigoProducto");
            builder.Property(pp => pp.Quality).HasColumnName("Calidad");
        }
    }


}
