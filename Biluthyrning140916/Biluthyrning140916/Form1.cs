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

            Car b = new Car() { model = "Tesla Model S", HPower = "200", WDrive = "2WD", propellant = "Electricity", regNo = "NYU 526", seats = "5" };
            MyCars.Add(b);
            listBox1.Items.Add(b.model);

            Car c = new Car() { model = "Dodge Nitro", HPower = "200", WDrive = "2WD", propellant = "Petrol", regNo = "LIO 623", seats = "5" };
            MyCars.Add(c);
            listBox1.Items.Add(c.model);

            Car d = new Car() { model = "Audi R8", HPower = "300", WDrive = "2WD", propellant = "Petrol", regNo = "QSD 163", seats = "5" };
            MyCars.Add(d);
            listBox1.Items.Add(d.model);

            Car e = new Car() { model = "Volvo V70", HPower = "150", WDrive = "2WD", propellant = "petrol", regNo = "NCR 925", seats = "5" };
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

            textBox5.Text = string.Format("{0}", x.regNo);
            textBox1.Text = string.Format("{0}", x.HPower);
            textBox2.Text = string.Format("{0}", x.WDrive);
            textBox3.Text = string.Format("{0}", x.propellant);
            textBox4.Text = string.Format("{0}", x.seats);



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = false;
            textBox2.ReadOnly = false;
            textBox3.ReadOnly = false;
            textBox4.ReadOnly = false;

        }

        private void button2_Click(object sender, EventArgs e)
        {

            Car x = (Car)MyCars[listBox1.SelectedIndex];

            x.HPower = textBox1.Text;
            x.WDrive = textBox2.Text;
            x.propellant = textBox3.Text;
            x.seats = textBox4.Text;

            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.ReadOnly = true;
            textBox2.ReadOnly = true;
            textBox3.ReadOnly = true;
            textBox4.ReadOnly = true;

            panel1.Visible = false;

        }
    }
}
