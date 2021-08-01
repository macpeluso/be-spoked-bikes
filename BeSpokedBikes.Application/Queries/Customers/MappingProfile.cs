using AutoMapper;
using BeSpokedBikes.Application.Models;
using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Queries.Customers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            this.CreateMap<Customer, CustomerModel>()
                .AfterMap(((c, cm) =>
            {
                cm.FirstName = c.Contact.FirstName;
                cm.LastName = c.Contact.LastName;
                cm.Phone = c.Contact.Phone;
                cm.AddressId = c.Contact.AddressId;
                cm.StreetAddress = c.Contact.Address.StreetAddress;
                cm.SubAddress = c.Contact.Address.SubAddress;
                cm.State = c.Contact.Address.State;
                cm.PostalCode = c.Contact.Address.PostalCode;
                cm.City = c.Contact.Address.City;
                cm.Address = $"{cm.StreetAddress}, {((!String.IsNullOrEmpty(cm.SubAddress)) ? cm.SubAddress + ", " : "")}{cm.City}, {cm.State}, {cm.PostalCode}";
            }));
        }
    }
}
