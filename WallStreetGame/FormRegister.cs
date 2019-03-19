using System;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormRegister : Form
    {
        PlayerManager pm = new PlayerManager();
        string imagePath;

        public FormRegister()
        {
            InitializeComponent();
        }

        private void FormRegister_Load(object sender, EventArgs e)
        {
            tbFullNameReg.TabIndex = 0;
            tbUsernameReg.TabIndex = 1;
            tbPasswordReg.TabIndex = 2;
            tbDepositReg.TabIndex = 3;
            rbMaleReg.TabIndex = 4;
        }

        private void btnUploadPicReg_Click(object sender, EventArgs e)
        {
            using (var dialog = new OpenFileDialog() { Filter = "PNG|*.png|JPG|*.jpg|GIF|*.gif", Title = "Please select a photo", Multiselect = false })
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    pbPicReg.ImageLocation = dialog.FileName;
                    imagePath = pbPicReg.ImageLocation;
                }
            }
        }

        private void btnRegisterReg_Click(object sender, EventArgs e)
        {
            string fullName = tbFullNameReg.Text.Trim();
            string username = tbUsernameReg.Text.Trim();
            string password = tbPasswordReg.Text.Trim();
            decimal money;
            decimal moneyMax = 922337203685477;

            string sex = "";
            if (rbMaleReg.Checked) sex = rbMaleReg.Text;
            if (rbFemaleReg.Checked) sex = rbFemaleReg.Text;
            
            if (fullName == "") MessageBox.Show("Please, fill the Full Name field!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (fullName.Length > 50) MessageBox.Show("Your Full Name shouldn't be longer than 50 characters!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (username == "") MessageBox.Show("Please, fill the Username field!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (username.Length >= 16) MessageBox.Show("Username should be shorther than 16 characters");
            else if (password == "") MessageBox.Show("Please, fill the Password field!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (password.Length < 6) MessageBox.Show("Password should be at least 6 characters");
            else if (password.Length >= 16) MessageBox.Show("Password should be shorther than 16 characters");
            else if (sex == "") MessageBox.Show("Please, select your sex!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (decimal.TryParse(tbDepositReg.Text.Trim(), out money) == false) MessageBox.Show("Please, input only numbers in the deposit field!");
            else if (money > moneyMax) MessageBox.Show("Sorry, you can't deposit so much money!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (money < 0) MessageBox.Show("The amount of money must be a positive number!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (imagePath == null) MessageBox.Show("Please, choose your profile picture!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                byte[] image = pm.ConvertImageToByte(imagePath);
                pm.PlayerRegister(fullName, username, password, money, sex, image);
                var frmLog = new FormLogin();
                frmLog.FormClosed += FormLogin_Closed;
                Hide();
                frmLog.Show();
            }
            
        }

        private void FormLogin_Closed(object sender, EventArgs e)
        {
            Show();
        }

        private void chbEyeReg_CheckedChanged(object sender, EventArgs e)
        {
            tbPasswordReg.UseSystemPasswordChar = !tbPasswordReg.UseSystemPasswordChar; 
            // assigning the value that is not
        }
        
    }
}
