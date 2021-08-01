using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Domain.Entities
{
    [Owned]
    public class ContactAddress
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        //public Guid AddressId { get; set; }
        public string State { get; set; }
        public string StreetAddress { get; set; }
        public string SubAddress { get; set; }
        public string PostalCode { get; set; }
        public string City { get; set; }
    }
}
