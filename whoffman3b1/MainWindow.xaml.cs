using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace whoffman3b1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalcButton_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox0a.Text);
                decimal discountPercent = Ex3bCalculations.GetDiscountPercent(subtotal);
                resultTextBox0.Text = discountPercent.ToString("f3");
            }
            catch {
                resultTextBox0.Text = "";
                MessageBox.Show("Invalid input: " + inputTextBox0a.Text);
            }

            try
            {
                decimal subtotal = Decimal.Parse(inputTextBox1a.Text);
                decimal discountPercent;
                Ex3bCalculations.GetDiscountPercent(subtotal, out discountPercent);
                resultTextBox1.Text = discountPercent.ToString("f3");
            }
            catch
            {
                resultTextBox1.Text = "";
                MessageBox.Show("Invalid input: " + inputTextBox1a.Text);
            }

            try
            {
                int months = Int32.Parse(inputTextBox2a.Text);
                decimal monthlyInvestment = Decimal.Parse(inputTextBox2b.Text);
                decimal monthlyInterestRate = Decimal.Parse(inputTextBox2c.Text);

                decimal futureValue = Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months);
                resultTextBox2.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox2.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + inputTextBox2a.Text + "\n"
                    + inputTextBox2b.Text + "\n"
                    + inputTextBox2c.Text + "\n");
            }

            try
            {
                int months = Int32.Parse(inputTextBox3a.Text);
                decimal monthlyInvestment = Decimal.Parse(inputTextBox3b.Text);
                decimal monthlyInterestRate = Decimal.Parse(inputTextBox3c.Text);
                decimal futureValue = 0m;
                Ex3bCalculations.CalculateFutureValue(monthlyInvestment, monthlyInterestRate, months, ref futureValue);
                resultTextBox3.Text = futureValue.ToString("c2");
            }
            catch
            {
                resultTextBox3.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + inputTextBox3a.Text + "\n"
                    + inputTextBox3b.Text + "\n"
                    + inputTextBox3c.Text + "\n");
            }

            try
            {
                double fahrenheit = Double.Parse(inputTextBox4a.Text);
                double celsius = Ex3bCalculations.FahrenheitToCelsius(fahrenheit);
                resultTextBox4.Text = celsius.ToString("f1");
            }
            catch
            {
                resultTextBox4.Text = "";
                MessageBox.Show("Invalid input: " + inputTextBox4a.Text);
            }

            try
            {
                double celsius = Double.Parse(inputTextBox5a.Text);
                double fahrenheit;
                Ex3bCalculations.CelsiusToFahrenheit(celsius, out fahrenheit);
                resultTextBox5.Text = fahrenheit.ToString("f1");
            }
            catch
            {
                resultTextBox5.Text = "";
                MessageBox.Show("Invalid input: " + inputTextBox5a.Text);
            }

            decimal hours = Decimal.Parse(inputTextBox6a.Text);
            decimal rate = Decimal.Parse(inputTextBox6b.Text);
            decimal grossPay = Ex3bCalculations.GrossPay(hours, rate);
            resultTextBox6.Text = grossPay.ToString();

            try
            {
                resultTextBox7.Text = Ex3bCalculations.TotalHours(inputTextBox7a.Text).ToString("n2");
            }
            catch
            {
                resultTextBox7.Text = "";
                MessageBox.Show("Invalid input: " + inputTextBox7a.Text);
            }

            try
            {
                
                resultTextBox8.Text = Ex3bCalculations.GrossPay(inputTextBox8a.Text, rate).ToString("n2");
            }
            catch
            {
                resultTextBox8.Text = "";
                MessageBox.Show("Invalid input:\n"
                    + inputTextBox8a.Text + "\n"
                    + inputTextBox8b.Text);
            }
        }
    }
}
