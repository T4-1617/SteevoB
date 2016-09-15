using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomerEmployee150916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList CustomersEmployee;
 

        public Form1()
        {
            InitializeComponent();

            CustomersEmployee = new System.Collections.ArrayList();
        
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (radioCustomer.Checked) {
                CustomersEmployee.Add(new Customer() { FirstName = txtFirstName.Text, LastName = txtLastName.Text });
               
            }
            else if (radioEmployee.Checked) {
                CustomersEmployee.Add(new Employee() { LastName = txtLastName.Text, FirstName = txtFirstName.Text});
            }

            txtFirstName.Text = string.Empty;
            txtLastName.Text = string.Empty;
            txtFirstName.Focus();

            DisplayCustomersAndEmployees();

        }

        private void DisplayCustomersAndEmployees()
        {
            listCustomers.Items.Clear();
            listEmployees.Items.Clear();

            foreach (var x in CustomersEmployee)
            {
                switch (x.GetType().Name)
                {
                    case "Customer":
                        listCustomers.Items.Add(x);
                        listCustomers.DisplayMember = "FullName";

                        break;

                    case "Employee":
                        listEmployees.Items.Add(x);
                        listEmployees.DisplayMember = "FullName";

                        break;

                    default:
                        break;
                }
            }
        }
    }
}
