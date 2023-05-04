using Booking;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Flats
 
{
    public class Checker : ForConnection
    {
        
        public bool FlatChecker(DateTime checkInValue, DateTime checkOutValue, int flatId)
        {

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM People WHERE FlatID = @FlatId   AND CheckInDate <= @CheckOutDate AND CheckOutDate >= @CheckInDate   ", getconnection());
            openconnection();

            command.Parameters.AddWithValue("@FlatID", flatId);
            command.Parameters.AddWithValue("@CheckInDate", checkInValue);
            command.Parameters.AddWithValue("@CheckOutDate", checkOutValue);

            int count = (int)command.ExecuteScalar();

            closeconnection();

            bool isFlatOccupied = count > 0;
            return isFlatOccupied;
        }
        
        public string TotalPriceChecker(DateTime checkIn, DateTime checkOut, int FlatId)
        {
            
            string query = $"Select Price from Flats Where Id = {FlatId} ";
            SqlCommand command = new SqlCommand(query, getconnection());
            openconnection();
            int Price = (int)command.ExecuteScalar();
            int total = Price * (int)(checkOut - checkIn).TotalDays;
            closeconnection();
          return total.ToString();
        
        }

        

    }
}
