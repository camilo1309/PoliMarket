using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations
{
    public class ProviderConfiguration : IEntityTypeConfiguration<Provider>
    {
        public void Configure(EntityTypeBuilder<Provider> builder)
        {
            builder.ToTable("proveedores");

            builder.HasKey(s => s.ProviderId);
            builder.Property(e => e.ProviderId).HasColumnName("codigoProve");
            builder.Property(e => e.IdType).HasColumnName("tipoIdentificacionProve");
            builder.Property(e => e.Identification).HasColumnName("identificacionProve");
            builder.Property(e => e.Name).HasColumnName("nombreProve");
            builder.Property(e => e.Address).HasColumnName("direccionProve");
            builder.Property(e => e.StatusId).HasColumnName("codEstado");
        }
    }

}
