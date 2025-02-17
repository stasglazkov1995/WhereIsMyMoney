using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Entities.PaymentManagement;

namespace WhereIsMyMoney.DAL.Configuration.PaymentManagement
{
    public class PaymentShareWithUserConfiguration
    {
        public void Configure(EntityTypeBuilder<PaymentShareWithUser> modelBuilder)
        {
            modelBuilder
                .Property(p => p.Amount)
                .IsRequired();

            modelBuilder
                .HasKey(ptu => new { ptu.PaymentId, ptu.UserId });

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