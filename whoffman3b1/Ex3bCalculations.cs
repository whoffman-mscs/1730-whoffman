using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whoffman3b1
{
    public class Ex3bCalculations
    {
        public static decimal GetDiscountPercent(decimal subtotal)
        {
            decimal discountPercent = 0m;
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent;
        }

        public static void GetDiscountPercent(decimal subtotal, out decimal discountPercent)
        {
            
            if (subtotal >= 500m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            
        }

        public static decimal CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months)
        {
            decimal futureValue = 0.0m;
            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            return futureValue;
        }
        public static double FahrenheitToCelsius(double fahrenheit)
        {
            double result = 0.0d;
            result = (fahrenheit - 32) * 5 / 9;
            return result;
        }

        public static void CelsiusToFahrenheit(double celsius, out double result)
        {

            result = celsius * 9 / 5 + 32;
            
        }

        public static decimal GrossPay(decimal hours, decimal rate)
        {
            decimal result = 0.0m;
            if (hours <= 40)
                result = hours * rate;
            else
                result = (rate * 40) + (hours - 40) * (rate * 1.5m);
            return result;
        }

        public static decimal TotalHours(string strNumbers)
        {
            decimal total = 0.0m;
            int startIndex = 0;
            while (startIndex < strNumbers.LastIndexOf(' '))
            {
                int endIndex = strNumbers.IndexOf(' ', startIndex);
                string strNumber = strNumbers.Substring(startIndex, endIndex - startIndex);
                Decimal number = Decimal.Parse(strNumber);
                total += number;
                startIndex = endIndex + 1;
            }
            return total;
        }

        

        public static void CalculateFutureValue(decimal monthlyInvestment, decimal monthlyInterestRate, int months, ref decimal futureValue)
        {
            
            for (int i = 1; i <= months; i++)
            {
                futureValue = (futureValue + monthlyInvestment) * (1 + monthlyInterestRate);
            }
            
        }

        public static decimal GrossPay(string strNumbers, decimal rate)
        {
            decimal totalHours = TotalHours(strNumbers);
            return GrossPay(totalHours, rate);
        }
    }
}
