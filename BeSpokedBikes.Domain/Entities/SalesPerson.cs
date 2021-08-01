using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BeSpokedBikes.Domain.Entities
{
    public class SalesPerson
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid SalesPersonId { get; set; }
        public Guid ContactId { get; set; }
        public DateTimeOffset? TerminationDate { get; set; }
        public bool Manager { get; set; }
        public virtual Contact Contact { get; set; }
    }
}
