using AutoMapper;
using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Models
{
    [AutoMap(typeof(Sale))]
    public class SaleModel
    {
        public Guid SaleId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid SalePersonId { get; set; }
        public Guid ProductId { get; set; }
        [IgnoreMap]
        public string CustomerName => this.Customer != null ? this.Customer.FirstName + " " +this.Customer.LastName : "";
        [IgnoreMap]
        public string AssociateName => this.SalesPerson != null ? this.SalesPerson.FirstName + " "+ this.SalesPerson.LastName : "";
        [IgnoreMap]
        public string ProductName => this.Product?.Name;
        [IgnoreMap]
        public decimal? SalePrice => this.Product?.SalePrice;
        [IgnoreMap]
        public decimal Commission => this.Product != null ? this.Product.CommissionPercentage * this.Product.PurchasePrice : 0.00M;
        [IgnoreMap]
        public string SaleDate => this.Date.Date.ToShortDateString();
        public DateTimeOffset Date { get; set; }
        public CustomerModel Customer { get; set; }
        public SalesPersonModel SalesPerson { get; set; }
        public ProductModel Product { get; set; }
    }
}
