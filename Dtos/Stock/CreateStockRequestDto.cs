using System;

namespace api.Dtos.Stock;

public class CreateStockRequestDto
{
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyAddress { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public decimal Purchase {get; set; }
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
}
