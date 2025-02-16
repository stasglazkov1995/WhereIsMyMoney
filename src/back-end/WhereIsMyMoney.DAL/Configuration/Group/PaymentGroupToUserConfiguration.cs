using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;

namespace WhereIsMyMoney.DAL.Configuration.Group;

public class PaymentGroupToUserConfiguration : BaseEntityTypeConfiguration<PaymentGroupToUser>
{
    public override void Configure(EntityTypeBuilder<PaymentGroupToUser> modelBuilder)
    {
        base.Configure(modelBuilder);

        modelBuilder
            .HasKey(pgu => new { pgu.UserId, pgu.PaymentGroupId });

        modelBuilder
            .HasOne(pgu => pgu.User)
            .WithMany(u => u.PaymentGroupToUsers)
            .HasForeignKey(pgu => pgu.UserId);

        modelBuilder
            .HasOne(pgu => pgu.PaymentGroup)
            .WithMany(pg => pg.PaymentGroupToUsers)
            .HasForeignKey(pgu => pgu.PaymentGroupId);
    }
}