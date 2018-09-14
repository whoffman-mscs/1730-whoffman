using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman1f1
{
    public partial class FrmCurrency : Form
    {
        public FrmCurrency()
        {
            InitializeComponent();
        }

        private void FrmCurrency_Load(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.719895";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            txtCurrency.Focus();
        }

        private void btnAustralia_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            lblCurrency.Text = btnAustralia.Text + ": ";
            txtCurrency.Focus();
        }

        private void btnBhutan_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutan.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            lblCurrency.Text = btnBhutan.Text + ": ";
            txtRate.Text = "0.0139347";
            txtCurrency.Focus();
        }

        private void btnBrazil_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazil.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            lblCurrency.Text = btnBrazil.Text + ": ";
            txtRate.Text = "0.241259";
            txtCurrency.Focus();
        }

        private void btnChina_Click(object sender, EventArgs e)
        {
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnAustralia.BackgroundImage = picAustraliaDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnChina.BackgroundImage = picChina.Image;
            lblCurrency.Text = btnChina.Text + ": ";
            txtRate.Text = "0.146417";
            txtCurrency.Focus();
        }

        private void calcUSD(object sender, EventArgs e)
        {
            txtUSDollars.Text = (
                Convert.ToDecimal(txtCurrency.Text) * Convert.ToDecimal(txtRate.Text)
                ).ToString("0.00");
        }

        private void txtCurrency_Enter(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void txtCurrency_Click(object sender, EventArgs e)
        {
            txtCurrency.SelectAll();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            txtTotalUSD.Text = (
                Convert.ToDecimal(txtUSDollars.Text) + Convert.ToDecimal(txtTotalUSD.Text)
                ).ToString("0.00");
            lblEquation.Text = lblEquation.Text + " + " + txtUSDollars.Text;
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            btnAustralia.BackgroundImage = picAustralia.Image;
            btnBhutan.BackgroundImage = picBhutanDim.Image;
            btnBrazil.BackgroundImage = picBrazilDim.Image;
            btnChina.BackgroundImage = picChinaDim.Image;
            lblCurrency.Text = btnAustralia.Text;
            txtCurrency.Text = "0.00";
            txtRate.Text = "0.719895";
            txtUSDollars.Text = "0.00";
            txtTotalUSD.Text = "0.00";
            lblEquation.Text = "";
            txtCurrency.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
