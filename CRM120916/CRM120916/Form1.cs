using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRM120916
{
    public partial class Form1 : Form
    {
        int i = 100;
        string status;

        List<Customer> MyCustomers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {


            Customer c = new Customer();
            c.ID = i;
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;
            c.Active = true;

            if (c.Active)
            {
                status = "Active"; 
            }

            MyCustomers.Add(c);

            listBox1.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.FullName());
            }

            txtFirstName.Clear();
            txtLastName.Clear();

            label4.Text = string.Format("Du har {0} kunder", MyCustomers.Count);

            i++;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = MyCustomers[listBox1.SelectedIndex];
            MessageBox.Show(string.Format("ID: {0}\nFirst name: {1}\nLast name: {2}\nStatus: {3}",c.ID, c.FirstName, c.LastName, status));

        }
    }
}
