using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Domain.Entities
{
    public class Sale
    {
        public Guid SaleId { get; set; }
        public Guid CustomerId { get; set; }
        public Guid SalePersonId { get; set; }
        public Guid ProductId { get; set; }
        public DateTimeOffset Date { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual Product Product { get; set; }
    }
}
