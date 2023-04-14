using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Booking
{
    public class Flat
    {
        public int Id { get; set; }
        public int Price { get; set; }
        public int Rooms { get; set; }
        public string District { get; set; }
        public string FlatName { get; set; }
        public virtual ICollection<People> people { get; set; }

    }
}