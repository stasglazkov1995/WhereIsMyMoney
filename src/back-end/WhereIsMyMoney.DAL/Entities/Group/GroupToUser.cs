using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.UserManagement;

namespace WhereIsMyMoney.DAL.Entities.Group
{
    public record GroupToUser : EntityBase
    {
        public int UserId { get; set; }
        public User User { get; set; }
        public int GroupId { get; set; }
        public PaymentGroup PaymentGroup { get; set; }

    }
}
