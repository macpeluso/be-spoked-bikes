using BeSpokedBikes.Domain.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace BeSpokedBikes.Application.Models
{
    public class CreateSaleModel
    {
        public Guid SaleId { get; set; }
        [DisplayName("Customer")]
        public Guid CustomerId { get; set; }
        [DisplayName("Associate")]
        public Guid SalePersonId { get; set; }
        [DisplayName("Product")]
        public Guid ProductId { get; set; }
        public List<SelectListItem> Products { get; set; }
        public List<SelectListItem> Associates { get; set; }
        public  List<SelectListItem> Customers { get; set; }
        public CreateSaleModel() { }
    }
}
