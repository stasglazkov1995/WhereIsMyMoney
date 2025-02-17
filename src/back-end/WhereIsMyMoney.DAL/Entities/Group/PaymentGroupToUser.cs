using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Entities.Group
{
    public record PaymentGroupToUser
    {
        public int Id { get; init; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int PaymentGroupId { get; set; }
        public PaymentGroup PaymentGroup { get; set; }

    }
}
