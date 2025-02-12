using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Entities.Group;

public record PaymentGroup(string Name, int CreatedById) : EntityBase
{
    public string Name { get; set; } = Name;
    public int CreatedById { get; set; } = CreatedById;
    public User CreatedBy { get; set; }
}