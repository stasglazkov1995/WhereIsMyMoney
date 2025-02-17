using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;

namespace WhereIsMyMoney.DAL.Entities.PaymentManagement;

public record Payment(decimal Amount, string Name, int CreatedById, int PaymentGroupId) : EntityBase
{
    public string Name { get; set; } = Name;
    public decimal Amount { get; set; } = Amount;
    public int CreatedById { get; set; } = CreatedById;
    public int PaymentGroupId { get; set; } = PaymentGroupId;
    public PaymentGroup PaymentGroup { get; set; }
    public bool IsDeleted { get; set; } = false;
}
