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
    }
}
