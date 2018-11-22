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
    public partial class formFlightMenu : Form
    {
        formMenu menu;

        public formFlightMenu()
        {
            InitializeComponent();
        }

        public formFlightMenu(formMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            int flightNum = Convert.ToInt32(txtFlightNum.Text);
            string flightOrig = txtFlightOrig.Text;
            string flightDest = txtFlightDest.Text;
            int maxSeats = Convert.ToInt32(txtMaxSeats.Text);

            if (Program.ac.addFlight(flightNum, flightOrig, flightDest, maxSeats))
                MessageBox.Show("successsfully added!");
            else
                MessageBox.Show("Flight not added...");

            txtFlightNum.Clear();
            txtFlightOrig.Clear();
            txtFlightDest.Clear();
            txtMaxSeats.Clear();

            txtFlightList.Text = Program.ac.flightList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtFlightID.Text);
            if (Program.ac.deleteFlight(id))
                MessageBox.Show("Successfully Deleted!");
            else
                MessageBox.Show("Flight not deleted...");
            txtFlightID.Clear();
            txtFlightList.Text = Program.ac.flightList();
        }

        private void formFlightMenu_Load_1(object sender, EventArgs e)
        {
            txtFlightList.Text = Program.ac.flightList();
        }
    }
}
