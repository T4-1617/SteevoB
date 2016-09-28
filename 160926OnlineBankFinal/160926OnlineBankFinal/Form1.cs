﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _160926OnlineBankFinal
{
    public partial class Form1 : Form
    {
        private System.Collections.ArrayList _customers;
        private System.Collections.ArrayList Transactions;

        public Form1()
        {
            InitializeComponent();

            _customers = new System.Collections.ArrayList();
            Transactions = new System.Collections.ArrayList();
            //hård kodade customers o accounts
            Customer c = new Customer() { FirstName = "Oscar", LastName = "Oscarsson", Id = 1 };
            c.CreateAccount(1000, "kontot");
            _customers.Add(c);

            c = new Customer() { FirstName = "Petter", LastName = "Pettersson", Id = 2 };
            c.CreateAccount(1337, "kontot");
            c.CreateAccount(1000000, "kontot");
            _customers.Add(c);

            lbxCustomer.DisplayMember = "Name";
            foreach (Customer item in _customers)
            {
                lbxCustomer.Items.Add(item);
            }
        }

        private void EnableButtons(bool EnableButtonNewCustomer, bool EnableButtonOpenAccount, bool EnableButtonDepositMoney,
        bool EnableButtonWithdrawMoney, bool EnableButtonAccountBalance, bool EnableButtonTransactions)
        {
            btnNewCustomer.Enabled = EnableButtonNewCustomer;
            btnOpenAccount.Enabled = EnableButtonOpenAccount;
            btnDepositMoney.Enabled = EnableButtonDepositMoney;
            btnWithdrawMoney.Enabled = EnableButtonWithdrawMoney;
            btnAccountBalance.Enabled = EnableButtonAccountBalance;
            btnTransactions.Enabled = EnableButtonTransactions;

        }

        private void TogglePanels(bool pnlToggleNewCustomer, bool pnlToggleOpenAccount, bool pnlToggleDepositMoney,
        bool pnlToggleWithdrawMoney, bool pnlToggleAccountBlance, bool pnlToggleTransactions)
        {
            pnlNewCustomer.Visible = pnlToggleNewCustomer;
            pnlOpenAccount.Visible = pnlToggleOpenAccount;
            pnlDepositMoney.Visible = pnlToggleDepositMoney;
            pnlWithdrawMoney.Visible = pnlToggleWithdrawMoney;
            pnlAccountBalance.Visible = pnlToggleAccountBlance;
            pnlTransactions.Visible = pnlToggleTransactions;
        }

        private void ClearTextBoxes()
        {
            txbCustomerFirstName.Clear();
            txbCustomerLastName.Clear();
            txbCustomerID.Clear();
            txbFirstDeposit.Clear();
            txbAccountName.Clear();
            txbDepositMoney.Clear();
        }

        private void DisplayCustomer()
        {
            lbxCustomer.Items.Clear();
            foreach (Customer item in _customers)
            {
                lbxCustomer.Items.Add(item);
            }

        }

        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Customer c = (Customer)lbxCustomer.SelectedItem;
            DisplayAccounts(c);
        }

        private void DisplayAccounts(Customer c)
        {
            lbxAccount.Items.Clear();
            lbxAccount.DisplayMember = "AccountName";
            foreach (Account item in c.GetAccounts())
            {
                lbxAccount.Items.Add(item);
            }
        }

        private void btnDepositAdd_Click(object sender, EventArgs e)
        {
             if (txbDepositMoney.Text != string.Empty)
            {
                if (lbxAccount.SelectedItem != null)
                {
                    Account a = (Account)lbxAccount.SelectedItem;
                    Customer c = (Customer)lbxCustomer.SelectedItem;
                    a.Deposit(decimal.Parse(txbDepositMoney.Text));
                    lblAccountBalance.Text = string.Format("{0}", a.Balance);
                    Transactions.Add(new Transaction() { CustomerName = c.FirstName, AccountName = a.AccountName,
                    TransactionAmount = decimal.Parse(txbDepositMoney.Text), TransactionType = "satt in", TransactionWord = "i" });//lägger till nu transaction och skriver ut det i listboxen
                    TogglePanels(false, false, false, false, true, false);
                    ClearTextBoxes();
                }

            }

            else
            {
                MessageBox.Show("Du måste ange ett värde.");
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (comboBox1.SelectedIndex)
            {
                case 0:
                    EnableButtons(true, true, true, true, true, false);
                    lbxCustomer.Enabled = true;
                    break;

                case 1:
                    EnableButtons(true, true, false, false, false, true);
                    lbxCustomer.Enabled = true;
                    break;

                default:
                    EnableButtons(false, false, false, false, false, false);
                    lbxCustomer.Enabled = false;
                    break;
            }
        }

        private void btnNewCustomer_Click(object sender, EventArgs e)
        {
            TogglePanels(true, false, false, false, false, false);
        }

        private void btnOpenAccount_Click(object sender, EventArgs e)
        {
            TogglePanels(false, true, false, false, false, false);
        }

        private void btnDepositMoney_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, true, false, false, false);
        }

        private void btnWithdrawMoney_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, true, false, false);
        }

        private void btnAccountBalance_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, true, false);
        }

        private void btnTransactions_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, true);
            lbxTransactions.Items.Clear();
            foreach (Transaction item in Transactions)
            {
                lbxTransactions.Items.Add(item);
            }
        }

        private void btnCustomerAdd_Click(object sender, EventArgs e)
        {
            if (txbCustomerFirstName.Text != string.Empty || txbCustomerLastName.Text != string.Empty || txbCustomerID.Text != string.Empty)
            {
                _customers.Add(new Customer() { FirstName = txbCustomerFirstName.Text, LastName = txbCustomerLastName.Text, Id = long.Parse(txbCustomerID.Text) });
                DisplayCustomer();
                ClearTextBoxes();
            }

            else
            {
                MessageBox.Show("Formuläret måste fyllas i.");
            }
        }

        private void lbxAccount_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lbxAccount.SelectedItem != null)
            {
                Account a = (Account)lbxAccount.SelectedItem;
                lblAccountBalance.Text = string.Format("{0}", a.Balance);
            }
        }

        private void btnAccountAdd_Click(object sender, EventArgs e)
        {
            if (txbAccountName.Text != string.Empty || txbFirstDeposit.Text != string.Empty)
            {
                Customer c = (Customer)lbxCustomer.SelectedItem;
                if (lbxCustomer.SelectedItem != null)
                {
                    c.CreateAccount(decimal.Parse(txbFirstDeposit.Text), txbAccountName.Text);
                    ClearTextBoxes();
                    DisplayAccounts(c);
                }
            }
            else
            {
                MessageBox.Show("Formuläret måste fyllas i.");
            }
        }

        private void btnWithdrawAdd_Click(object sender, EventArgs e)
        {
            if (txbWithdrawMoney.Text != string.Empty)
            {
                Account a = (Account)lbxAccount.SelectedItem;
                Customer c = (Customer)lbxCustomer.SelectedItem;
                if (lbxAccount.SelectedItem != null)
                {
                    a.Withdraw(decimal.Parse(txbWithdrawMoney.Text));
                    lblAccountBalance.Text = string.Format("{0}", a.Balance);
                    ClearTextBoxes();
                    TogglePanels(false, false, false, false, true, false);

                    Transactions.Add(new Transaction()
                    {
                        CustomerName = c.FirstName,
                        AccountName = a.AccountName,
                        TransactionAmount = decimal.Parse(txbWithdrawMoney.Text),
                        TransactionType = "tagit ur",
                        TransactionWord = "ur"
                    });
                }
            }
        }

        private void btnCustomerCancel_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }

        private void btnAccountCancel_Click(object sender, EventArgs e)
        {
            TogglePanels(false, false, false, false, false, false);
        }
    }
}
