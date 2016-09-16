using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ACMECAR160916
{
    public partial class Form1 : Form
    {
        System.Collections.ArrayList Cars;


        public Form1()
        {
            InitializeComponent();

            
            //pnlShow.Visible = false;
            //pnlAdd.Visible = false;
            //pnlReturn.Visible = false;

            Cars = new System.Collections.ArrayList();

            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Red", Rented = false });
            Cars.Add(new Car() { Make = "Dodge", Model = "Nitro", Color = "Silver", Rented = false });
            Cars.Add(new Car() { Make = "Porsche", Model = "Cayenne", Color = "Orange", Rented = false });


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //pnlShow.Visible = true;
            //pnlReturn.Visible = false;asdasd
            //pnlAdd.Visible = false;

            lstCars.Items.Clear();

            foreach (Car item in Cars)
            {
                lstCars.Items.Add(item);
                lstCars.DisplayMember = "MakeModel";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            //pnlAdd.Visible = true;
            //pnlReturn.Visible = false;
            //pnlShow.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            //pnlAdd.Visible = false;
            //pnlReturn.Visible = true;
            //pnlShow.Visible = false;
        }

        private void btnAddOk_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car { Make = txtMake.Text, Model = txtModel.Text, Color = txtColor.Text, Rented = false });
            txtColor.Text = string.Empty;
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
        }
    }
}
