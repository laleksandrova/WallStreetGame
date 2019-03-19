using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormGame : Form
    {
        Random rnd = new Random();
        PlayerManager pm = new PlayerManager();

        static readonly double goldPrice = 40;
        static readonly double petrolPrice = 60;
        static readonly double bitcoinPrice = 3000;
        static readonly double sharesPrice = 1000;
        static readonly double antiquesPrice = 1500;
        static readonly double technologiesPrice = 2000;
        
        public FormGame()
        {
           
            InitializeComponent();
        }

        private void FormGame_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Timer timer1 = new System.Windows.Forms.Timer();
            timer1.Interval = 2000;
            timer1.Tick += new EventHandler(CalculatePrice);
            timer1.Start();

            Player player = pm.GetCurrentPlayer();

            lblMoneyGame.Text = player.Money.ToString();
            lblGoldGame.Text = player.Gold.ToString();
            lblPetrolGame.Text = player.Petrol.ToString();
            lblAntiquesGame.Text = player.Antiques.ToString();
            lblBitcoinGame.Text = player.Bitcoin.ToString();
            lblSharesGame.Text = player.Shares.ToString();
            lblTechnologiesGame.Text = player.Technologies.ToString();

            CalculateCoefficient(lblGoldKoefGame);
            CalculateCoefficient(lblPetrolKoefGame);
            CalculateCoefficient(lblBitcoinKoefGame);
            CalculateCoefficient(lblTechnKoefGame);
            CalculateCoefficient(lblSharesKoefGame);
            CalculateCoefficient(lblAntiquesKoefGame);
        }

        #region Gold
        private void btnBuyGoldGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuyGoldGame, lblGoldKoefGame, lblGoldGame, goldPrice);
        }

        private void nudBuyGoldGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuyGoldGame, btnBuyGoldGame);
        }

        private void btnSellGoldGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellGoldGame, lblGoldKoefGame, lblGoldGame, goldPrice);
        }

        private void nudSellGoldGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellGoldGame, btnSellGoldGame);
        }
        #endregion

        #region Petrol
        private void btnBuyPetrolGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuyPetrolGame, lblPetrolKoefGame, lblPetrolGame, petrolPrice);
        }

        private void nudBuyPetrolGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuyPetrolGame, btnBuyPetrolGame);
        }

        private void btnSellPetrolGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellPetrolGame, lblPetrolKoefGame, lblPetrolGame, petrolPrice);
        }

        private void nudSellPetrolGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellPetrolGame, btnSellPetrolGame);
        }
        #endregion

        #region Bitcoin
        private void btnBuyBitcoinGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuyBitcoinGame, lblBitcoinKoefGame, lblBitcoinGame, bitcoinPrice);
        }

        private void nudBuyBitcoinGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuyBitcoinGame, btnBuyBitcoinGame);
        }

        private void btnSellBitcoinGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellBitcoinGame, lblBitcoinGame, lblBitcoinGame, bitcoinPrice);
        }

        private void nudSellBitcoinGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellBitcoinGame, btnSellBitcoinGame);
        }
        #endregion

        #region Technologies
        private void btnBuyTechnologiesGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuyTechnologiesGame, lblTechnKoefGame, lblTechnologiesGame, technologiesPrice);
        }

        private void nudBuyTechnologiesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuyTechnologiesGame, btnBuyTechnologiesGame);
        }

        private void btnSellTechnologiesGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellTechnologiesGame, lblTechnKoefGame, lblTechnologiesGame, technologiesPrice);
        }

        private void nudSellTechnologiesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellTechnologiesGame, btnSellTechnologiesGame);
        }
        #endregion

        #region Antiques
        private void btnBuyAntiquesGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuyAntiquesGame, lblAntiquesKoefGame, lblAntiquesGame, antiquesPrice);
        }

        private void nudBuyAntiquesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuyAntiquesGame, btnBuyAntiquesGame);
        }

        private void btnSellAntiquesGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellAntiquesGame, lblAntiquesKoefGame, lblAntiquesGame, antiquesPrice);
        }

        private void nudSellAntiquesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellAntiquesGame, btnSellAntiquesGame);
        }
        #endregion

        #region Shares
        private void btnBuySharesGame_Click(object sender, EventArgs e)
        {
            BuyGoods(nudBuySharesGame, lblSharesKoefGame, lblSharesGame, sharesPrice);
        }

        private void nudBuySharesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudBuySharesGame, btnBuySharesGame);
        }

        private void btnSellSharesGame_Click(object sender, EventArgs e)
        {
            SellGoods(nudSellSharesGame, lblSharesKoefGame, lblSharesGame, sharesPrice);
        }

        private void nudSellSharesGame_ValueChanged(object sender, EventArgs e)
        {
            ButtonToggle(nudSellSharesGame, btnSellSharesGame);
        }
        #endregion
        
        private void BuyGoods(NumericUpDown nud, Label coefficient, Label good, double goodPrice)
        {
            double amount = (double)nud.Value;
            decimal amountMax = 9223372036854775807;
            double koeficient = double.Parse(coefficient.Text);
            double sum = koeficient * amount * goodPrice;
            double playerMoney = double.Parse(lblMoneyGame.Text);

            if (sum > playerMoney)
            {
                MessageBox.Show("Sorry, you don't have enough money!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else if ((decimal)amount > amountMax) MessageBox.Show("Sorry, you have reached the limit!", "Oops", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            else
            {
                double playerChange = playerMoney - sum;
                lblMoneyGame.Text = playerChange.ToString();
                double stock = double.Parse(good.Text) + amount;
                good.Text = stock.ToString();
                nud.Value = 0;
            }
           
        }

        private void SellGoods(NumericUpDown nud, Label coefficient, Label good, double goodPrice)
        {
            double amount = (double)nud.Value;
            double koeficient = double.Parse(coefficient.Text);
            double sum = koeficient * amount * goodPrice;
            double playerMoney = double.Parse(lblMoneyGame.Text);
            double stock = double.Parse(good.Text) - amount;

            if (stock < 0)
            {
                MessageBox.Show("Sorry,you don't have enough of this good!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double playerChange = playerMoney + sum;
                lblMoneyGame.Text = playerChange.ToString();
                good.Text = stock.ToString();
                nud.Value = 0;
            }

        }

        private void ButtonToggle(NumericUpDown nud, Button button)
        {
            if (nud.Value > 0) button.Enabled = true;
            else button.Enabled = false;
        }

        private void CalculatePrice(object source, EventArgs e)
        {
            CalculateCoefficient(lblGoldKoefGame);
            CalculateCoefficient(lblPetrolKoefGame);
            CalculateCoefficient(lblBitcoinKoefGame);
            CalculateCoefficient(lblTechnKoefGame);
            CalculateCoefficient(lblSharesKoefGame);
            CalculateCoefficient(lblAntiquesKoefGame);
        }

        private void CalculateCoefficient(Label label)
        {
            float number = rnd.Next(50, 151) / 100f;
            label.Text = number.ToString("N2");
            if (number < 1) label.ForeColor = System.Drawing.Color.Green;
            else label.ForeColor = System.Drawing.Color.Red;
        }

        private void btnSaveGame_Click(object sender, EventArgs e)
        {
            using (var db = new PlayerEntities())
            {
                var player = db.Players.SingleOrDefault(p => p.Username == PlayerManager.currentPlayerUsername);

                player.Money = decimal.Parse(lblMoneyGame.Text);
                player.Gold = long.Parse(lblGoldGame.Text);
                player.Petrol = long.Parse(lblPetrolGame.Text);
                player.Bitcoin = long.Parse(lblBitcoinGame.Text);
                player.Technologies = long.Parse(lblTechnologiesGame.Text);
                player.Antiques = long.Parse(lblAntiquesGame.Text);
                player.Shares = long.Parse(lblSharesGame.Text);

                db.SaveChanges();

                FormGame.ActiveForm.Dispose();
                FormProfile frmP = new FormProfile();
                frmP.ShowDialog();
            }
        }
    }
}
