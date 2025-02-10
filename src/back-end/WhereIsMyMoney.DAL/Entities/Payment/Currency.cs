using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public class Currency
    {
        public int Id { get; set; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
