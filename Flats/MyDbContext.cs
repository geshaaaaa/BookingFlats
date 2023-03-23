using Booking;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Booking
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() : base("DbConnection")
        {

        }

        public DbSet<Flat> Flats { get; set; }
        public DbSet<People> people { get; set; }

    }
}
