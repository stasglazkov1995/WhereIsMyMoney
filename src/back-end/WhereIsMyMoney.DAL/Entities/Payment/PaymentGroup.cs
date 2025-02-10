using System.ComponentModel.DataAnnotations;
using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public record class PaymentGroup : EntityBase
    {
        [Required]
        public required string Name {  get; set; }

        [Required]
        public required int CurrencyId { get; set; }

        public int CreatedBy { get; set; }


}
}
