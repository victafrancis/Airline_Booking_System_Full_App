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


        private void btnAddFlight_Click(object sender, EventArgs e)
        {
            int flightNum = Program.ValidateInt(txtFlightNum.Text, labelError1);
            string flightOrig = Program.ValidateString(txtFlightOrig.Text, labelError2);
            string flightDest = Program.ValidateString(txtFlightDest.Text, labelError3);
            int maxSeats = Program.ValidateInt(txtMaxSeats.Text, labelError4);

            if(flightNum != -1 && maxSeats != -1 && flightOrig != null && flightDest != null)
            {
                if (Program.ac.addFlight(flightNum, flightOrig, flightDest, maxSeats))
                {
                    MessageBox.Show("successsfully added!");
                    txtFlightNum.Clear();
                    txtFlightOrig.Clear();
                    txtFlightDest.Clear();
                    txtMaxSeats.Clear();
                    txtFlightNum.Select();
                }
                else
                {
                    MessageBox.Show("Flight not added...");
                }
            }

            txtFlightList.Text = Program.ac.flightList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Program.ValidateInt(txtFlightID.Text, labelError5);

            if(id != -1)
            {
                if (Program.ac.deleteFlight(id))
                {
                    MessageBox.Show("Successfully Deleted!");
                }
                else
                {
                    MessageBox.Show("Flight not deleted...");
                }
                txtFlightID.Clear();
                txtFlightList.Text = Program.ac.flightList();
                txtFlightID.Select();
            }
        }

        private void formFlightMenu_Load_1(object sender, EventArgs e)
        {
            txtFlightList.Text = Program.ac.flightList();
            txtFlightNum.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
    }
}
