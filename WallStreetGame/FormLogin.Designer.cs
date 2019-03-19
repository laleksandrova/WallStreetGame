namespace WallStreetGame
{
    partial class FormLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tbUsernameLogin = new System.Windows.Forms.TextBox();
            this.tbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLoginLogin = new System.Windows.Forms.Button();
            this.btnRegisterLogin = new System.Windows.Forms.Button();
            this.chbEyeReg = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(18, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 48);
            this.label1.TabIndex = 5;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(21, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(160, 48);
            this.label2.TabIndex = 6;
            this.label2.Text = "Password";
            // 
            // tbUsernameLogin
            // 
            this.tbUsernameLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbUsernameLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbUsernameLogin.Location = new System.Drawing.Point(215, 54);
            this.tbUsernameLogin.Name = "tbUsernameLogin";
            this.tbUsernameLogin.Size = new System.Drawing.Size(231, 34);
            this.tbUsernameLogin.TabIndex = 0;
            // 
            // tbPasswordLogin
            // 
            this.tbPasswordLogin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbPasswordLogin.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbPasswordLogin.Location = new System.Drawing.Point(215, 134);
            this.tbPasswordLogin.Name = "tbPasswordLogin";
            this.tbPasswordLogin.Size = new System.Drawing.Size(231, 34);
            this.tbPasswordLogin.TabIndex = 1;
            this.tbPasswordLogin.UseSystemPasswordChar = true;
            // 
            // btnLoginLogin
            // 
            this.btnLoginLogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnLoginLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnLoginLogin.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoginLogin.Location = new System.Drawing.Point(66, 220);
            this.btnLoginLogin.Name = "btnLoginLogin";
            this.btnLoginLogin.Size = new System.Drawing.Size(147, 63);
            this.btnLoginLogin.TabIndex = 2;
            this.btnLoginLogin.Text = "Login";
            this.btnLoginLogin.UseVisualStyleBackColor = false;
            this.btnLoginLogin.Click += new System.EventHandler(this.btnLoginLogin_Click);
            this.btnLoginLogin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.btnLoginLogin_KeyPress);
            // 
            // btnRegisterLogin
            // 
            this.btnRegisterLogin.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnRegisterLogin.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRegisterLogin.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRegisterLogin.Location = new System.Drawing.Point(243, 220);
            this.btnRegisterLogin.Name = "btnRegisterLogin";
            this.btnRegisterLogin.Size = new System.Drawing.Size(192, 63);
            this.btnRegisterLogin.TabIndex = 3;
            this.btnRegisterLogin.Text = "Register";
            this.btnRegisterLogin.UseVisualStyleBackColor = false;
            this.btnRegisterLogin.Click += new System.EventHandler(this.btnRegisterLogin_Click);
            // 
            // chbEyeReg
            // 
            this.chbEyeReg.AutoSize = true;
            this.chbEyeReg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbEyeReg.Image = global::WallStreetGame.Properties.Resources.eye1;
            this.chbEyeReg.Location = new System.Drawing.Point(452, 134);
            this.chbEyeReg.Name = "chbEyeReg";
            this.chbEyeReg.Size = new System.Drawing.Size(48, 34);
            this.chbEyeReg.TabIndex = 24;
            this.chbEyeReg.UseVisualStyleBackColor = false;
            this.chbEyeReg.CheckedChanged += new System.EventHandler(this.chbEyeReg_CheckedChanged_1);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallStreetGame.Properties.Resources.detelinki;
            this.ClientSize = new System.Drawing.Size(520, 326);
            this.Controls.Add(this.chbEyeReg);
            this.Controls.Add(this.btnRegisterLogin);
            this.Controls.Add(this.btnLoginLogin);
            this.Controls.Add(this.tbPasswordLogin);
            this.Controls.Add(this.tbUsernameLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbUsernameLogin;
        private System.Windows.Forms.TextBox tbPasswordLogin;
        private System.Windows.Forms.Button btnLoginLogin;
        private System.Windows.Forms.Button btnRegisterLogin;
        private System.Windows.Forms.CheckBox chbEyeReg;
    }
}

