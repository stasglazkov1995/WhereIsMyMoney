﻿
namespace WhereIsMyMoney.DAL.Entities.Payment
{
    public class Currency
    {
        public int Id { get; init; }
        public required string Name { get; set; }
        public required string Code { get; set; }
    }
}
