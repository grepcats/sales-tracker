using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SalesTracker.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        public int ProductId { get; set; }
        public string Name { get; set; }
        public int InventoryTotal { get; set; }
        public decimal WholesalePrice { get; set; }
        public decimal SalePrice { get; set; }

        public void setSalePrice()
        {
            SalePrice = WholesalePrice * (decimal)2.5;
        }
    }
}
