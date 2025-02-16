using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.UserManagement;
using WhereIsMyMoney.DAL.Entities.CurrencyManagement;

namespace WhereIsMyMoney.DAL.Entities.Group;

public record PaymentGroup(string Name, int CreatedById, int CurrencyId) : EntityBase
{
    public string Name { get; set; } = Name;
    public int CreatedById { get; set; } = CreatedById;
    public User CreatedBy { get; set; }
    public int CurrencyId { get; set; } = CurrencyId;
    public Currency Currency { get; set; }

}