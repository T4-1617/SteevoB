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

            textBox5.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            Car a = new Car() { model = "Volvo XC90", HPower = "254", WDrive = "4WD", propellant = "Diesel", regNo = "NRH 542", seats = "5" };
            MyCars.Add(a);
            listBox1.Items.Add(a.model);

            Car b = new Car() { model = "Tesla Model S", HPower = "254", WDrive = "4WD", propellant = "Diesel", regNo = "NRH 542", seats = "5" };
            MyCars.Add(b);
            listBox1.Items.Add(b.model);

            Car c = new Car() { model = "Dodge Nitro", HPower = "254", WDrive = "4WD", propellant = "Diesel", regNo = "NRH 542", seats = "5" };
            MyCars.Add(c);
            listBox1.Items.Add(c.model);

            Car d = new Car() { model = "Audi R8", HPower = "254", WDrive = "4WD", propellant = "Diesel", regNo = "NRH 542", seats = "5" };
            MyCars.Add(d);
            listBox1.Items.Add(d.model);

            Car e = new Car() { model = "Volvo V70", HPower = "254", WDrive = "4WD", propellant = "Diesel", regNo = "NRH 542", seats = "5" };
            MyCars.Add(e);
            listBox1.Items.Add(e.model);


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)MyCars[listBox1.SelectedIndex];

            panel1.Visible = true;
            label2.Text = string.Format("Registration ", x.regNo);
            label3.Text = string.Format("Horsepower ", x.HPower);
            label4.Text = string.Format("Drivetrain", x.WDrive);
            label5.Text = string.Format("Fuel ", x.propellant);
            label6.Text = string.Format("Seats", x.seats);
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox1.ReadOnly = false;
            textBox1.ReadOnly = false;
            
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox1.ReadOnly = true;
            textBox1.ReadOnly = true;

            panel1.Visible = false;

        }
    }
}
