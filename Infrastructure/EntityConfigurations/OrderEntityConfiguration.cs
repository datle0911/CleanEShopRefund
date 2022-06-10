using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class OrderEntityConfiguration : IEntityTypeConfiguration<Order>
{
    public void Configure(EntityTypeBuilder<Order> builder)
    {
        builder
            .HasKey(o => o.Id);
        builder
            .Property(o => o.Id)
            .HasMaxLength(10)
            .IsRequired();

        builder
            .HasOne(o => o.Customer)
            .WithMany()
            .HasForeignKey(o => o.CustomerId);

        builder
            .OwnsOne(o => o.Refund,
            r =>
            {
                r.WithOwner()
                    .HasForeignKey(r => r.OrderId);
                r.HasKey(r => r.OrderId);
                r.Property(r => r.Status)
                    .IsRequired();
                r.Property(r => r.Proportion)
                    .IsRequired();
                r.Property(r => r.Timestamp)
                    .IsRequired();
            });

        builder
            .Property(o => o.PurchaseCode)
            .HasMaxLength(15)
            .IsRequired(false);

        builder
            .Property(o => o.Timestamp)
            .IsRequired();

        builder
            .Property(o => o.Tracking)
            .IsRequired();

        builder
            .Property(o => o.Address)
            .HasMaxLength(255)
            .IsRequired();

        builder
            .Property(o => o.Status)
            .IsRequired();

        builder
            .Property(o => o.TotalPrice)
            .IsRequired();
    }
}
