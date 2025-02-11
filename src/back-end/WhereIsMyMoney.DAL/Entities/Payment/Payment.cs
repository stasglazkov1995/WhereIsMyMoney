using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public record Payment : EntityBase
    {
        public required int PaymentGroupId { get; set; }

        public required int CreatedBy { get; set; }

        public required decimal Amount { get; set; }

        public int? PaymentCategoryId { get; set; } 

        public bool? Deleted { get; set; }
    }
}
