using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Booking
{
    public class People

    {
        public int Id { get; set; }
        public string PersonName { get; set; }
        public string PhoneNumber { get; set; }
        public int FlatId { get; set; }
        public string CheckInDate { get; set; }
        public string CheckOutDate { get; set; }
        public int TotalPrice { get; set; }
        public virtual Flat flats { get; set; } 
    }
}
