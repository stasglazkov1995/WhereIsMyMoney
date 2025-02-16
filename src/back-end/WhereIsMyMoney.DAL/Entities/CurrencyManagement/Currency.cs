using WhereIsMyMoney.DAL.Entities.Abstract;
using WhereIsMyMoney.DAL.Entities.Group;

namespace WhereIsMyMoney.DAL.Entities.CurrencyManagement
{
    public record Currency(string Name, string Code, string Symbol) : EntityBase
    {
        public string Name { get; set; } = Name;
        public string Code { get; set; } = Code;
        public string Symbol { get; set; } = Symbol;
        public ICollection<PaymentGroup> PaymentGroups { get; set; }

    }
}
