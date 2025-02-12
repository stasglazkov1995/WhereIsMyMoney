using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Configuration.Abstract;

public abstract class BaseEntityTypeConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : EntityBase
{
    public virtual void Configure(EntityTypeBuilder<TBase> builder)
    {
        builder.HasKey(q => q.Id);
    }
}