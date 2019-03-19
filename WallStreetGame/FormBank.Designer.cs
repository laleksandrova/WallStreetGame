namespace WallStreetGame
{
    partial class FormBank
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBank));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblTotalBank = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblMonthlyBank = new System.Windows.Forms.Label();
            this.tbPayPeriodBank = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbGetLoanBank = new System.Windows.Forms.TextBox();
            this.btnGetLoanBank = new System.Windows.Forms.Button();
            this.btnPayLoanBank = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnDepositBank = new System.Windows.Forms.Button();
            this.tbDepositBank = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tbWithdrawBank = new System.Windows.Forms.TextBox();
            this.btnWithdrawBank = new System.Windows.Forms.Button();
            this.btnExitBank = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.tbPayLoanBank = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalBank);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.lblMonthlyBank);
            this.groupBox1.Controls.Add(this.tbPayPeriodBank);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tbGetLoanBank);
            this.groupBox1.Controls.Add(this.btnGetLoanBank);
            this.groupBox1.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox1.Location = new System.Drawing.Point(38, 238);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(399, 430);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Loan";
            // 
            // lblTotalBank
            // 
            this.lblTotalBank.AutoSize = true;
            this.lblTotalBank.Location = new System.Drawing.Point(257, 311);
            this.lblTotalBank.Name = "lblTotalBank";
            this.lblTotalBank.Size = new System.Drawing.Size(28, 31);
            this.lblTotalBank.TabIndex = 23;
            this.lblTotalBank.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(28, 311);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(134, 31);
            this.label5.TabIndex = 22;
            this.label5.Text = "Total to pay";
            // 
            // lblMonthlyBank
            // 
            this.lblMonthlyBank.AutoSize = true;
            this.lblMonthlyBank.Location = new System.Drawing.Point(257, 363);
            this.lblMonthlyBank.Name = "lblMonthlyBank";
            this.lblMonthlyBank.Size = new System.Drawing.Size(28, 31);
            this.lblMonthlyBank.TabIndex = 21;
            this.lblMonthlyBank.Text = "0";
            // 
            // tbPayPeriodBank
            // 
            this.tbPayPeriodBank.Location = new System.Drawing.Point(243, 242);
            this.tbPayPeriodBank.Name = "tbPayPeriodBank";
            this.tbPayPeriodBank.Size = new System.Drawing.Size(110, 36);
            this.tbPayPeriodBank.TabIndex = 20;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(28, 363);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(196, 31);
            this.label3.TabIndex = 19;
            this.label3.Text = "Monthly payment";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(28, 229);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(178, 62);
            this.label2.TabIndex = 18;
            this.label2.Text = "Payment period\r\n(in months)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(80, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 31);
            this.label1.TabIndex = 17;
            this.label1.Text = "Interest rate: 4.5% ";
            // 
            // tbGetLoanBank
            // 
            this.tbGetLoanBank.Location = new System.Drawing.Point(80, 52);
            this.tbGetLoanBank.Name = "tbGetLoanBank";
            this.tbGetLoanBank.Size = new System.Drawing.Size(205, 36);
            this.tbGetLoanBank.TabIndex = 2;
            // 
            // btnGetLoanBank
            // 
            this.btnGetLoanBank.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnGetLoanBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnGetLoanBank.Location = new System.Drawing.Point(104, 153);
            this.btnGetLoanBank.Name = "btnGetLoanBank";
            this.btnGetLoanBank.Size = new System.Drawing.Size(148, 38);
            this.btnGetLoanBank.TabIndex = 0;
            this.btnGetLoanBank.Text = "Get Loan";
            this.btnGetLoanBank.UseVisualStyleBackColor = false;
            this.btnGetLoanBank.Click += new System.EventHandler(this.btnGetLoanBank_Click);
            // 
            // btnPayLoanBank
            // 
            this.btnPayLoanBank.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnPayLoanBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnPayLoanBank.Location = new System.Drawing.Point(71, 131);
            this.btnPayLoanBank.Name = "btnPayLoanBank";
            this.btnPayLoanBank.Size = new System.Drawing.Size(150, 38);
            this.btnPayLoanBank.TabIndex = 1;
            this.btnPayLoanBank.Text = "Pay Loan";
            this.btnPayLoanBank.UseVisualStyleBackColor = false;
            this.btnPayLoanBank.Click += new System.EventHandler(this.btnPayLoanBank_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnDepositBank);
            this.groupBox2.Controls.Add(this.tbDepositBank);
            this.groupBox2.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox2.Location = new System.Drawing.Point(38, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 184);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Deposit";
            // 
            // btnDepositBank
            // 
            this.btnDepositBank.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnDepositBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnDepositBank.Location = new System.Drawing.Point(117, 118);
            this.btnDepositBank.Name = "btnDepositBank";
            this.btnDepositBank.Size = new System.Drawing.Size(118, 38);
            this.btnDepositBank.TabIndex = 4;
            this.btnDepositBank.Text = "Deposit";
            this.btnDepositBank.UseVisualStyleBackColor = false;
            this.btnDepositBank.Click += new System.EventHandler(this.btnDepositBank_Click);
            // 
            // tbDepositBank
            // 
            this.tbDepositBank.Location = new System.Drawing.Point(71, 52);
            this.tbDepositBank.Name = "tbDepositBank";
            this.tbDepositBank.Size = new System.Drawing.Size(205, 36);
            this.tbDepositBank.TabIndex = 3;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tbWithdrawBank);
            this.groupBox3.Controls.Add(this.btnWithdrawBank);
            this.groupBox3.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox3.Location = new System.Drawing.Point(429, 23);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(353, 184);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Withdraw";
            // 
            // tbWithdrawBank
            // 
            this.tbWithdrawBank.Location = new System.Drawing.Point(76, 52);
            this.tbWithdrawBank.Name = "tbWithdrawBank";
            this.tbWithdrawBank.Size = new System.Drawing.Size(205, 36);
            this.tbWithdrawBank.TabIndex = 2;
            // 
            // btnWithdrawBank
            // 
            this.btnWithdrawBank.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnWithdrawBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnWithdrawBank.Location = new System.Drawing.Point(100, 124);
            this.btnWithdrawBank.Name = "btnWithdrawBank";
            this.btnWithdrawBank.Size = new System.Drawing.Size(148, 38);
            this.btnWithdrawBank.TabIndex = 0;
            this.btnWithdrawBank.Text = "Withdraw";
            this.btnWithdrawBank.UseVisualStyleBackColor = false;
            this.btnWithdrawBank.Click += new System.EventHandler(this.btnWithdrawBank_Click);
            // 
            // btnExitBank
            // 
            this.btnExitBank.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnExitBank.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnExitBank.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExitBank.Location = new System.Drawing.Point(477, 601);
            this.btnExitBank.Name = "btnExitBank";
            this.btnExitBank.Size = new System.Drawing.Size(305, 63);
            this.btnExitBank.TabIndex = 3;
            this.btnExitBank.Text = "Exit";
            this.btnExitBank.UseVisualStyleBackColor = false;
            this.btnExitBank.Click += new System.EventHandler(this.btnExitBank_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.tbPayLoanBank);
            this.groupBox4.Controls.Add(this.btnPayLoanBank);
            this.groupBox4.Font = new System.Drawing.Font("Segoe Script", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.groupBox4.Location = new System.Drawing.Point(477, 238);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(305, 209);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Pay Loan";
            // 
            // tbPayLoanBank
            // 
            this.tbPayLoanBank.Location = new System.Drawing.Point(42, 65);
            this.tbPayLoanBank.Name = "tbPayLoanBank";
            this.tbPayLoanBank.Size = new System.Drawing.Size(205, 36);
            this.tbPayLoanBank.TabIndex = 3;
            // 
            // FormBank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallStreetGame.Properties.Resources.detelinki;
            this.ClientSize = new System.Drawing.Size(822, 703);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnExitBank);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormBank";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bank";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox tbGetLoanBank;
        private System.Windows.Forms.Button btnPayLoanBank;
        private System.Windows.Forms.Button btnGetLoanBank;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnDepositBank;
        private System.Windows.Forms.TextBox tbDepositBank;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox tbWithdrawBank;
        private System.Windows.Forms.Button btnWithdrawBank;
        private System.Windows.Forms.Label lblTotalBank;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblMonthlyBank;
        private System.Windows.Forms.TextBox tbPayPeriodBank;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnExitBank;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox tbPayLoanBank;
    }
}