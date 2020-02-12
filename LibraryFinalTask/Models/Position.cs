using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Models
{
    class Position
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public bool Status { get; set; }

        [Column(TypeName = "date")]
        public DateTime CreatedAt { get; set; }

        public List<Employee> Employees { get; set; }
    }
}
