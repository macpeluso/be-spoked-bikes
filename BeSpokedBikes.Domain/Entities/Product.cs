using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeSpokedBikes.Domain.Entities
{
    public class Product
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        public decimal SalePrice { get; set; }
        public decimal PurchasePrice { get; set; }
        public decimal CommissionPercentage { get; set; }
        public int Quantity { get; set; }
        public virtual List<Sale> Sales { get; set; }
    }
}
