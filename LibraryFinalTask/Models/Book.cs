using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    class Book
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int LanguageId { get; set; }
        public decimal PriceSale { get; set; }
        public decimal PriceRent { get; set; }
        public int Count { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

    }
}
