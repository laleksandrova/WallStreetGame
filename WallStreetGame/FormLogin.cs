using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormLogin : Form
    {
        PlayerManager pm = new PlayerManager(); 

        public FormLogin()
        {
            InitializeComponent();
        }

        private void btnRegisterLogin_Click(object sender, EventArgs e)
        {
            var frmReg = new FormRegister(); //нова инстанция на регистер формата
            frmReg.Closed += FormRegister_Closed; //методът се извиква само когато е затворена формата
            Hide(); //скрива се логин(tekushtata) формата
            frmReg.Show(); //появява се регистер формата
        }

        private void btnLoginLogin_Click(object sender, EventArgs e)
        {
            string username = tbUsernameLogin.Text.Trim();
            string password = tbPasswordLogin.Text.Trim();

            if (username == "") MessageBox.Show("Please, input an username!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (password == "") MessageBox.Show("Please, input a password!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (pm.PlayerLogin(username, password) == null) MessageBox.Show("Wrong credentials!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                pm.PlayerLogin(username, password);
                MessageBox.Show($"Welcome to WallStreet Game, {PlayerManager.currentPlayerUsername}!");
                var frmPr = new FormProfile();
                frmPr.FormClosed += FormProfile_Closed;
                Hide();
                frmPr.Show();
            }
        }

        private void btnLoginLogin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnLoginLogin.PerformClick();
            }
        }

        private void FormRegister_Closed(object sender, EventArgs e)
        {
            Show(); //връща ме в текущата форма, където е написан кодът за Hide()/Show()
        }

        private void FormProfile_Closed(object sender, EventArgs e)
        {
            Show();
        }
        
        private void chbEyeReg_CheckedChanged_1(object sender, EventArgs e)
        {
            tbPasswordLogin.UseSystemPasswordChar = !tbPasswordLogin.UseSystemPasswordChar;
        }
    }
}
