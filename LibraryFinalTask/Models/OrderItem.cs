using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    public class OrderItem
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int BookId { get; set; }
        public bool IsTypeSale { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public decimal Amount { get; set; }

        [Column(TypeName = "date")]
        public DateTime OrderDate { get; set; }

        [Column(TypeName = "date")]
        public DateTime? ReturnDate { get; set; }

        public Order Order { get; set; }
        public Book Book { get; set; }
    }
}
