namespace OnlineBank
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
            this.btnOpenAccount = new System.Windows.Forms.Button();
            this.btnDepositMoney = new System.Windows.Forms.Button();
            this.btnWithdrawMoney = new System.Windows.Forms.Button();
            this.btnAccountBalance = new System.Windows.Forms.Button();
            this.btnTransactions = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pnlOpenAccount = new System.Windows.Forms.Panel();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.pnlDepositMoney = new System.Windows.Forms.Panel();
            this.pnlWithdrawMoney = new System.Windows.Forms.Panel();
            this.pnlAccountBalance = new System.Windows.Forms.Panel();
            this.pnlTransactions = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlOpenAccount.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnOpenAccount
            // 
            this.btnOpenAccount.Enabled = false;
            this.btnOpenAccount.Location = new System.Drawing.Point(12, 61);
            this.btnOpenAccount.Name = "btnOpenAccount";
            this.btnOpenAccount.Size = new System.Drawing.Size(88, 50);
            this.btnOpenAccount.TabIndex = 0;
            this.btnOpenAccount.Text = "Öppna konto";
            this.btnOpenAccount.UseVisualStyleBackColor = true;
            // 
            // btnDepositMoney
            // 
            this.btnDepositMoney.Enabled = false;
            this.btnDepositMoney.Location = new System.Drawing.Point(12, 117);
            this.btnDepositMoney.Name = "btnDepositMoney";
            this.btnDepositMoney.Size = new System.Drawing.Size(88, 50);
            this.btnDepositMoney.TabIndex = 1;
            this.btnDepositMoney.Text = "Sätt in $";
            this.btnDepositMoney.UseVisualStyleBackColor = true;
            // 
            // btnWithdrawMoney
            // 
            this.btnWithdrawMoney.Enabled = false;
            this.btnWithdrawMoney.Location = new System.Drawing.Point(12, 173);
            this.btnWithdrawMoney.Name = "btnWithdrawMoney";
            this.btnWithdrawMoney.Size = new System.Drawing.Size(88, 50);
            this.btnWithdrawMoney.TabIndex = 2;
            this.btnWithdrawMoney.Text = "Ta ut $";
            this.btnWithdrawMoney.UseVisualStyleBackColor = true;
            // 
            // btnAccountBalance
            // 
            this.btnAccountBalance.Enabled = false;
            this.btnAccountBalance.Location = new System.Drawing.Point(12, 229);
            this.btnAccountBalance.Name = "btnAccountBalance";
            this.btnAccountBalance.Size = new System.Drawing.Size(88, 50);
            this.btnAccountBalance.TabIndex = 3;
            this.btnAccountBalance.Text = "Saldo";
            this.btnAccountBalance.UseVisualStyleBackColor = true;
            // 
            // btnTransactions
            // 
            this.btnTransactions.Enabled = false;
            this.btnTransactions.Location = new System.Drawing.Point(12, 302);
            this.btnTransactions.Name = "btnTransactions";
            this.btnTransactions.Size = new System.Drawing.Size(88, 50);
            this.btnTransactions.TabIndex = 4;
            this.btnTransactions.Text = "Engagemang";
            this.btnTransactions.UseVisualStyleBackColor = true;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Kund",
            "Anställd"});
            this.comboBox1.Location = new System.Drawing.Point(250, 6);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(159, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Välj användarroll";
            // 
            // pnlOpenAccount
            // 
            this.pnlOpenAccount.Controls.Add(this.label8);
            this.pnlOpenAccount.Controls.Add(this.label7);
            this.pnlOpenAccount.Controls.Add(this.label6);
            this.pnlOpenAccount.Controls.Add(this.label5);
            this.pnlOpenAccount.Controls.Add(this.label4);
            this.pnlOpenAccount.Controls.Add(this.textBox5);
            this.pnlOpenAccount.Controls.Add(this.textBox4);
            this.pnlOpenAccount.Controls.Add(this.textBox3);
            this.pnlOpenAccount.Controls.Add(this.textBox2);
            this.pnlOpenAccount.Controls.Add(this.textBox1);
            this.pnlOpenAccount.Location = new System.Drawing.Point(122, 61);
            this.pnlOpenAccount.Name = "pnlOpenAccount";
            this.pnlOpenAccount.Size = new System.Drawing.Size(285, 238);
            this.pnlOpenAccount.TabIndex = 7;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(864, 61);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(120, 134);
            this.listBox1.TabIndex = 8;
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(864, 223);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(120, 134);
            this.listBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(896, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Välj kund";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(896, 207);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Välj konto";
            // 
            // pnlDepositMoney
            // 
            this.pnlDepositMoney.Location = new System.Drawing.Point(413, 61);
            this.pnlDepositMoney.Name = "pnlDepositMoney";
            this.pnlDepositMoney.Size = new System.Drawing.Size(285, 238);
            this.pnlDepositMoney.TabIndex = 8;
            // 
            // pnlWithdrawMoney
            // 
            this.pnlWithdrawMoney.Location = new System.Drawing.Point(122, 305);
            this.pnlWithdrawMoney.Name = "pnlWithdrawMoney";
            this.pnlWithdrawMoney.Size = new System.Drawing.Size(285, 238);
            this.pnlWithdrawMoney.TabIndex = 8;
            // 
            // pnlAccountBalance
            // 
            this.pnlAccountBalance.Location = new System.Drawing.Point(413, 305);
            this.pnlAccountBalance.Name = "pnlAccountBalance";
            this.pnlAccountBalance.Size = new System.Drawing.Size(285, 238);
            this.pnlAccountBalance.TabIndex = 8;
            // 
            // pnlTransactions
            // 
            this.pnlTransactions.Location = new System.Drawing.Point(122, 549);
            this.pnlTransactions.Name = "pnlTransactions";
            this.pnlTransactions.Size = new System.Drawing.Size(285, 238);
            this.pnlTransactions.TabIndex = 8;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(116, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 1;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 82);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 2;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 108);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 3;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 134);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Kontonamn";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 59);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 13);
            this.label5.TabIndex = 6;
            this.label5.Text = "Pengar";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 85);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(35, 13);
            this.label6.TabIndex = 7;
            this.label6.Text = "label6";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 111);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 8;
            this.label7.Text = "label7";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 13);
            this.label8.TabIndex = 9;
            this.label8.Text = "label8";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(996, 733);
            this.Controls.Add(this.pnlTransactions);
            this.Controls.Add(this.pnlAccountBalance);
            this.Controls.Add(this.pnlWithdrawMoney);
            this.Controls.Add(this.pnlDepositMoney);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.pnlOpenAccount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.btnTransactions);
            this.Controls.Add(this.btnAccountBalance);
            this.Controls.Add(this.btnWithdrawMoney);
            this.Controls.Add(this.btnDepositMoney);
            this.Controls.Add(this.btnOpenAccount);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlOpenAccount.ResumeLayout(false);
            this.pnlOpenAccount.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenAccount;
        private System.Windows.Forms.Button btnDepositMoney;
        private System.Windows.Forms.Button btnWithdrawMoney;
        private System.Windows.Forms.Button btnAccountBalance;
        private System.Windows.Forms.Button btnTransactions;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pnlOpenAccount;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.ListBox listBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlDepositMoney;
        private System.Windows.Forms.Panel pnlWithdrawMoney;
        private System.Windows.Forms.Panel pnlAccountBalance;
        private System.Windows.Forms.Panel pnlTransactions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
    }
}

