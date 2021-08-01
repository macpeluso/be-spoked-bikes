using AutoMapper;
using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Application.Queries.Customers;
using BeSpokedBikes.Application.Queries.Products;
using BeSpokedBikes.Application.Queries.Sales;
using BeSpokedBikes.Application.Queries.SalesPeople;
using BeSpokedBikes.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.API.Controllers
{
    public class SalesController : BaseController
    {
        private readonly BSBContext context;
        private readonly IRazorViewToStringRenderer renderer;
        private readonly ISalesQueries queries;
        private readonly IMapper mapper;
        private readonly ICustomerQueries customers;
        private readonly IProductQueries products;
        private readonly ISalesPeopleQueries salesPeople;


        public SalesController(BSBContext context, ISalesQueries queries, IRazorViewToStringRenderer renderer, IMapper mapper, ICustomerQueries customers, IProductQueries products, ISalesPeopleQueries salesPeople)
        {
            this.context = context;
            this.queries = queries;
            this.renderer = renderer;
            this.mapper = mapper;
            this.customers = customers;
            this.products = products;
            this.salesPeople = salesPeople;

        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("getSales")]
        public async Task<List<SaleModel>> GetSales() => await this.queries.GetSales();
        [HttpGet("getSalesByDate")]
        public async Task<List<SaleModel>> GetSalesForDate(DateTime date) => await this.queries.GetSalesForDate(date);
        [HttpGet("/newSale")]
        public async Task<JsonResult> NewSale()
        {
            var model = new CreateSaleModel();

            model.Customers = (await this.customers.GetCustomers()).Select(c => new SelectListItem() { Text = c.FirstName + " " + c.LastName, Value = c.CustomerId.ToString() }).ToList();
            model.Products = (await this.products.GetProducts()).Select(c => new SelectListItem() { Text = c.Name, Value = c.ProductId.ToString() }).ToList();
            model.Associates = (await this.salesPeople.GetSalesPeople()).Select(c => new SelectListItem() { Text = c.FirstName + " " + c.LastName, Value = c.SalesPersonId.ToString() }).ToList();
            
            var view = await this.RenderViewAsync("NewSale", model, true);

            return new JsonResult(new { view });
        }

        [HttpPost("/createNewSale")]
        public async Task<JsonResult> NewSalePost(CreateSaleModel model)
        {
            try
            {
                this.context.Sales.Add(new Domain.Entities.Sale() { CustomerId = model.CustomerId, SalePersonId = model.SalePersonId, ProductId = model.ProductId });
                await this.context.SaveChangesAsync();
                return new JsonResult(new { success = true });
            }
            catch (Exception ex)
            {
                throw;
            }
        }
    }
}
