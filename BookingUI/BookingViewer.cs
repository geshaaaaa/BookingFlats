using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Booking;
using System.Data.SqlClient;
using System.Diagnostics;
using Flats;
using System.Data.SqlTypes;
using System.Security.Cryptography.X509Certificates;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace BookingUI
{
    public partial class BookingViewer : Form
    {
       ForConnection database = new ForConnection();
       
        public BookingViewer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedValue = PriceComboBox.SelectedItem.ToString();
            string query = "";
            Selector priceSelector = new Selector();
            query = priceSelector.GetDistricts(selectedValue, query);
            SqlCommand command = new SqlCommand(query, database.getconnection());
            database.openconnection();
            SqlDataReader reader = command.ExecuteReader();
            DistrictDropdown.Items.Clear();
            while (reader.Read())
            {
                DistrictDropdown.Items.Add(reader.GetString(0));
            }
            reader.Close();
            database.closeconnection();
        }



        private void DistrictDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Selector roomsSelector = new Selector();
            string selectedValue = DistrictDropdown.SelectedItem.ToString();
            string priceroom = PriceComboBox.SelectedItem.ToString();
            string query = "";
            query = roomsSelector.GetRooms(selectedValue, query, priceroom);
            SqlCommand command = new SqlCommand(query, database.getconnection());
            database.openconnection();
            SqlDataReader reader = command.ExecuteReader();
            RoomsDropdown.Items.Clear();
            while (reader.Read())
            {
                RoomsDropdown.Items.Add(reader.GetInt32(0));
            }
            reader.Close();
            database.closeconnection();


        }

        private void RoomsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selector flatSelector = new Selector();
            string selectedValue = RoomsDropdown.SelectedItem.ToString();
            string districtflat = DistrictDropdown.SelectedItem.ToString();
            string priceroom = PriceComboBox.SelectedItem.ToString();
            string query = "";
            query = flatSelector.GetFlats(selectedValue, districtflat, priceroom,query);


            SqlCommand command = new SqlCommand(query, database.getconnection());
            database.openconnection();
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataSet ds = new DataSet();
            adapter.Fill(ds);
            command.ExecuteNonQuery();
            DistrictDropdown.Items.Clear();
            RoomsDropdown.Items.Clear();
            database.closeconnection();
            FlatDropdown.DataSource = ds.Tables[0];
            FlatDropdown.ValueMember = "Id";
            FlatDropdown.DisplayMember = "FlatName";


        }
        private void FlatDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {





        }

        private void CheckInCalendar_ValueChanged(object sender, EventArgs e)
        {


        }
        private void CheckOutCalendar_ValueChanged(object sender, EventArgs e)
        {
            Checker checker = new Checker();

            DateTime checkIn = CheckInCalendar.Value;
            DateTime checkOut = CheckOutCalendar.Value;
            int FlatId = (int)FlatDropdown.SelectedValue;
            PriceEquals.Text = checker.TotalPriceChecker(checkIn, checkOut, FlatId);        
        }
        private void OkButton_Click(object sender, EventArgs e)
        {
            Checker checker = new Checker();
           
            int totalPrice = int.Parse(PriceEquals.Text);
            DateTime checkInValue = CheckInCalendar.Value;
            DateTime checkOutValue = CheckOutCalendar.Value;
            int flatId = (int)FlatDropdown.SelectedValue;
            string phoneNumber = PhoneTextBox.Text;
            string personName = NametextBox.Text;
            if (checker.FlatChecker(checkInValue,checkOutValue,flatId))
            {
                return;
            }
        
            checker.PeopleInsert(flatId,phoneNumber,personName,checkInValue,checkOutValue,totalPrice);

        }




        

        private void PhoneLabel_Click(object sender, EventArgs e)
        {

        }

        private void PhoneTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void NametextBox_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
