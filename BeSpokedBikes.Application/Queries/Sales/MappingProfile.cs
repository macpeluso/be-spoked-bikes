using AutoMapper;
using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Queries.Sales
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Sale, SaleModel>()
                .AfterMap(((c, cm) =>
            {
         
                
            }));
        }
    }
}
