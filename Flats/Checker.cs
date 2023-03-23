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
    public class Checker 
    {
        ForConnection database = new ForConnection();
        public bool FlatChecker(DateTime checkInValue, DateTime checkOutValue, int flatId)
        {

            SqlCommand command = new SqlCommand("SELECT COUNT(*) FROM People WHERE FlatID = @FlatId   AND CheckInDate <= @CheckOutDate AND CheckOutDate >= @CheckInDate   ", database.getconnection());
            database.openconnection();

            command.Parameters.AddWithValue("@FlatID", flatId);
            command.Parameters.AddWithValue("@CheckInDate", checkInValue);
            command.Parameters.AddWithValue("@CheckOutDate", checkOutValue);

            int count = (int)command.ExecuteScalar();

            database.closeconnection();

            if (count > 0)
            {
                MessageBox.Show("Для цієї квартири ці дати зайняті, оберіть іншу дату!");
                return true;
            }
            else { return false; }
        }

        public string TotalPriceChecker(DateTime checkIn, DateTime checkOut, int FlatId)
        {
            
            string query = $"Select Price from Flats Where Id = {FlatId} ";
            SqlCommand command = new SqlCommand(query, database.getconnection());
            database.openconnection();
            int Price = (int)command.ExecuteScalar();
            int total = Price * (int)(checkOut - checkIn).TotalDays;
            database.closeconnection();
          return total.ToString();
        
        }



        public int PeopleInsert(int flatId, string phoneNumber, string personName,DateTime checkInValue, DateTime checkOutValue, int totalPrice)
        {
            string query = $"INSERT INTO People (CheckInDate,CheckOutDate,TotalPrice,FlatId,PersonName,PhoneNumber) VALUES (@checkInValue,@checkOutValue,@totalPrice,@flatId,@personName,@phoneNumber)";
           
            SqlCommand commandDate = new SqlCommand(query, database.getconnection());
            database.openconnection();
            commandDate.Parameters.AddWithValue("@checkInValue", checkInValue);
            commandDate.Parameters.AddWithValue("@checkOutValue", checkOutValue);
            commandDate.Parameters.AddWithValue("@totalPrice", totalPrice);
           commandDate.Parameters.AddWithValue("@flatId", flatId);
            commandDate.Parameters.AddWithValue("@personName", personName);
            commandDate.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            int add =   commandDate.ExecuteNonQuery();
            database.closeconnection();
            MessageBox.Show("Ви забронювали квартиру, вам передзвонить наш оператор!");
            return add;
        }

    }
}
