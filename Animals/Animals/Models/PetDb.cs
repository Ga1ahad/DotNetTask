using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals.Models
{
    class PetDb : DbContext
    {
        public DbSet<Animal> Animal { get; set; }
    }
}
