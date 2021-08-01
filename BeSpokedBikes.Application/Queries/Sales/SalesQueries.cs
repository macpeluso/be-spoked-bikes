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

namespace BeSpokedBikes.Application.Queries.Sales
{
    public interface ISalesQueries
    {
        Task<List<SaleModel>> GetSales();
        Task<List<SaleModel>> GetSalesForDate(DateTime date);
    }
    public class SalesQueries : ISalesQueries
    {
        private readonly BSBContext context;
        private readonly IMapper mapper;
        public SalesQueries(BSBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<List<SaleModel>> GetSales() => this.mapper.Map<List<Sale>, List<SaleModel>>(await this.context.Sales.ToListAsync());

        public async Task<List<SaleModel>> GetSalesForDate(DateTime date) => this.mapper.Map<List<Sale>, List<SaleModel>>(await this.context.Sales.Where(x => x.Date.Date.CompareTo(date.Date) == 0).ToListAsync());
    }
}
