using AutoMapper;
using BeSpokedBikes.Domain.Entities;
using BeSpokedBikes.Infrastructure;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Queries.Products
{
    public interface IProductQueries
    {
        Task<List<Product>> GetProducts();
    }
    public class ProductQueries : IProductQueries
    {
        private readonly BSBContext context;
        //private readonly IMapper mapper;

        public ProductQueries(BSBContext context/*, IMapper mapper*/)
        {
            this.context = context;
            //this.mapper = mapper;
        }
        public async Task<List<Product>> GetProducts()=> await this.context.Products.ToListAsync();               
    }
}
