using System;
using System.Collections.Generic; // <--- Add this line
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Models
{
    public class Stock
    {
        public int Id { get; set; }
        public string Symbol { get; set; } = string.Empty;
        public string CompanyName { get; set; } = string.Empty;
        public string CompanyAddress { get; set; } = string.Empty;
        public int PhoneNumber { get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Purchase {get; set; }
        [Column(TypeName = "decimal(18,2)")]
        public decimal Divident {get; set; }
        public string Industry {get; set;} = string.Empty;
        public long MarketCap {get; set;}
        public List<Comment> Comments { get; set; } = new List<Comment>();
    }
}