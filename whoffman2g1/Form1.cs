﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace whoffman2g1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {
            // 1a: switch with no default
            resultSwitch01TextBox.Text = Ex2gCalculations.Switch01(input1ATextBox.Text);

            // 1b: separate if statements
            resultIf01TextBox.Text = Ex2gCalculations.If01(input1ATextBox.Text);

            // 1c: if elseif
            resultElseIf01TextBox.Text = Ex2gCalculations.ElseIf01(input1ATextBox.Text);

            // 1d: nested if-else
            resultNestedIfElse01TextBox.Text = Ex2gCalculations.NestedIfElse01(input1ATextBox.Text);

            // 1e: switch with default
            resultSwitchDefault01TextBox.Text = Ex2gCalculations.SwitchDefault01(input1ATextBox.Text);

            // 6: if with default
            resultIfDefault01TextBox.Text = Ex2gCalculations.IfDefault01(input1ATextBox.Text);

            // 7: if-else with default
            resultElseIfDefault01TextBox.Text = Ex2gCalculations.ElseIfDefault01(input1ATextBox.Text);

            // 8: nested if default
            resultNestedIfDefault01TextBox.Text = Ex2gCalculations.NestedIfElseDefault01(input1ATextBox.Text);

            // 2a:
            resultSwitch02TextBox.Text = Ex2gCalculations.Switch02(input2ATextBox.Text);

            // 2b:
            resultIf02TextBox.Text = Ex2gCalculations.If02(input2ATextBox.Text);
            
            // 2c:
            resultElseIf02TextBox.Text = Ex2gCalculations.ElseIf02(input2ATextBox.Text);

            // 2d:
            resultNestedIf02TextBox.Text = Ex2gCalculations.NestedIfElse02(input2ATextBox.Text);
        }
    }
}
