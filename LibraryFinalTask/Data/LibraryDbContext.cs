using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryFinalTask.Data
{
    class LibraryDbContext : DbContext
    {
        public LibraryDbContext() : base("Server=.;Database=PervinLibraryApp;Trusted_Connection=True;MultipleActiveResultSets=true")
        {

        }
    }
}
