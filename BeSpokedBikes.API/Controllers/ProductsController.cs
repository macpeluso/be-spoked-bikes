using BeSpokedBikes.Application.Queries.Products;
using BeSpokedBikes.Domain.Entities;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.API.Controllers
{
    public class ProductsController : BaseController
    {
        private readonly IProductQueries productQueries;

        public ProductsController(IProductQueries queries)
        {
            this.productQueries = queries;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet("getProducts")]
        public async Task<List<Product>> GetProducts() => await this.productQueries.GetProducts();

    }
}
