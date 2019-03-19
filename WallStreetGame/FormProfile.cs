using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormProfile : Form
    {
        PlayerManager pm = new PlayerManager();

        public FormProfile()
        {
            InitializeComponent();
        }

        private void FormProfile_Load(object sender, EventArgs e)
        {
            Player player = pm.GetCurrentPlayer();
            lblFullNameProfile.Text = player.FullName;
            lblUsernameProfile.Text = player.Username;
            pbPicProfile.Image = Image.FromStream(pm.ConvertByteToImage());

            lblMoneyProfile.Text = player.Money.ToString();
            lblSexProfile.Text = player.Sex;
            lblCapacityProfile.Text = (player.Gold + player.Petrol + player.Antiques + player.Bitcoin + player.Shares + player.Technologies).ToString();
            lblGoldProfile.Text = player.Gold.ToString();
            lblPetrolProfile.Text = player.Petrol.ToString();
            lblAntiquesProfile.Text = player.Antiques.ToString();
            lblBitcoinProfile.Text = player.Bitcoin.ToString();
            lblSharesProfile.Text = player.Shares.ToString();
            lblTechnologiesProfile.Text = player.Technologies.ToString();
            lblLoanProfile.Text = player.Loan.ToString();
        }
        
        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmPass = new FormChangePass();
            frmPass.FormClosed += FormPass_Closed;
            Hide();
            frmPass.Show();
        }

        private void FormPass_Closed(object sender, EventArgs e)
        {
            Show();
        }
        
        private void deleteAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Delete account" , MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pm.PlayerDeleteAccount();
                var frmLog = new FormLogin();
                Hide();
                frmLog.Show();
            }        
        }
        
        private void restartAccountToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var result = MessageBox.Show("Are you sure?", "Restart account", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                pm.PlayerRestartAccount();
                var frmLog = new FormLogin();
                Hide();
                frmLog.Show();
            }
        }
        
        private void ranglistToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmRang = new FormRanglist();
            frmRang.FormClosed += FormRanglist_Closed;
            Hide();
            frmRang.Show();
        }

        private void FormRanglist_Closed(object sender, EventArgs e)
        {
            Show();
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmLog = new FormLogin();
            Hide();
            frmLog.Show();
        }

        private void changeProfilePicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            PictureBox pictureBox = pbPicProfile;
            pm.PlayerImageChange(pictureBox);
        }

        private void gameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmG = new FormGame();
            frmG.FormClosed += FormGame_Closed;
            Hide();
            frmG.Show();
        }

        private void FormGame_Closed(object sender, EventArgs e)
        {
            Show();
        }

        private void bankToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmB = new FormBank();
            frmB.FormClosed += FormBank_Closed;
            Hide();
            frmB.Show();
        }

        private void FormBank_Closed(object sender, EventArgs e)
        {
            Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var frmI = new FormInfo();
            frmI.FormClosed += FormInfo_Closed;
            Hide();
            frmI.Show();
        }

        private void FormInfo_Closed(object sender, EventArgs e)
        {
            Show();
        }

       
        
    }
}
