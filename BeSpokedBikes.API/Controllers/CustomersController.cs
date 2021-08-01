using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Application.Queries.Customers;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BeSpokedBikes.API.Controllers
{
    public class CustomersController : BaseController
    {
        private readonly ICustomerQueries customerQueries;
        private readonly IRazorViewToStringRenderer renderer;

        public CustomersController(ICustomerQueries queries)
        {
            this.customerQueries = queries;
            this.renderer = renderer;
        }
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("/getCustomers")]
        public async Task<List<CustomerModel>> GetCustomers() => await this.customerQueries.GetCustomers();

       
    }
}
