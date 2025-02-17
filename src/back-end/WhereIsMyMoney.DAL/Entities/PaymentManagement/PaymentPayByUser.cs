using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Entities.PaymentManagement
{
    public record PaymentPayByUser(decimal Amount, int PaymentId, int UserId)
    {
        public int Id { get; init; }
        public decimal Amount { get; set; } = Amount;
        public int PaymentId { get; set; } = PaymentId;
        public Payment Payment { get; set; }
        public int UserId { get; set; } = UserId;
        public User User { get; set; }

    }
}
