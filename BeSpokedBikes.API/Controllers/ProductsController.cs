using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Application.Queries.Products;
using BeSpokedBikes.Domain.Entities;
using BeSpokedBikes.Domain.Exceptions;
using BeSpokedBikes.Infrastructure;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.API.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductQueries productQueries;
        private readonly BSBContext context;
        public ProductsController(BSBContext context, IProductQueries queries)
        {
            this.productQueries = queries;
            this.context = context;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getProducts")]
        public async Task<List<ProductModel>> GetProducts() => await this.productQueries.GetProducts();
        [HttpPost("editProduct")]
        public async Task<JsonResult> Edit(ProductModel model)
        {
            try
            {
                var product = await this.context.Products.FirstOrDefaultAsync(x => x.ProductId == model.ProductId);

                if (product == null) throw new RestException("That product doesn't exist");

                product.PurchasePrice = model.PurchasePrice;
                product.SalePrice = model.SalePrice;
                product.CommissionPercentage = model.CommissionPercentage;
                product.Name = model.Name;
                product.Manufacturer = model.Manufacturer;
                product.Quantity = model.Quantity;
                product.Style = model.Style;

                await context.SaveChangesAsync();

                return new JsonResult(new { success = true });
            }
            catch (Exception ex)
            {
                throw new RestException(ex);
            }

        }

    }
}
