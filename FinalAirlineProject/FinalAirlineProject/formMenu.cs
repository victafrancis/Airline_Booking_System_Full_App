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
    public partial class formMenu : Form
    {
        public formMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formCustomerMenu f = new formCustomerMenu(this);
            f.Show();
            this.Hide();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            formFlightMenu f = new formFlightMenu(this);
            f.Show();
            this.Hide();
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            formBookingMenu f = new formBookingMenu(this);
            f.Show();
            this.Hide();
            
        }

        private void formMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage customers";
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage flights";
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage bookings";
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void button1_Enter(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage customers";
        }

        private void button1_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void button2_Enter(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage flights";
        }

        private void button2_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void button3_Enter(object sender, EventArgs e)
        {
            lblInfo.Text = "Opens menu to manage bookings";
        }

        private void button3_Leave(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }
    }
}
