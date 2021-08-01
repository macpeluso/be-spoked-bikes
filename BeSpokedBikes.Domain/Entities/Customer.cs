using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
namespace BeSpokedBikes.Domain.Entities
{
    public class Customer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid CustomerId { get; set; }
        public Guid ContactId { get; set; }
        public DateTimeOffset StartDate { get; set; }
        public Contact Contact { get; set; }
        public virtual List<Sale> Sales { get; set; }
    }
}
