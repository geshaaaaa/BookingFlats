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
    public class Inserter : ForConnection
    {

        public int PeopleInsert(int flatId, string phoneNumber, string personName, DateTime checkInValue, DateTime checkOutValue, int totalPrice)
        {
            string query = $"INSERT INTO People (CheckInDate,CheckOutDate,TotalPrice,FlatId,PersonName,PhoneNumber) VALUES (@checkInValue,@checkOutValue,@totalPrice,@flatId,@personName,@phoneNumber)";

            SqlCommand commandDate = new SqlCommand(query, getconnection());
            openconnection();
            commandDate.Parameters.AddWithValue("@checkInValue", checkInValue);
            commandDate.Parameters.AddWithValue("@checkOutValue", checkOutValue);
            commandDate.Parameters.AddWithValue("@totalPrice", totalPrice);
            commandDate.Parameters.AddWithValue("@flatId", flatId);
            commandDate.Parameters.AddWithValue("@personName", personName);
            commandDate.Parameters.AddWithValue("@phoneNumber", phoneNumber);
            int add = commandDate.ExecuteNonQuery();
            closeconnection();
            return add;
        }
    }
}
