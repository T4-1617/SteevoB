namespace _160926OnlineBankFinal
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnNewCustomer = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lbxCustomer = new System.Windows.Forms.ListBox();
            this.lbxAccount = new System.Windows.Forms.ListBox();
            this.pnlOpenAccount = new System.Windows.Forms.Panel();
            this.btnAccountCancel = new System.Windows.Forms.Button();
            this.btnAccountAdd = new System.Windows.Forms.Button();
            this.txbFirstDeposit = new System.Windows.Forms.TextBox();
            this.txbAccountName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.txbDepositMoney = new System.Windows.Forms.TextBox();
            this.btnDepositAdd = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlWithdrawMoney = new System.Windows.Forms.Panel();
            this.txbWithdrawMoney = new System.Windows.Forms.TextBox();
            this.btnWithdrawAdd = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlAccountBalance = new System.Windows.Forms.Panel();
            this.lblAccountBalance = new System.Windows.Forms.Label();
            this.label2000 = new System.Windows.Forms.Label();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.lbxTransactions = new System.Windows.Forms.ListBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlNewCustomer = new System.Windows.Forms.Panel();
            this.btnCustomerCancel = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txbCustomerID = new System.Windows.Forms.TextBox();
            this.txbCustomerLastName = new System.Windows.Forms.TextBox();
            this.txbCustomerFirstName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpenAccount.SuspendLayout();
            this.pnlDepositMoney.SuspendLayout();
            this.pnlWithdrawMoney.SuspendLayout();
            this.pnlAccountBalance.SuspendLayout();
            this.pnlTransactions.SuspendLayout();
            this.pnlNewCustomer.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnNewCustomer
            // 
            this.btnNewCustomer.Location = new System.Drawing.Point(12, 54);
            this.btnNewCustomer.Name = "btnNewCustomer";
            this.btnNewCustomer.Size = new System.Drawing.Size(93, 77);
            this.btnNewCustomer.TabIndex = 0;
            this.btnNewCustomer.Text = "Ny kund";
            this.btnNewCustomer.UseVisualStyleBackColor = true;
            this.btnNewCustomer.Click += new System.EventHandler(this.btnNewCustomer_Click);
            // 
            // btnTransactions
            // 
            this.btnTransactions.Location = new System.Drawing.Point(12, 469);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(93, 77);
            this.btnTransactions.TabIndex = 1;
            this.btnTransactions.Text = "Transaktioner";
            this.btnTransactions.UseVisualStyleBackColor = true;
            this.btnTransactions.Click += new System.EventHandler(this.btnTransactions_Click);
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Location = new System.Drawing.Point(12, 386);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(93, 77);
            this.btnAccountBalance.TabIndex = 2;
            this.btnAccountBalance.Text = "Saldo";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            this.btnAccountBalance.Click += new System.EventHandler(this.btnAccountBalance_Click);
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Location = new System.Drawing.Point(12, 303);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(93, 77);
            this.btnWithdrawMoney.TabIndex = 3;
            this.btnWithdrawMoney.Text = "Ta ut pengar";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            this.btnWithdrawMoney.Click += new System.EventHandler(this.btnWithdrawMoney_Click);
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Location = new System.Drawing.Point(12, 220);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(93, 77);
            this.btnDepositMoney.TabIndex = 4;
            this.btnDepositMoney.Text = "Sätt in pengar";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            this.btnDepositMoney.Click += new System.EventHandler(this.btnDepositMoney_Click);
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Location = new System.Drawing.Point(12, 137);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(93, 77);
            this.btnOpenAccount.TabIndex = 5;
            this.btnOpenAccount.Text = "Öppna konto";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            this.btnOpenAccount.Click += new System.EventHandler(this.btnOpenAccount_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(675, 28);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(55, 13);
            this.label11.TabIndex = 39;
            this.label11.Text = "Välj Kund:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(675, 171);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Välj konto:";
            // 
            // lbxCustomer
            // 
            this.lbxCustomer.FormattingEnabled = true;
            this.lbxCustomer.Location = new System.Drawing.Point(620, 52);
            this.lbxCustomer.Name = "lbxCustomer";
            this.lbxCustomer.Size = new System.Drawing.Size(181, 108);
            this.lbxCustomer.TabIndex = 41;
            this.lbxCustomer.SelectedIndexChanged += new System.EventHandler(this.lbxCustomer_SelectedIndexChanged);
            // 
            // lbxAccount
            // 
            this.lbxAccount.FormattingEnabled = true;
            this.lbxAccount.Location = new System.Drawing.Point(620, 190);
            this.lbxAccount.Name = "lbxAccount";
            this.lbxAccount.Size = new System.Drawing.Size(181, 108);
            this.lbxAccount.TabIndex = 42;
            this.lbxAccount.SelectedIndexChanged += new System.EventHandler(this.lbxAccount_SelectedIndexChanged);
            // 
            // pnlOpenAccount
            // 
            this.pnlOpenAccount.Controls.Add(this.btnAccountCancel);
            this.pnlOpenAccount.Controls.Add(this.btnAccountAdd);
            this.pnlOpenAccount.Controls.Add(this.txbFirstDeposit);
            this.pnlOpenAccount.Controls.Add(this.txbAccountName);
            this.pnlOpenAccount.Controls.Add(this.label5);
            this.pnlOpenAccount.Controls.Add(this.label6);
            this.pnlOpenAccount.Location = new System.Drawing.Point(379, 52);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(216, 110);
            this.pnlOpenAccount.TabIndex = 34;
            this.pnlOpenAccount.Visible = false;
            // 
            // btnAccountCancel
            // 
            this.btnAccountCancel.Location = new System.Drawing.Point(121, 68);
            this.btnAccountCancel.Name = "btnAccountCancel";
            this.btnAccountCancel.Size = new System.Drawing.Size(75, 23);
            this.btnAccountCancel.TabIndex = 24;
            this.btnAccountCancel.Text = "Avbryt";
            this.btnAccountCancel.UseVisualStyleBackColor = true;
            this.btnAccountCancel.Click += new System.EventHandler(this.btnAccountCancel_Click);
            // 
            // btnAccountAdd
            // 
            this.btnAccountAdd.Location = new System.Drawing.Point(15, 68);
            this.btnAccountAdd.Name = "btnAccountAdd";
            this.btnAccountAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAccountAdd.TabIndex = 24;
            this.btnAccountAdd.Text = "Lägg till";
            this.btnAccountAdd.UseVisualStyleBackColor = true;
            this.btnAccountAdd.Click += new System.EventHandler(this.btnAccountAdd_Click);
            // 
            // txbFirstDeposit
            // 
            this.txbFirstDeposit.Location = new System.Drawing.Point(96, 39);
            this.txbFirstDeposit.Name = "txbFirstDeposit";
            this.txbFirstDeposit.Size = new System.Drawing.Size(100, 20);
            this.txbFirstDeposit.TabIndex = 19;
            // 
            // txbAccountName
            // 
            this.txbAccountName.Location = new System.Drawing.Point(96, 13);
            this.txbAccountName.Name = "txbAccountName";
            this.txbAccountName.Size = new System.Drawing.Size(100, 20);
            this.txbAccountName.TabIndex = 18;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(64, 13);
            this.label5.TabIndex = 16;
            this.label5.Text = "Kontonamn:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(17, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 13);
            this.label6.TabIndex = 17;
            this.label6.Text = "sätt in belopp:";
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.Controls.Add(this.txbDepositMoney);
            this.pnlDepositMoney.Controls.Add(this.btnDepositAdd);
            this.pnlDepositMoney.Controls.Add(this.label7);
            this.pnlDepositMoney.Location = new System.Drawing.Point(131, 190);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(216, 75);
            this.pnlDepositMoney.TabIndex = 35;
            this.pnlDepositMoney.Visible = false;
            // 
            // txbDepositMoney
            // 
            this.txbDepositMoney.Location = new System.Drawing.Point(103, 10);
            this.txbDepositMoney.Name = "txbDepositMoney";
            this.txbDepositMoney.Size = new System.Drawing.Size(100, 20);
            this.txbDepositMoney.TabIndex = 25;
            // 
            // btnDepositAdd
            // 
            this.btnDepositAdd.Location = new System.Drawing.Point(59, 36);
            this.btnDepositAdd.Name = "btnDepositAdd";
            this.btnDepositAdd.Size = new System.Drawing.Size(75, 23);
            this.btnDepositAdd.TabIndex = 24;
            this.btnDepositAdd.Text = "Sätt in";
            this.btnDepositAdd.UseVisualStyleBackColor = true;
            this.btnDepositAdd.Click += new System.EventHandler(this.btnDepositAdd_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 13);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 13);
            this.label7.TabIndex = 24;
            this.label7.Text = "Sätt in belopp:";
            // 
            // pnlWithdrawMoney
            // 
            this.pnlWithdrawMoney.Controls.Add(this.txbWithdrawMoney);
            this.pnlWithdrawMoney.Controls.Add(this.btnWithdrawAdd);
            this.pnlWithdrawMoney.Controls.Add(this.label8);
            this.pnlWithdrawMoney.Location = new System.Drawing.Point(379, 177);
            this.pnlWithdrawMoney.Name = "pnlWithdrawMoney";
            this.pnlWithdrawMoney.Size = new System.Drawing.Size(216, 75);
            this.pnlWithdrawMoney.TabIndex = 36;
            this.pnlWithdrawMoney.Visible = false;
            // 
            // txbWithdrawMoney
            // 
            this.txbWithdrawMoney.Location = new System.Drawing.Point(100, 10);
            this.txbWithdrawMoney.Name = "txbWithdrawMoney";
            this.txbWithdrawMoney.Size = new System.Drawing.Size(100, 20);
            this.txbWithdrawMoney.TabIndex = 27;
            // 
            // btnWithdrawAdd
            // 
            this.btnWithdrawAdd.Location = new System.Drawing.Point(63, 36);
            this.btnWithdrawAdd.Name = "btnWithdrawAdd";
            this.btnWithdrawAdd.Size = new System.Drawing.Size(75, 23);
            this.btnWithdrawAdd.TabIndex = 26;
            this.btnWithdrawAdd.Text = "Ta ut";
            this.btnWithdrawAdd.UseVisualStyleBackColor = true;
            this.btnWithdrawAdd.Click += new System.EventHandler(this.btnWithdrawAdd_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(10, 13);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(70, 13);
            this.label8.TabIndex = 26;
            this.label8.Text = "Ta ut belopp:";
            // 
            // pnlAccountBalance
            // 
            this.pnlAccountBalance.Controls.Add(this.lblAccountBalance);
            this.pnlAccountBalance.Controls.Add(this.label2000);
            this.pnlAccountBalance.Location = new System.Drawing.Point(131, 271);
            this.pnlAccountBalance.Name = "pnlAccountBalance";
            this.pnlAccountBalance.Size = new System.Drawing.Size(216, 45);
            this.pnlAccountBalance.TabIndex = 37;
            this.pnlAccountBalance.Visible = false;
            // 
            // lblAccountBalance
            // 
            this.lblAccountBalance.AutoSize = true;
            this.lblAccountBalance.Location = new System.Drawing.Point(56, 14);
            this.lblAccountBalance.Name = "lblAccountBalance";
            this.lblAccountBalance.Size = new System.Drawing.Size(35, 13);
            this.lblAccountBalance.TabIndex = 27;
            this.lblAccountBalance.Text = "empty";
            // 
            // label2000
            // 
            this.label2000.AutoSize = true;
            this.label2000.Location = new System.Drawing.Point(13, 14);
            this.label2000.Name = "label2000";
            this.label2000.Size = new System.Drawing.Size(37, 13);
            this.label2000.TabIndex = 26;
            this.label2000.Text = "Saldo:";
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Controls.Add(this.lbxTransactions);
            this.pnlTransactions.Controls.Add(this.label10);
            this.pnlTransactions.Location = new System.Drawing.Point(379, 258);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(216, 162);
            this.pnlTransactions.TabIndex = 38;
            this.pnlTransactions.Visible = false;
            // 
            // lbxTransactions
            // 
            this.lbxTransactions.FormattingEnabled = true;
            this.lbxTransactions.Location = new System.Drawing.Point(15, 32);
            this.lbxTransactions.Name = "lbxTransactions";
            this.lbxTransactions.Size = new System.Drawing.Size(181, 108);
            this.lbxTransactions.TabIndex = 28;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(17, 16);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(72, 13);
            this.label10.TabIndex = 27;
            this.label10.Text = "Transaktioner";
            // 
            // pnlNewCustomer
            // 
            this.pnlNewCustomer.Controls.Add(this.btnCustomerCancel);
            this.pnlNewCustomer.Controls.Add(this.btnCustomerAdd);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerID);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerLastName);
            this.pnlNewCustomer.Controls.Add(this.txbCustomerFirstName);
            this.pnlNewCustomer.Controls.Add(this.label2);
            this.pnlNewCustomer.Controls.Add(this.label3);
            this.pnlNewCustomer.Controls.Add(this.label4);
            this.pnlNewCustomer.Location = new System.Drawing.Point(131, 52);
            this.pnlNewCustomer.Name = "pnlNewCustomer";
            this.pnlNewCustomer.Size = new System.Drawing.Size(216, 132);
            this.pnlNewCustomer.TabIndex = 33;
            this.pnlNewCustomer.Visible = false;
            // 
            // btnCustomerCancel
            // 
            this.btnCustomerCancel.Location = new System.Drawing.Point(128, 89);
            this.btnCustomerCancel.Name = "btnCustomerCancel";
            this.btnCustomerCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerCancel.TabIndex = 23;
            this.btnCustomerCancel.Text = "Avbryt";
            this.btnCustomerCancel.UseVisualStyleBackColor = true;
            this.btnCustomerCancel.Click += new System.EventHandler(this.btnCustomerCancel_Click);
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(16, 89);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(75, 23);
            this.btnCustomerAdd.TabIndex = 22;
            this.btnCustomerAdd.Text = "Lägg till";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            this.btnCustomerAdd.Click += new System.EventHandler(this.btnCustomerAdd_Click);
            // 
            // txbCustomerID
            // 
            this.txbCustomerID.Location = new System.Drawing.Point(103, 63);
            this.txbCustomerID.Name = "txbCustomerID";
            this.txbCustomerID.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerID.TabIndex = 21;
            // 
            // txbCustomerLastName
            // 
            this.txbCustomerLastName.Location = new System.Drawing.Point(103, 34);
            this.txbCustomerLastName.Name = "txbCustomerLastName";
            this.txbCustomerLastName.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerLastName.TabIndex = 20;
            // 
            // txbCustomerFirstName
            // 
            this.txbCustomerFirstName.Location = new System.Drawing.Point(103, 8);
            this.txbCustomerFirstName.Name = "txbCustomerFirstName";
            this.txbCustomerFirstName.Size = new System.Drawing.Size(100, 20);
            this.txbCustomerFirstName.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 11);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 16;
            this.label2.Text = "Förnamn:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 39);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Efternamn:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 66);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 18;
            this.label4.Text = "Personnummer:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kund",
            "Anställd"});
            this.comboBox1.Location = new System.Drawing.Point(306, 27);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 32;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, -6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Välj användarroll:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(841, 644);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.lbxCustomer);
            this.Controls.Add(this.lbxAccount);
            this.Controls.Add(this.pnlOpenAccount);
            this.Controls.Add(this.pnlDepositMoney);
            this.Controls.Add(this.pnlWithdrawMoney);
            this.Controls.Add(this.pnlAccountBalance);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlNewCustomer);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnOpenAccount);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnNewCustomer);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpenAccount.ResumeLayout(false);
            this.pnlOpenAccount.PerformLayout();
            this.pnlDepositMoney.ResumeLayout(false);
            this.pnlDepositMoney.PerformLayout();
            this.pnlWithdrawMoney.ResumeLayout(false);
            this.pnlWithdrawMoney.PerformLayout();
            this.pnlAccountBalance.ResumeLayout(false);
            this.pnlAccountBalance.PerformLayout();
            this.pnlTransactions.ResumeLayout(false);
            this.pnlTransactions.PerformLayout();
            this.pnlNewCustomer.ResumeLayout(false);
            this.pnlNewCustomer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnNewCustomer;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.Button btnAccountBalance;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ListBox lbxCustomer;
        private System.Windows.Forms.ListBox lbxAccount;
        private System.Windows.Forms.Panel pnlOpenAccount;
        private System.Windows.Forms.Button btnAccountCancel;
        private System.Windows.Forms.Button btnAccountAdd;
        private System.Windows.Forms.TextBox txbFirstDeposit;
        private System.Windows.Forms.TextBox txbAccountName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel pnlDepositMoney;
        private System.Windows.Forms.TextBox txbDepositMoney;
        private System.Windows.Forms.Button btnDepositAdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlWithdrawMoney;
        private System.Windows.Forms.TextBox txbWithdrawMoney;
        private System.Windows.Forms.Button btnWithdrawAdd;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlAccountBalance;
        private System.Windows.Forms.Label lblAccountBalance;
        private System.Windows.Forms.Label label2000;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.ListBox lbxTransactions;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel pnlNewCustomer;
        private System.Windows.Forms.Button btnCustomerCancel;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txbCustomerID;
        private System.Windows.Forms.TextBox txbCustomerLastName;
        private System.Windows.Forms.TextBox txbCustomerFirstName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
    }
}

