using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Entities.PaymentManagement
{
    public record PaymentShareWithUser(decimal Amount, int PaymentId, int UserId) : EntityBase
    {
        public decimal Amount { get; set; } = Amount;
        public int PaymentId { get; set; } = PaymentId;
        public Payment Payment { get; set; }
        public int UserId { get; set; } = UserId;
        public User User { get; set; }
    }
}
