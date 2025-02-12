using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;

namespace WhereIsMyMoney.DAL.Configuration.Group;

public class PaymentGroupConfiguration: BaseEntityTypeConfiguration<PaymentGroup>
{
    public override void Configure(EntityTypeBuilder<PaymentGroup> modelBuilder)
    {
        base.Configure(modelBuilder);
        modelBuilder.Property(x => x.Name)
            .HasMaxLength(100)
            .IsRequired();
        modelBuilder.HasOne(q => q.CreatedBy)
            .WithMany(q=> q.PaymentGroups)
            .HasForeignKey(q => q.CreatedById)
            .OnDelete(DeleteBehavior.Restrict);
    }
}