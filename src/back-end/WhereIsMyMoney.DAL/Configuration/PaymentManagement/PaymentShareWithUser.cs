using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.PaymentManagement;

namespace WhereIsMyMoney.DAL.Configuration.PaymentManagement
{
    public class PaymentShareWithUserConfiguration : BaseEntityTypeConfiguration<PaymentShareWithUser>
    {
        public override void Configure(EntityTypeBuilder<PaymentShareWithUser> modelBuilder)
        {
            base.Configure(modelBuilder);

            modelBuilder
                .HasKey(p => p.Id);

            modelBuilder
                .Property(p => p.Amount)
                .IsRequired();

            modelBuilder
                .HasIndex(ptu => new { ptu.PaymentId, ptu.UserId })
                .IsUnique();

            modelBuilder
                .HasOne(ptu => ptu.Payment)
                .WithMany(p => p.PaymentShareWithUsers)
                .HasForeignKey(ptu => ptu.PaymentId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder
                .HasOne(ptu => ptu.User)
                .WithMany(u => u.PaymentShareWithUsers)
                .HasForeignKey(ptu => ptu.UserId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}