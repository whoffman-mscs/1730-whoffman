using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman2b1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void australiaTextChanged(object sender, EventArgs e)
        {
            decimal amountAustralia = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateAustralia = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountAustralia * rateAustralia;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
        }

        private void bhutanTextChanged(object sender, EventArgs e)
        {
            decimal amountBhutan = Convert.ToDecimal(txtAmountBhutan.Text);
            decimal rateBhutan = Convert.ToDecimal(txtRateBhutan.Text);
            decimal usdBhutan = amountBhutan * rateBhutan;
            txtUSDBhutan.Text = usdBhutan.ToString("0.00");
        }

        private void brazilTextChanged(object sender, EventArgs e)
        {
            decimal amountBrazil = Convert.ToDecimal(txtAmountBrazil.Text);
            decimal rateBrazil = Convert.ToDecimal(txtRateAustralia.Text);
            decimal usdAustralia = amountBrazil * rateBrazil;
            txtUSDAustralia.Text = usdAustralia.ToString("0.00");
        }
    }
}
