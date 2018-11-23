using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinalAirlineProject
{
    public partial class formBookingMenu : Form
    {
        formMenu menu;

        public formBookingMenu()
        {
            InitializeComponent();
        }
        public formBookingMenu(formMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void formBookingMenu_Load(object sender, EventArgs e)
        {
            txtCustomerList.Text = Program.ac.customerList();
            txtFlightList.Text = Program.ac.flightList();
            txtViewBookingList.Text = Program.ac.viewBookings();
            txtCustomerID.Select();
        }

        private void btnCreateBooking_Click(object sender, EventArgs e)
        {
            int custID = Program.ValidateInt(txtCustomerID.Text, labelError1);
            int flightNum = Program.ValidateInt(txtFlightID.Text, labelError2);

            if(custID != -1 && flightNum != -1)
            {
                if (Program.ac.addBooking(custID, flightNum))
                {
                    MessageBox.Show("Booking made successfully!");
                    txtCustomerID.Clear();
                    txtFlightID.Clear();
                    txtCustomerID.Select();
                }
                else
                {
                    MessageBox.Show("Booking not successful...");
                }
            }

            txtViewBookingList.Text = Program.ac.viewBookings();
        }

        private void btnBack_Click_1(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
    }
}
