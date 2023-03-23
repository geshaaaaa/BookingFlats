using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Booking;
using System.Data.SqlClient;
using System.Diagnostics;
using Flats;
using System.Data.SqlTypes;

namespace Flats
{
    public class Selector
    {
        ForConnection database = new ForConnection();
        public string GetDistricts(string selectedValue, string query)
        {

            if (selectedValue == "500-800")
            {
                query = "Select DISTINCT District from Flats WHERE Price <= 800 ";
            }
            else if (selectedValue == "800-1100")
            {
                query = "Select DISTINCT District from Flats WHERE Price >= 800 AND Price  <= 1100";
            }
            else if (selectedValue == "1100-1400")
            {
                query = "Select DISTINCT District from Flats WHERE Price >= 1100 AND Price <= 1400";
            }
            return query;
        }

        public string GetRooms(string selectedValue, string query, string priceroom)
        {
            if (priceroom == "500-800")
            {
                if (selectedValue == "Печерський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Печерський' AND Price <= 800";
                }
                if (selectedValue == "Шевченківський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE District = 'Шевченківський' AND Price <= 800";
                }
                if (selectedValue == "Голосіївський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Голосіївський' AND Price <= 800";
                }

            }
            if (priceroom == "800-1100")
            {
                if (selectedValue == "Печерський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Печерський' AND Price >= 800 AND Price  <= 1100";
                }
                if (selectedValue == "Шевченківський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE District = 'Шевченківський' AND Price >= 800 AND Price  <= 1100";
                }
                if (selectedValue == "Голосіївський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Голосіївський' AND Price >= 800 AND Price  <= 1100";
                }

            }
            if (priceroom == "1100-1400")
            {
                if (selectedValue == "Печерський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Печерський' AND Price >= 1100 AND Price <= 1400";
                }
                if (selectedValue == "Шевченківський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE District = 'Шевченківський' AND Price >= 1100 AND Price <= 1400";
                }
                if (selectedValue == "Голосіївський")
                {
                    query = "Select Distinct Rooms,District,Id from Flats WHERE  District = 'Голосіївський' AND Price >= 1100 AND Price <= 1400";
                }
                
            }
            return query;
        }
        public string GetFlats(string selectedValue, string districtflat, string priceroom, string query)
        {
            if (selectedValue == "1")
            {
                if (districtflat == "Печерський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Печерський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Печерський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Печерський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Шевченківський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Шевченківський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Шевченківський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Шевченківський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Голосіївський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Голосіївський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Голосіївський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 1 AND District = 'Голосіївський' AND Price >= 1100 AND Price  <= 1400";
                    }

                }
            }
            if (selectedValue == "2")
            {
                if (districtflat == "Печерський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Печерський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Печерський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Печерський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Шевченківський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Шевченківський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Шевченківський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Шевченківський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Голосіївський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Голосіївський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Голосіївський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 2 AND District = 'Голосіївський' AND Price >= 1100 AND Price  <= 1400";
                    }

                }
            }
            if (selectedValue == "3")
            {
                if (districtflat == "Печерський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Печерський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Печерський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Печерський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Шевченківський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Шевченківський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Шевченківський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Шевченківський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
                if (districtflat == "Голосіївський")
                {
                    if (priceroom == "500-800")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Голосіївський' AND Price <= 800";
                    }
                    if (priceroom == "800-1100")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Голосіївський' AND Price >= 800 AND Price  <= 1100";
                    }
                    if (priceroom == "1100-1400")
                    {
                        query = "Select FlatName,Id from Flats WHERE Rooms = 3 AND District = 'Голосіївський' AND Price >= 1100 AND Price  <= 1400";
                    }
                }
            }
               return query;
        }

    }
}