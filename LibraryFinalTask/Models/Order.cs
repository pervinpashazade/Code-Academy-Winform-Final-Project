using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    public class Order
    {
        public int Id { get; set; }
        public int SellerId { get; set; }
        public int CustomerId { get; set; }
        public decimal TotalPrice { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        public Employee Seller { get; set; }
        public Customer Customer { get; set; }
    }
}
