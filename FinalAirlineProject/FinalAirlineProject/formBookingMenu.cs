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

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }
    }
}
