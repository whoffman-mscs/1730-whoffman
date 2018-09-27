using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman2b2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        

        

        private void calculate(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountAustralia.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");

            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");

            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateBrazil.Text);
            decimal usdBrazil = amountBrazil * rateBrazil;
            txtUSDBrazil.Text = usdBrazil.ToString("0.00");

            decimal amountChina = Convert.ToDecimal(txtAmountChina.Text);
            decimal rateChina = Convert.ToDecimal(txtRateChina.Text);
            decimal usdChina = amountChina * rateChina;
            txtUSDChina.Text = usdChina.ToString("0.00");

            decimal totalUSD = usdAustralia + usdBhutan + usdBrazil + usdChina;
            txtTotalUSD.Text = totalUSD.ToString("0.00");
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtAmountAustralia.Text = "0.00";
            txtRateAustralia.Text = "0.719895";
            txtAmountBhutan.Text = "0.00";
            txtRateBhutan.Text = "0.0139347";
            txtAmountBrazil.Text = "0.00";
            txtRateBrazil.Text = "0.241259";
            txtAmountChina.Text = "0.00";
            txtRateChina.Text = "0.146417";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
