using Microsoft.EntityFrameworkCore;
using WhereIsMyMoney.DAL.Entities.CurrencyManagement;
using WhereIsMyMoney.DAL.Entities.Group;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Context;

public class WhereIsMyMoneyDbContext : DbContext
{
    public virtual DbSet<User> Users { get; set; }
    public virtual DbSet<Currency> Currencies { get; set; }
    public virtual DbSet<PaymentGroup> PaymentGroups { get; set; }
    
    public WhereIsMyMoneyDbContext(DbContextOptions<WhereIsMyMoneyDbContext> options) : base(options)
    {
    }
    
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(typeof(WhereIsMyMoneyDbContext).Assembly);
    }
}