namespace ACMECAR160916
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
            this.btnShow = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblCarsAvailable = new System.Windows.Forms.Label();
            this.pnlShow = new System.Windows.Forms.Panel();
            this.pnlInfo = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBook = new System.Windows.Forms.Button();
            this.lstCars = new System.Windows.Forms.ListBox();
            this.pnlAdd = new System.Windows.Forms.Panel();
            this.btnAddOk = new System.Windows.Forms.Button();
            this.txtColor = new System.Windows.Forms.TextBox();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.txtMake = new System.Windows.Forms.TextBox();
            this.lblColor = new System.Windows.Forms.Label();
            this.lblModel = new System.Windows.Forms.Label();
            this.lblMake = new System.Windows.Forms.Label();
            this.pnlReturn = new System.Windows.Forms.Panel();
            this.btnReturnOk = new System.Windows.Forms.Button();
            this.lstReturn = new System.Windows.Forms.ListBox();
            this.lblMakeInfo = new System.Windows.Forms.Label();
            this.lblModelInfo = new System.Windows.Forms.Label();
            this.lblColorInfo = new System.Windows.Forms.Label();
            this.pnlShow.SuspendLayout();
            this.pnlInfo.SuspendLayout();
            this.pnlAdd.SuspendLayout();
            this.pnlReturn.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(12, 35);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(102, 40);
            this.btnShow.TabIndex = 0;
            this.btnShow.Text = "Show cars";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(120, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(102, 40);
            this.btnAdd.TabIndex = 1;
            this.btnAdd.Text = "Add cars";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnReturn
            // 
            this.btnReturn.Location = new System.Drawing.Point(228, 35);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(102, 40);
            this.btnReturn.TabIndex = 2;
            this.btnReturn.Text = "Return car";
            this.btnReturn.UseVisualStyleBackColor = true;
            this.btnReturn.Click += new System.EventHandler(this.btnReturn_Click);
            // 
            // lblCarsAvailable
            // 
            this.lblCarsAvailable.AutoSize = true;
            this.lblCarsAvailable.Location = new System.Drawing.Point(3, 6);
            this.lblCarsAvailable.Name = "lblCarsAvailable";
            this.lblCarsAvailable.Size = new System.Drawing.Size(35, 13);
            this.lblCarsAvailable.TabIndex = 3;
            this.lblCarsAvailable.Text = "label1";
            // 
            // pnlShow
            // 
            this.pnlShow.Controls.Add(this.pnlInfo);
            this.pnlShow.Controls.Add(this.btnBook);
            this.pnlShow.Controls.Add(this.lstCars);
            this.pnlShow.Controls.Add(this.lblCarsAvailable);
            this.pnlShow.Location = new System.Drawing.Point(12, 94);
            this.pnlShow.Name = "pnlShow";
            this.pnlShow.Size = new System.Drawing.Size(268, 178);
            this.pnlShow.TabIndex = 4;
            // 
            // pnlInfo
            // 
            this.pnlInfo.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pnlInfo.Controls.Add(this.lblColorInfo);
            this.pnlInfo.Controls.Add(this.lblModelInfo);
            this.pnlInfo.Controls.Add(this.lblMakeInfo);
            this.pnlInfo.Controls.Add(this.label4);
            this.pnlInfo.Controls.Add(this.label3);
            this.pnlInfo.Controls.Add(this.label2);
            this.pnlInfo.Location = new System.Drawing.Point(132, 22);
            this.pnlInfo.Name = "pnlInfo";
            this.pnlInfo.Size = new System.Drawing.Size(133, 108);
            this.pnlInfo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(3, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(34, 13);
            this.label4.TabIndex = 2;
            this.label4.Text = "Color:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 47);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Model:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Make:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnBook
            // 
            this.btnBook.Location = new System.Drawing.Point(77, 135);
            this.btnBook.Name = "btnBook";
            this.btnBook.Size = new System.Drawing.Size(102, 40);
            this.btnBook.TabIndex = 1;
            this.btnBook.Text = "Book";
            this.btnBook.UseVisualStyleBackColor = true;
            this.btnBook.Click += new System.EventHandler(this.btnBook_Click);
            // 
            // lstCars
            // 
            this.lstCars.FormattingEnabled = true;
            this.lstCars.Location = new System.Drawing.Point(3, 22);
            this.lstCars.Name = "lstCars";
            this.lstCars.Size = new System.Drawing.Size(126, 108);
            this.lstCars.TabIndex = 0;
            this.lstCars.SelectedIndexChanged += new System.EventHandler(this.lstCars_SelectedIndexChanged);
            // 
            // pnlAdd
            // 
            this.pnlAdd.Controls.Add(this.btnAddOk);
            this.pnlAdd.Controls.Add(this.txtColor);
            this.pnlAdd.Controls.Add(this.txtModel);
            this.pnlAdd.Controls.Add(this.txtMake);
            this.pnlAdd.Controls.Add(this.lblColor);
            this.pnlAdd.Controls.Add(this.lblModel);
            this.pnlAdd.Controls.Add(this.lblMake);
            this.pnlAdd.Location = new System.Drawing.Point(286, 113);
            this.pnlAdd.Name = "pnlAdd";
            this.pnlAdd.Size = new System.Drawing.Size(268, 159);
            this.pnlAdd.TabIndex = 5;
            // 
            // btnAddOk
            // 
            this.btnAddOk.Location = new System.Drawing.Point(83, 116);
            this.btnAddOk.Name = "btnAddOk";
            this.btnAddOk.Size = new System.Drawing.Size(102, 40);
            this.btnAddOk.TabIndex = 6;
            this.btnAddOk.Text = "Add";
            this.btnAddOk.UseVisualStyleBackColor = true;
            this.btnAddOk.Click += new System.EventHandler(this.btnAddOk_Click);
            // 
            // txtColor
            // 
            this.txtColor.Location = new System.Drawing.Point(52, 60);
            this.txtColor.Name = "txtColor";
            this.txtColor.Size = new System.Drawing.Size(100, 20);
            this.txtColor.TabIndex = 5;
            // 
            // txtModel
            // 
            this.txtModel.Location = new System.Drawing.Point(52, 35);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(100, 20);
            this.txtModel.TabIndex = 4;
            // 
            // txtMake
            // 
            this.txtMake.Location = new System.Drawing.Point(52, 11);
            this.txtMake.Name = "txtMake";
            this.txtMake.Size = new System.Drawing.Size(100, 20);
            this.txtMake.TabIndex = 3;
            // 
            // lblColor
            // 
            this.lblColor.AutoSize = true;
            this.lblColor.Location = new System.Drawing.Point(10, 63);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(31, 13);
            this.lblColor.TabIndex = 2;
            this.lblColor.Text = "Color";
            // 
            // lblModel
            // 
            this.lblModel.AutoSize = true;
            this.lblModel.Location = new System.Drawing.Point(10, 38);
            this.lblModel.Name = "lblModel";
            this.lblModel.Size = new System.Drawing.Size(36, 13);
            this.lblModel.TabIndex = 1;
            this.lblModel.Text = "Model";
            // 
            // lblMake
            // 
            this.lblMake.AutoSize = true;
            this.lblMake.Location = new System.Drawing.Point(10, 15);
            this.lblMake.Name = "lblMake";
            this.lblMake.Size = new System.Drawing.Size(34, 13);
            this.lblMake.TabIndex = 0;
            this.lblMake.Text = "Make";
            // 
            // pnlReturn
            // 
            this.pnlReturn.Controls.Add(this.btnReturnOk);
            this.pnlReturn.Controls.Add(this.lstReturn);
            this.pnlReturn.Location = new System.Drawing.Point(560, 113);
            this.pnlReturn.Name = "pnlReturn";
            this.pnlReturn.Size = new System.Drawing.Size(268, 159);
            this.pnlReturn.TabIndex = 6;
            // 
            // btnReturnOk
            // 
            this.btnReturnOk.Location = new System.Drawing.Point(79, 117);
            this.btnReturnOk.Name = "btnReturnOk";
            this.btnReturnOk.Size = new System.Drawing.Size(102, 40);
            this.btnReturnOk.TabIndex = 7;
            this.btnReturnOk.Text = "Return";
            this.btnReturnOk.UseVisualStyleBackColor = true;
            this.btnReturnOk.Click += new System.EventHandler(this.btnReturnOk_Click);
            // 
            // lstReturn
            // 
            this.lstReturn.FormattingEnabled = true;
            this.lstReturn.Location = new System.Drawing.Point(3, 3);
            this.lstReturn.Name = "lstReturn";
            this.lstReturn.Size = new System.Drawing.Size(262, 108);
            this.lstReturn.TabIndex = 0;
            // 
            // lblMakeInfo
            // 
            this.lblMakeInfo.AutoSize = true;
            this.lblMakeInfo.Location = new System.Drawing.Point(47, 16);
            this.lblMakeInfo.Name = "lblMakeInfo";
            this.lblMakeInfo.Size = new System.Drawing.Size(30, 13);
            this.lblMakeInfo.TabIndex = 3;
            this.lblMakeInfo.Text = "aasd";
            // 
            // lblModelInfo
            // 
            this.lblModelInfo.AutoSize = true;
            this.lblModelInfo.Location = new System.Drawing.Point(50, 47);
            this.lblModelInfo.Name = "lblModelInfo";
            this.lblModelInfo.Size = new System.Drawing.Size(35, 13);
            this.lblModelInfo.TabIndex = 4;
            this.lblModelInfo.Text = "label5";
            // 
            // lblColorInfo
            // 
            this.lblColorInfo.AutoSize = true;
            this.lblColorInfo.Location = new System.Drawing.Point(47, 78);
            this.lblColorInfo.Name = "lblColorInfo";
            this.lblColorInfo.Size = new System.Drawing.Size(35, 13);
            this.lblColorInfo.TabIndex = 5;
            this.lblColorInfo.Text = "label6";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(840, 391);
            this.Controls.Add(this.pnlReturn);
            this.Controls.Add(this.pnlAdd);
            this.Controls.Add(this.pnlShow);
            this.Controls.Add(this.btnReturn);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnShow);
            this.Name = "Form1";
            this.Text = "Form1";
            this.pnlShow.ResumeLayout(false);
            this.pnlShow.PerformLayout();
            this.pnlInfo.ResumeLayout(false);
            this.pnlInfo.PerformLayout();
            this.pnlAdd.ResumeLayout(false);
            this.pnlAdd.PerformLayout();
            this.pnlReturn.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblCarsAvailable;
        private System.Windows.Forms.Panel pnlShow;
        private System.Windows.Forms.Panel pnlAdd;
        private System.Windows.Forms.Panel pnlReturn;
        private System.Windows.Forms.ListBox lstCars;
        private System.Windows.Forms.TextBox txtColor;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.TextBox txtMake;
        private System.Windows.Forms.Label lblColor;
        private System.Windows.Forms.Label lblModel;
        private System.Windows.Forms.Label lblMake;
        private System.Windows.Forms.ListBox lstReturn;
        private System.Windows.Forms.Button btnBook;
        private System.Windows.Forms.Button btnAddOk;
        private System.Windows.Forms.Button btnReturnOk;
        private System.Windows.Forms.Panel pnlInfo;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblColorInfo;
        private System.Windows.Forms.Label lblModelInfo;
        private System.Windows.Forms.Label lblMakeInfo;
    }
}

