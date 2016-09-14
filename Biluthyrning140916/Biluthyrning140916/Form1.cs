using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biluthyrning140916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList MyCars = new System.Collections.ArrayList();

        public Form1()
        {
            InitializeComponent();

            panel1.Visible = false;

            Car a = new Car() { model ="Volvo XC90", HPower = 254, WDrive ="4WD", propellant ="Diesel", regNo ="NRH 542" };
            MyCars.Add(a);

            listBox1.Items.Add(a.model);

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car a = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            label2.Text = string.Format("Reg nr: {0}", a.regNo);
            label3.Text = string.Format("Horsepower: {0}", a.HPower);
            label4.Text = string.Format("{0}", a.WDrive);
            label5.Text = string.Format("Fuel: {0}", a.propellant);

        }

        private void label3_Click(object sender, EventArgs e)
        {
            
        }
    }
}
