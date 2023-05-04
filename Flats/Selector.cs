using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Data.Entity;
using Booking;
using System.Data.SqlClient;
using System.Diagnostics;
using Flats;
using System.Data.SqlTypes;
using static System.Net.Mime.MediaTypeNames;

namespace Flats
{
    public class Selector 
    {
      
        public string GetDistricts(string selectedValue, string query)
        {
         
            string[] price = selectedValue.Split(new char[] { '-' });
            return $"Select DISTINCT District from Flats WHERE Price >= {price[0]} AND Price <= {price[1]}";
        }

        public string GetRooms(string selectedValue, string query, string priceroom)
        {
            string[] price = priceroom.Split(new char[] { '-' });

            return $"Select Distinct Rooms,District,Id from Flats WHERE  District = '{selectedValue}' AND Price >= {price[0]} AND Price <= {price[1]}";

        }
        public string GetFlats(string selectedValue, string districtflat, string priceroom, string query)
        {
            string[] price = priceroom.Split(new char[] { '-' });
            return $"Select FlatName,Id from Flats WHERE Rooms ={selectedValue} AND District = '{districtflat}' AND Price >= {price[0]} AND Price  <= {price[1]}";
        }

    }
}