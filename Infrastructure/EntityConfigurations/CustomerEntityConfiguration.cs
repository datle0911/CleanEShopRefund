using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class CustomerEntityConfiguration : IEntityTypeConfiguration<Customer>
{
    public void Configure(EntityTypeBuilder<Customer> builder)
    {
        builder
            .HasKey(c => c.Id);
        builder
            .Property(c => c.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(c => c.UserName)
            .HasMaxLength(20)
            .IsRequired();
        builder
            .HasIndex(c => c.UserName)
            .IsUnique();

        builder
            .Property(c => c.Passwords)
            .IsRequired()
            .HasMaxLength(20);

        builder
            .Property(c => c.FullName)
            .HasMaxLength(40)
            .IsRequired();

        builder
            .Property(c => c.PhoneNumber)
            .HasMaxLength(10)
            .IsRequired();

        builder
            .Property(c => c.Email)
            .IsRequired();
    }
}
