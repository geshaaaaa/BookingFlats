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
        DataBaseHelper dataBaseHelper = new DataBaseHelper();
        
        public BookingViewer()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void PriceComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selector priceselector = new Selector();
            string query = "";
            string selectedValue = PriceComboBox.SelectedItem.ToString();
             query = priceselector.GetDistricts(selectedValue, query);
            dataBaseHelper.ExecutePrice(query, DistrictDropdown);
        }



        private void DistrictDropdown_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            Selector roomsSelector = new Selector();
            string selectedValue = DistrictDropdown.SelectedItem.ToString();
            string priceroom = PriceComboBox.SelectedItem.ToString();
            string query = "";
            query = roomsSelector.GetRooms(selectedValue, query, priceroom);
           dataBaseHelper.ExecuteDistrict(query, RoomsDropdown); 

        }

        private void RoomsDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            Selector flatSelector = new Selector();
            string selectedValue = RoomsDropdown.SelectedItem.ToString();
            string districtflat = DistrictDropdown.SelectedItem.ToString();
            string priceroom = PriceComboBox.SelectedItem.ToString();
            string query = "";
            query = flatSelector.GetFlats(selectedValue, districtflat, priceroom, query);
            dataBaseHelper.ExecuteFlat(query, RoomsDropdown,DistrictDropdown,FlatDropdown);
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
            Inserter inserter = new Inserter();
            int totalPrice = int.Parse(PriceEquals.Text);
            DateTime checkInValue = CheckInCalendar.Value;
            DateTime checkOutValue = CheckOutCalendar.Value;
            int flatId = (int)FlatDropdown.SelectedValue;
            string phoneNumber = PhoneTextBox.Text;
            string personName = NametextBox.Text;
            bool isFlatOccupied = checker.FlatChecker(checkInValue, checkOutValue, flatId);

            if (isFlatOccupied)
            {

                MessageBox.Show("Для цієї квартири ці дати зайняті, оберіть іншу дату!");
                return;
            }
            inserter.PeopleInsert(flatId,phoneNumber,personName,checkInValue,checkOutValue,totalPrice);
            MessageBox.Show("Квартира заброньована, вам передзвонить оператор!");
        }
    }
}
