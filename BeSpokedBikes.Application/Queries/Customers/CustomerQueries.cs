using AutoMapper;
using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Domain.Entities;
using BeSpokedBikes.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Queries.Customers
{
    public interface ICustomerQueries
    {
        Task<List<CustomerModel>> GetCustomers();
    }
    public class CustomerQueries : ICustomerQueries
    {
        public BSBContext Context { get; }
        public IMapper Mapper { get; }
        public CustomerQueries(BSBContext context, IMapper mapper)
        {
            this.Mapper = mapper;
            this.Context = context;
        }
        public async Task<List<CustomerModel>> GetCustomers() => this.Mapper.Map<List<Customer>, List<CustomerModel>>(await this.Context.Customers.ToListAsync());
    }
}
