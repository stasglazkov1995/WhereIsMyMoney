
namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public class UserToPaymentGroup
    {
        public int Id { get; init; }
        public required int UserId { get; set; }
        public required int GroupId { get; set; }

    }
}
