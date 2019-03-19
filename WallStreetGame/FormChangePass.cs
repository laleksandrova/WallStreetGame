using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormChangePass : Form
    {
        PlayerManager pm = new PlayerManager();
        public FormChangePass()
        {
            InitializeComponent();
        }

        private void btnChangePassChange_Click(object sender, EventArgs e)
        {
            string oldPass = tbOldPassChange.Text.Trim();
            string newPass = tbNewPassChange.Text.Trim();
            string repeatPass = tbRepeatPassChange.Text.Trim();

            var player = pm.GetCurrentPlayer();
            
            if (player.Password != oldPass) MessageBox.Show("Your password is wrong!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (oldPass == newPass) MessageBox.Show("Please, insert a new password!","Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else if (newPass.Length < 6) MessageBox.Show("Password should be more than 6 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newPass.Length >= 16) MessageBox.Show("Password should be shorther than 16 characters", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (newPass != repeatPass) MessageBox.Show("Please, repeat your new password again!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                pm.PlayerPasswordChange(newPass);
                MessageBox.Show("Your password has been successfully changed!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                FormChangePass.ActiveForm.Visible = false;
                FormLogin frmLog = new FormLogin();
                frmLog.ShowDialog();
            }
        }

        private void chbEyeReg_CheckedChanged(object sender, EventArgs e)
        {
            tbOldPassChange.UseSystemPasswordChar = !tbOldPassChange.UseSystemPasswordChar;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            tbNewPassChange.UseSystemPasswordChar = !tbNewPassChange.UseSystemPasswordChar;
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            tbRepeatPassChange.UseSystemPasswordChar = !tbRepeatPassChange.UseSystemPasswordChar;
        }
    }
}
