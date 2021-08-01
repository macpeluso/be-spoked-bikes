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

namespace BeSpokedBikes.Application.Queries.SalesPeople
{
    public interface ISalesPeopleQueries
    {
        Task<List<SalesPersonModel>> GetSalesPeople();
    }
    public class SalesPeopleQueries : ISalesPeopleQueries
    {
        private readonly BSBContext context;
        private readonly IMapper mapper;

        public SalesPeopleQueries(BSBContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }
        public async Task<List<SalesPersonModel>> GetSalesPeople() => this.mapper.Map<List<SalesPerson>, List<SalesPersonModel>>(await this.context.SalesPeople.ToListAsync());

    }
}
