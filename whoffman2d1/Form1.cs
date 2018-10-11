﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman2d1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void setPassValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "Frank";
            textBox2Input.Text = "";
            textBox3Input.Text = "2.3";
            textBox4Input.Text = "false";
            textBox5AInput.Text = "2";
            textBox5BInput.Text = "2";
            textBox6Input.Text = "xyz";
            textBox7Input.Text = "1";
            textBox8AInput.Text = "1";
            textBox8BInput.Text = "2";
            textBox9Input.Text = "500";
            textBox10AInput.Text = "2";
            textBox10BInput.Text = "3";
            
        }

        private void setFailValuesButton_Click(object sender, EventArgs e)
        {
            textBox1Input.Text = "xyz";
            textBox2Input.Text = "xyz";
            textBox3Input.Text = "2.4";
            textBox4Input.Text = "true";
            textBox5AInput.Text = "2";
            textBox5BInput.Text = "3";
            textBox6Input.Text = "Jones";
            textBox7Input.Text = "0";
            textBox8AInput.Text = "1";
            textBox8BInput.Text = "1";
            textBox9Input.Text = "499";
            textBox10AInput.Text = "4";
            textBox10BInput.Text = "3";
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            textBox1ResultA.Text = "Fail";
            textBox2ResultA.Text = "Fail";
            textBox3ResultA.Text = "Fail";
            textBox4ResultA.Text = "Fail";
            textBox5ResultA.Text = "Fail";
            textBox6ResultA.Text = "Fail";
            textBox7ResultA.Text = "Fail";
            textBox8ResultA.Text = "Fail";
            textBox9ResultA.Text = "Fail";
            textBox10ResultA.Text = "Fail";

            textBox1ResultB.Text = "Success";
            textBox2ResultB.Text = "Success";
            textBox3ResultB.Text = "Success";
            textBox4ResultB.Text = "Success";
            textBox5ResultB.Text = "Success";
            textBox6ResultB.Text = "Success";
            textBox7ResultB.Text = "Success";
            textBox8ResultB.Text = "Success";
            textBox9ResultB.Text = "Success";
            textBox10ResultB.Text = "Success";

            if (textBox1Input.Text == "Frank")
                textBox1ResultA.Text = "Success";
            if (textBox1Input.Text != "Frank")
                textBox1ResultB.Text = "Fail";
            if (textBox2Input.Text == "")
                textBox2ResultA.Text = "Success";
            if (textBox2Input.Text != "")
                textBox2ResultB.Text = "Fail";
            decimal val3 = Convert.ToDecimal(textBox3Input.Text);
            if (val3 == 2.3m)
                textBox3ResultA.Text = "Success";
            if (val3 != 2.3m)
                textBox3ResultB.Text = "Fail";
            bool val4 = Convert.ToBoolean(textBox4Input.Text);
            if (val4 == false)
                textBox4ResultA.Text = "Success";
            if (val4 == true)
                textBox4ResultB.Text = "Fail";
            if (textBox5AInput.Text == textBox5BInput.Text)
                textBox5ResultA.Text = "Success";
            if (textBox5AInput.Text != textBox5BInput.Text)
                textBox5ResultB.Text = "Fail";

            if (textBox6Input.Text != "Jones")
                textBox6ResultA.Text = "Success";
            if (textBox6Input.Text == "Jones")
                textBox6ResultB.Text = "Fail";
            decimal val7 = Convert.ToDecimal(textBox7Input.Text);
            if (val7 > 0)
                textBox7ResultA.Text = "Success";
            if (val7 <= 0)
                textBox7ResultB.Text = "Fail";
            decimal val8A = Convert.ToDecimal(textBox8AInput.Text);
            decimal val8B = Convert.ToDecimal(textBox8BInput.Text);
            if (val8A < val8B)
                textBox8ResultA.Text = "Success";
            if (val8A >= val8B)
                textBox8ResultB.Text = "Fail";
            decimal val9 = Convert.ToDecimal(textBox9Input.Text);
            if (val9 >= 500m)
                textBox9ResultA.Text = "Success";
            if (val9 < 500m)
                textBox9ResultB.Text = "Fail";
            decimal val10A = Convert.ToDecimal(textBox10AInput.Text);
            decimal val10B = Convert.ToDecimal(textBox10BInput.Text);
            if (val10A <= val10B)
                textBox10ResultA.Text = "Success";
            if (val10A > val10B)
                textBox10ResultB.Text = "Fail";
        }
    }
}
