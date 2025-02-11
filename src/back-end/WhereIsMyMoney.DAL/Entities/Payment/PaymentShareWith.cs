
namespace WhereIsMyMoney.DAL.Entities.Payment
{
    internal class PaymentShareWith
    {
        public required int Id { get; init; }

        public required int PaymentId { get; set; }

        public required int UserId { get; set; }

        public decimal Amount { get; set; }
    }
}
