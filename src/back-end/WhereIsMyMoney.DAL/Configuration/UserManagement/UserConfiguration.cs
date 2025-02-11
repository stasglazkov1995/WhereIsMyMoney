using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Configuration.UserManagement;

public class UserConfiguration : BaseEntityTypeConfiguration<User>
{
    public override void Configure(EntityTypeBuilder<User> modelBuilder)
    {
        base.Configure(modelBuilder);
        modelBuilder.Ignore(x => x.FullName);
            
        modelBuilder.Property(x => x.FirstName)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.Property(x => x.LastName)
            .HasMaxLength(200)
            .IsRequired();
        modelBuilder.Property(x => x.Email)
            .HasMaxLength(255)
            .IsRequired();
        modelBuilder.Property(x => x.Password)
            .HasMaxLength(255)
            .IsRequired();
    }
}