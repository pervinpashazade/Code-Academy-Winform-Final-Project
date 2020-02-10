using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    class Genre
    {
        public int Id { get; set; }
        public int Name { get; set; }
        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
