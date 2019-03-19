using System;
using System.Windows.Forms;

namespace WallStreetGame
{
    public partial class FormBank : Form
    {
        PlayerManager pm = new PlayerManager();

        public FormBank()
        {
            InitializeComponent();
        }
        
        private void btnDepositBank_Click(object sender, EventArgs e)
        {
            decimal depositAmount = 0;
            try
            {
                depositAmount = decimal.Parse(tbDepositBank.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter only numbers!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Sorry, you can't deposit so much money!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                var player = pm.GetCurrentPlayer();
                decimal oldMoney = player.Money;
                decimal moneyUpdate = depositAmount + oldMoney;
                decimal maxMoneyAmount = 922337203685477;

                if (moneyUpdate > maxMoneyAmount) MessageBox.Show("Sorry, we don't have so much money in storage! Try with another sum!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (moneyUpdate < oldMoney) MessageBox.Show("Do not try to steal! Why are you so rude?", "OMG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbDepositBank.Text == "" || decimal.TryParse(tbDepositBank.Text, out decimal ignore) == false) tbDepositBank.Text = String.Empty;
                else
                {
                    pm.PlayerMoney(moneyUpdate, 0);
                    MessageBox.Show("Your deposit has been successfully transferred!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDepositBank.Text = String.Empty;
                }
            }
        }

        private void btnWithdrawBank_Click(object sender, EventArgs e)
        {
            decimal withdrawAmount = 0;
            try
            {
               withdrawAmount = decimal.Parse(tbWithdrawBank.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter only numbers!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (OverflowException)
            {
                MessageBox.Show("Sorry, you can't withdraw so much money!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                var player = pm.GetCurrentPlayer();
                decimal oldMoney = player.Money;
                decimal moneyUpdate = oldMoney - withdrawAmount;
                if (withdrawAmount < 0) MessageBox.Show("Sorry, you can't withdraw a negative sum! Try again!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (withdrawAmount > oldMoney) MessageBox.Show("You don't have enough money!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbWithdrawBank.Text == "" || decimal.TryParse(tbWithdrawBank.Text, out decimal ignore) == false) tbWithdrawBank.Text = String.Empty;
                else
                {
                    pm.PlayerMoney(moneyUpdate, 0);
                    MessageBox.Show("Your withdraw has been successfully transferred!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbWithdrawBank.Text = String.Empty;
                }
            }
        }

        private void btnGetLoanBank_Click(object sender, EventArgs e)
        {
            double loan = 0;
            double months = 0;
            try
            {
                loan = double.Parse(tbGetLoanBank.Text.Trim());
                months = double.Parse(tbPayPeriodBank.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter only numbers!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                var player = pm.GetCurrentPlayer();
                decimal maxMoneyAmount = 922337203685477;
                

                if (loan > (double)maxMoneyAmount) MessageBox.Show("Sorry, we don't have so much money in storage! Try with another sum!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (months > 60) MessageBox.Show("Sorry, you can't take loans for more than 5 years!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (months <= 0 && tbPayPeriodBank.Text == "") { }
                else if (loan < 0) MessageBox.Show("Do not try to steal! Why are you so rude?", "OMG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else
                {
                    double total = loan * (1 + 0.045 * months);
                    lblTotalBank.Text = total.ToString();
                    double sumPerMonth = total / months;
                    lblMonthlyBank.Text = sumPerMonth.ToString();
                    decimal oldMoney = player.Money;
                    decimal moneyUpdate = oldMoney + (decimal)loan;
                    decimal loanUpdate = player.Loan + (decimal)total;

                    pm.PlayerMoney(moneyUpdate, loanUpdate);
                    MessageBox.Show("Your loan has been successfully transferred!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
        }
        
        private void btnPayLoanBank_Click(object sender, EventArgs e)
        {
            double loan = 0;
            try
            {
                loan = double.Parse(tbPayLoanBank.Text.Trim());
            }
            catch (FormatException)
            {
                MessageBox.Show("Please, enter only numbers!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            finally
            {
                var player = pm.GetCurrentPlayer();
                decimal oldMoney = player.Money;
                decimal moneyUpdate = oldMoney - (decimal)loan;
                decimal moneyPaidLoan = player.Loan - (decimal)loan;
          
                if ((decimal)loan > player.Loan) MessageBox.Show("Sorry, you are paying too much money back!", "Oops!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (loan < 0) MessageBox.Show("Do not try to steal! Why are you so rude?", "OMG!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                else if (tbPayLoanBank.Text == "" || decimal.TryParse(tbPayLoanBank.Text, out decimal ignore) == false) tbPayLoanBank.Text = String.Empty;
                else
                {
                    pm.PlayerMoney(moneyUpdate, moneyPaidLoan);
                    MessageBox.Show("Your loan has been successfully transferred!", "Congrats!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    tbDepositBank.Text = String.Empty;
                }
            }
        }

        private void btnExitBank_Click(object sender, EventArgs e)
        {
            var frmPr = new FormProfile();
            frmPr.FormClosed += FormProfile_Closed;
            Hide();
            frmPr.Show();
        }

        private void FormProfile_Closed(object sender, EventArgs e)
        {
            Show();
        }
    }
}
