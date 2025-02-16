using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WhereIsMyMoney.DAL.Context;

public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<WhereIsMyMoneyDbContext>
{
    public WhereIsMyMoneyDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder = new DbContextOptionsBuilder<WhereIsMyMoneyDbContext>();
        optionsBuilder.UseSqlServer("Data Source=blog.db");

        return new WhereIsMyMoneyDbContext(optionsBuilder.Options);
    }
}