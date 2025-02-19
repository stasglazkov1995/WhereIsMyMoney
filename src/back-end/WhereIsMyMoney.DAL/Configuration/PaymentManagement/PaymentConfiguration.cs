using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.PaymentManagement;


namespace WhereIsMyMoney.DAL.Configuration.PaymentManagement
{
    public class PaymentConfiguration : BaseEntityTypeConfiguration<Payment>
    {
        public override void Configure(EntityTypeBuilder<Payment> modelBuilder)
        {
            base.Configure(modelBuilder);
            
            modelBuilder
                .Property(p => p.Name)
                .HasMaxLength(100)
                .IsRequired();

            modelBuilder
                .Property(p => p.Amount)
                .IsRequired();

            modelBuilder
                .HasOne(p => p.PaymentGroup)
                .WithMany(pg => pg.Payments)
                .HasForeignKey(p => p.PaymentGroupId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
