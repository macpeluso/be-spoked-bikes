using AutoMapper;
using AutoMapper.Configuration.Annotations;
using BeSpokedBikes.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Models
{
    
    public class CustomerModel
    {
        public Guid CustomerId { get; set; }
        public Guid ContactId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public Guid AddressId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string SubAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
        [IgnoreMap]
        public string Address { get; set; }
    }
}
