using Microsoft.EntityFrameworkCore;
using System;
using Microsoft.EntityFrameworkCore.SqlServer;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CarRegistry.Models
{
    public class CarContext :DbContext
    {
        public CarContext(DbContextOptions<CarContext> options ):base(options)
        {

        }
        public DbSet<Car> Cars { get; set; }
    }
}
