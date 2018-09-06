using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman1d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            txtUSDAustralia.Text = (
                Convert.ToDecimal(txtAmountAustralia.Text) * Convert.ToDecimal(txtRateAustralia.Text)
                ).ToString("0.00");
        }

        

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            txtUSDBhutan.Text = (
                Convert.ToDecimal(txtAmountBhutan.Text) * Convert.ToDecimal(txtRateBhutan.Text)
                ).ToString("0.00");
        }

        

        private void brazilTextChanged(object sender, EventArgs e)
        {
            txtUSDBrazil.Text = (
                 Convert.ToDecimal(txtAmountBrazil.Text) * Convert.ToDecimal(txtRateBrazil.Text)
                 ).ToString("0.00");
        }

        

        private void chinaTextChanged(object sender, EventArgs e)
        {
            txtUSDChina.Text = (
                Convert.ToDecimal(txtAmountChina.Text) * Convert.ToDecimal(txtRateChina.Text)
                ).ToString("0.00");
        }

        

        private void usdTextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
              99.99m
                ).ToString("0.00");
        }

        private void txtTotalUSD_TextChanged(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDAustralia.Text) + Convert.ToDecimal(txtUSDBhutan.Text) + Convert.ToDecimal(txtUSDBrazil.Text) + Convert.ToDecimal(txtUSDChina.Text)
                ).ToString("0.00");
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
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
    }
}
