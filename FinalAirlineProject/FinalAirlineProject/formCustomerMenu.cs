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
    public partial class formCustomerMenu : Form
    {
        formMenu menu;
        public formCustomerMenu()
        {
            InitializeComponent();
        }
        public formCustomerMenu(formMenu menu)
        {
            this.menu = menu;
            InitializeComponent();
        }

        private void formCustomerMenu_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

        }
    }
}
