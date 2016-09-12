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

        System.Collections.ArrayList MyCustomers = new System.Collections.ArrayList();

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
            c.FirstName = txtFirstName.Text;
            c.LastName = txtLastName.Text;

            MyCustomers.Add(c);

            listBox1.Items.Clear();

            foreach (Customer item in MyCustomers)
            {
                listBox1.Items.Add(item.FullName());
            }

            txtFirstName.Clear();
            txtLastName.Clear();

            label4.Text = string.Format("Du har {0} kunder", MyCustomers.Count);
        }
    }
}
