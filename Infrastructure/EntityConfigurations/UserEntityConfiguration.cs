using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.EntityConfigurations;

public class UserEntityConfiguration : IEntityTypeConfiguration<User>
{
    public void Configure(EntityTypeBuilder<User> builder)
    {
        builder
            .HasKey(u => u.Id);
        builder
            .Property(u => u.Id)
            .ValueGeneratedOnAdd();

        builder
            .Property(u => u.UserName)
            .HasMaxLength(20)
            .IsRequired();
        builder
            .HasIndex(u => u.UserName)
            .IsUnique();

        builder
            .Property(u => u.Passwords)
            .HasMaxLength(20)
            .IsRequired();

        builder
            .Property(u => u.FullName)
            .HasMaxLength(40)
            .IsRequired();

        builder
            .Property(u => u.PhoneNumber)
            .HasMaxLength(10)
            .IsRequired();

        builder
            .Property(u => u.Role)
            .IsRequired();
    }
}
