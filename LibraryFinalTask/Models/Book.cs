using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryFinalTask.Models
{
   public class Book
    {
        public int Id { get; set; }

        [MaxLength(50)]
        [Required]
        public string Name { get; set; }
        public int GenreId { get; set; }
        public int AuthorId { get; set; }
        public int LanguageId { get; set; }
        public decimal PriceSale { get; set; }
        public decimal PriceRent { get; set; }
        public int Count { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }
        public bool Status { get; set; }

        public Genre Genre { get; set; }
        public Author Author { get; set; }
        public Language Language { get; set; }

    }
}
