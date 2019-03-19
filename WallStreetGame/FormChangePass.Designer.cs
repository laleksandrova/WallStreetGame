namespace WallStreetGame
{
    partial class FormChangePass
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormChangePass));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbOldPassChange = new System.Windows.Forms.TextBox();
            this.tbNewPassChange = new System.Windows.Forms.TextBox();
            this.tbRepeatPassChange = new System.Windows.Forms.TextBox();
            this.btnChangePassChange = new System.Windows.Forms.Button();
            this.chbEyeReg = new System.Windows.Forms.CheckBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Lavender;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label1.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(49, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 48);
            this.label1.TabIndex = 2;
            this.label1.Text = "Old password";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Lavender;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label2.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(47, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(230, 48);
            this.label2.TabIndex = 3;
            this.label2.Text = "New password";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Lavender;
            this.label3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.label3.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(22, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(275, 48);
            this.label3.TabIndex = 4;
            this.label3.Text = "Repeat Password";
            // 
            // tbOldPassChange
            // 
            this.tbOldPassChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbOldPassChange.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbOldPassChange.Location = new System.Drawing.Point(322, 58);
            this.tbOldPassChange.Name = "tbOldPassChange";
            this.tbOldPassChange.Size = new System.Drawing.Size(231, 34);
            this.tbOldPassChange.TabIndex = 5;
            this.tbOldPassChange.UseSystemPasswordChar = true;
            // 
            // tbNewPassChange
            // 
            this.tbNewPassChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbNewPassChange.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbNewPassChange.Location = new System.Drawing.Point(322, 128);
            this.tbNewPassChange.Name = "tbNewPassChange";
            this.tbNewPassChange.Size = new System.Drawing.Size(231, 34);
            this.tbNewPassChange.TabIndex = 6;
            this.tbNewPassChange.UseSystemPasswordChar = true;
            // 
            // tbRepeatPassChange
            // 
            this.tbRepeatPassChange.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tbRepeatPassChange.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tbRepeatPassChange.Location = new System.Drawing.Point(322, 202);
            this.tbRepeatPassChange.Name = "tbRepeatPassChange";
            this.tbRepeatPassChange.Size = new System.Drawing.Size(231, 34);
            this.tbRepeatPassChange.TabIndex = 7;
            this.tbRepeatPassChange.UseSystemPasswordChar = true;
            // 
            // btnChangePassChange
            // 
            this.btnChangePassChange.BackColor = System.Drawing.Color.PapayaWhip;
            this.btnChangePassChange.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnChangePassChange.Font = new System.Drawing.Font("Segoe Script", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnChangePassChange.Location = new System.Drawing.Point(133, 280);
            this.btnChangePassChange.Name = "btnChangePassChange";
            this.btnChangePassChange.Size = new System.Drawing.Size(342, 63);
            this.btnChangePassChange.TabIndex = 8;
            this.btnChangePassChange.Text = "Change password";
            this.btnChangePassChange.UseVisualStyleBackColor = false;
            this.btnChangePassChange.Click += new System.EventHandler(this.btnChangePassChange_Click);
            // 
            // chbEyeReg
            // 
            this.chbEyeReg.AutoSize = true;
            this.chbEyeReg.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.chbEyeReg.Image = global::WallStreetGame.Properties.Resources.eye1;
            this.chbEyeReg.Location = new System.Drawing.Point(559, 58);
            this.chbEyeReg.Name = "chbEyeReg";
            this.chbEyeReg.Size = new System.Drawing.Size(48, 34);
            this.chbEyeReg.TabIndex = 24;
            this.chbEyeReg.UseVisualStyleBackColor = false;
            this.chbEyeReg.CheckedChanged += new System.EventHandler(this.chbEyeReg_CheckedChanged);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox1.Image = global::WallStreetGame.Properties.Resources.eye1;
            this.checkBox1.Location = new System.Drawing.Point(559, 131);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(48, 34);
            this.checkBox1.TabIndex = 25;
            this.checkBox1.UseVisualStyleBackColor = false;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.checkBox2.Image = global::WallStreetGame.Properties.Resources.eye1;
            this.checkBox2.Location = new System.Drawing.Point(559, 202);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(48, 34);
            this.checkBox2.TabIndex = 26;
            this.checkBox2.UseVisualStyleBackColor = false;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // FormChangePass
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WallStreetGame.Properties.Resources.detelinki;
            this.ClientSize = new System.Drawing.Size(641, 371);
            this.Controls.Add(this.checkBox2);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.chbEyeReg);
            this.Controls.Add(this.btnChangePassChange);
            this.Controls.Add(this.tbRepeatPassChange);
            this.Controls.Add(this.tbNewPassChange);
            this.Controls.Add(this.tbOldPassChange);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormChangePass";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Change password";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbOldPassChange;
        private System.Windows.Forms.TextBox tbNewPassChange;
        private System.Windows.Forms.TextBox tbRepeatPassChange;
        private System.Windows.Forms.Button btnChangePassChange;
        private System.Windows.Forms.CheckBox chbEyeReg;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.CheckBox checkBox2;
    }
}