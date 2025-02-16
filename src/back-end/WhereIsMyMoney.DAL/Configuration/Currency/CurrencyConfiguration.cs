using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Configuration.Abstract;
using WhereIsMyMoney.DAL.Entities.CurrencyManagement;
    
namespace WhereIsMyMoney.DAL.Configuration.CurrencyManagement
{
    public class CurrencyConfiguration : BaseEntityTypeConfiguration<Currency>
    {
        public override void Configure(EntityTypeBuilder<Currency> modelBuilder)
        {
            base.Configure(modelBuilder);
            modelBuilder.Property(x => x.Name)
                .HasMaxLength(100)
                .IsRequired();
            modelBuilder.Property(x => x.Code)
                .HasMaxLength(3)
                .IsRequired();
        }
    }
}
