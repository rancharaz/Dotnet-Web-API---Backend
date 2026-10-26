using System;
using System;
using System.Collections.Generic; // <--- Add this line
using System.ComponentModel.DataAnnotations.Schema;
namespace api.Dtos.Stock;

public class StockDto
{
public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyAddress { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        public decimal Purchase {get; set; }
        public decimal Divident {get; set; }
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
}
