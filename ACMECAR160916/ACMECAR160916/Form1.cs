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
        int AvailableCars;

        public Form1()
        {
            InitializeComponent();

            
            pnlShow.Visible = false;
            pnlAdd.Visible = false;
            pnlReturn.Visible = false;

            Cars = new System.Collections.ArrayList();

            Cars.Add(new Car() { Make = "Volvo", Model = "V70", Color = "Blue", Rented = false });
            Cars.Add(new Car() { Make = "Dodge", Model = "Nitro", Color = "Silver", Rented = false });
            Cars.Add(new Car() { Make = "Porsche", Model = "Cayenne", Color = "Orange", Rented = false });


        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            AvailableCars = 0;
            pnlShow.Visible = true;
            pnlReturn.Visible = false;
            pnlAdd.Visible = false;
            pnlInfo.Visible = false;

            lstCars.Items.Clear();

            foreach (Car item in Cars)
            {
                if (!item.Rented)
                {
                    lstCars.Items.Add(item);
                    lstCars.DisplayMember = "MakeModel";
                    AvailableCars++;
                }
            }
            lblCarsAvailable.Text = String.Format("We have {0} car(s) available", AvailableCars);



        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = true;
            pnlReturn.Visible = false;
            pnlShow.Visible = false;
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            pnlAdd.Visible = false;
            pnlReturn.Visible = true;
            pnlShow.Visible = false;

            lstReturn.Items.Clear();

            foreach (Car item in Cars)
            {
                if (item.Rented)
                {
                    lstReturn.Items.Add(item);
                    lstReturn.DisplayMember = "MakeModel";
                }
            }
        }

        private void btnAddOk_Click(object sender, EventArgs e)
        {
            Cars.Add(new Car { Make = txtMake.Text, Model = txtModel.Text, Color = txtColor.Text, Rented = false });
            txtColor.Text = string.Empty;
            txtMake.Text = string.Empty;
            txtModel.Text = string.Empty;
            txtMake.Focus();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            Car x = (Car)lstCars.SelectedItem;
            x.Rented = true;
            lstCars.Items.Clear();

            foreach (Car item in Cars)
            {

                if (!item.Rented)
                {
                    lstCars.Items.Add(item);
                }
            }       
        }

        private void btnReturnOk_Click(object sender, EventArgs e)
        {
            AvailableCars++;
            Car x = (Car)lstReturn.SelectedItem;
            x.Rented = false;
            lstReturn.Items.Clear();

            foreach (Car item in Cars)
            {
                if (item.Rented)
                {
                    lstReturn.Items.Add(item);
                }

            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstCars_SelectedIndexChanged(object sender, EventArgs e)
        {
            Car x = (Car)lstCars.SelectedItem;
            if (x != null)
            {
                pnlInfo.Visible = true;
                lblMakeInfo.Text = x.Make;
                lblModelInfo.Text = x.Model;
                lblColorInfo.Text = x.Color;
            }
        }
    }
}
