using AutoMapper;
using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Models
{
    [AutoMap(typeof(Product))]
    public class ProductModel
    {
        public Guid ProductId { get; set; }
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Style { get; set; }
        [DisplayName("Sale Price")]
        public decimal SalePrice { get; set; }
        [DisplayName("Purchase Price")]
        public decimal PurchasePrice { get; set; }
        [DisplayName("Commission Percentage")]
        public decimal CommissionPercentage { get; set; }
        public int Quantity { get; set; }
    }

}
