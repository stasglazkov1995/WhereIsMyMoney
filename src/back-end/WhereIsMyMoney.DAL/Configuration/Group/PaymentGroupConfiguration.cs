using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;
using WhereIsMyMoney.DAL.Entities.CurrencyManagement;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Configuration.Group;

public class PaymentGroupConfiguration: BaseEntityTypeConfiguration<PaymentGroup>
{
    public override void Configure(EntityTypeBuilder<PaymentGroup> modelBuilder)
    {
        base.Configure(modelBuilder);

        modelBuilder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();

        modelBuilder.Property(x => x.CreatedById)
            .IsRequired();

        modelBuilder.Property(x => x.CurrencyId)
            .IsRequired();

        modelBuilder.HasOne(q => q.CreatedBy)
            .WithMany(q=> q.PaymentGroups)
            .HasForeignKey(q => q.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.HasOne(q => q.Currency)
            .WithMany(q => q.PaymentGroups)
            .HasForeignKey(q => q.CurrencyId)
            .OnDelete(DeleteBehavior.Restrict);

        modelBuilder.HasMany(q => q.Users)
            .WithMany(q => q.PaymentGroups)
            .UsingEntity<Dictionary<string,object>>("GroupToUser",
                q => q.HasOne<User>()
                      .WithMany()
                      .HasForeignKey("Id")
                      .OnDelete(DeleteBehavior.Cascade),

                q => q.HasOne<PaymentGroup>()
                      .WithMany()
                      .HasForeignKey("Id")
                      .OnDelete(DeleteBehavior.Cascade)

             );
    }
}