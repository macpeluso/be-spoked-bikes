using AutoMapper;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Application.Models
{
    public class SalesPersonModel
    {
        public Guid SalesPersonId { get; set; }
        [DisplayName("Termination Date")]
        public DateTimeOffset? TerminationDate { get; set; }
        public bool Manager { get; set; }
        public Guid AddressId { get; set; }
        [Required]
        [DisplayName("First Name")]
        public string FirstName { get; set; }
        [Required]
        [DisplayName("Last Name")]
        public string LastName { get; set; }
        [Required]
        [MaxLength(10)]
        [DisplayName("Phone")]
        public string Phone { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        [DisplayName("Address Line 1")]
        public string StreetAddress { get; set; }
        [DisplayName("Address Line 2")]
        public string SubAddress { get; set; }
        [Required]
        [MaxLength(5)]
        [DisplayName("Postal Code")]
        public string PostalCode { get; set; }
        [Required]
        public string City { get; set; }
        [IgnoreMap]
        public string Address { get; set; }
        [IgnoreMap]
        public string Termination => this.TerminationDate.HasValue ? this.TerminationDate.Value.Date.ToShortDateString() : "";
    }

}
