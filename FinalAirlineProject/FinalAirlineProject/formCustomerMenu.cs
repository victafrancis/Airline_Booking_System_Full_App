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
            txtCustomerList.Text = Program.ac.customerList();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            menu.Show();
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string custFName = txtFName.Text;
            string custLName = txtLName.Text;
            string custPhone = txtPhone.Text;

            if (Program.ac.addCustomer(custFName, custLName, custPhone))
                MessageBox.Show("Successfully Added!");
            else
                MessageBox.Show("Customer not added...");

            txtFName.Clear();
            txtLName.Clear();
            txtPhone.Clear();

            txtCustomerList.Text = Program.ac.customerList();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int id = Convert.ToInt32(txtCustomerID.Text);
            if (Program.ac.deleteCustomer(id))
            {
                MessageBox.Show("Successfully Deleted!");
            }
            else
            {
                MessageBox.Show("Customer not deleted...");
            }

            

            txtCustomerID.Clear();

            txtCustomerList.Text = Program.ac.customerList();
        }
    }
}
