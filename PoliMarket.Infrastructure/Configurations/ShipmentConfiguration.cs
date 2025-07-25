using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PoliMarket.Domain.Entities;

namespace PoliMarket.Infrastructure.Configurations;

public class ShipmentConfiguration : IEntityTypeConfiguration<Shipment>
{
    public void Configure(EntityTypeBuilder<Shipment> builder)
    {
        builder.ToTable("envios");

        builder.HasKey(s => s.InvoiceId);
        builder.Property(e => e.InvoiceId).HasColumnName("codigoFactura");
        builder.Property(e => e.ReceiverName).HasColumnName("nombreRecibe");
        builder.Property(e => e.ReceiverPhone).HasColumnName("telRecibe");
        builder.Property(e => e.ShippingAddress).HasColumnName("direccionEnvio");
        builder.Property(e => e.ShippingDate).HasColumnName("fechaEnvio");
        builder.Property(e => e.ShippingStatus).HasColumnName("estEnvio");
    }
}
