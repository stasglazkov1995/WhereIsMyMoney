using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WhereIsMyMoney.DAL.Entities.Abstract;

namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public record class PaymentGroup : EntityBase
    {
        public required string Name {  get; set; }
        public required int CurrencyId { get; set; }

    }
}
