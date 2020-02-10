using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    class OrderItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public bool IsSale { get; set; }
        public decimal Price { get; set; }
        public int Count { get; set; }
        public int Amount { get; set; }
        public DateTime ReturnDate { get; set; }
    }
}
