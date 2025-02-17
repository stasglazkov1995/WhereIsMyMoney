using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.CurrencyManagement;
using WhereIsMyMoney.DAL.Entities.PaymentManagement;

namespace WhereIsMyMoney.DAL.Entities.Group;

public record PaymentGroup(string Name, int CreatedById, int CurrencyId) : EntityBase
{
    public string Name { get; set; } = Name;
    public int CreatedById { get; set; } = CreatedById;
    public string CreatedByFullName { get; set; }
    public int CurrencyId { get; set; } = CurrencyId;
    public Currency Currency { get; set; }
    public ICollection<PaymentGroupToUser> PaymentGroupToUsers { get; set; }
    public ICollection<Payment> Payments { get; set; }
}