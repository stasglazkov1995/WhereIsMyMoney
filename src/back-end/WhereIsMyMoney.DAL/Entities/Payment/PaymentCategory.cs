
namespace WhereIsMyMoney.DAL.Entities.Payment
{
    internal class PaymentCategory
    {
        public int Id { get; init; }

        public required string Name { get; set; }

        public string? Icon { get; set; }
    }
}
