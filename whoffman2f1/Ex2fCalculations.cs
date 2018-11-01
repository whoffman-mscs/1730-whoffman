using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whoffman2f1
{
    public class Ex2fCalculations
    {
        public static string Calc01(string input)
        {

            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            // #1: if

            subtotal = Decimal.Parse(input);

            if (subtotal >= 100m)
                discountPercent = 0.2m;
            return discountPercent.ToString("n2");
        }

        public static string Calc02(string input)
        {
            // #2: if {block}

            decimal subtotal = 0m;
            decimal discountPercent = 0m;

            subtotal = Decimal.Parse(input);
            string status = "Standard rate: ";

            if (subtotal >= 100)
            {
                discountPercent = 0.20m;
                status = "Bulk rate: " + (discountPercent).ToString("n2");
            }

            return status;
        }

        public static string Calc03(string input)
        {
            // #3: if else
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc04(string input)
        {
            // #4 if else if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 100m && subtotal < 200m)
                discountPercent = 0.2m;
            else if (subtotal >= 200m && subtotal < 300m)
                discountPercent = 0.3m;
            else if (subtotal >= 300)
                discountPercent = 0.4m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc05(string input)
        {
            // #5 Better range test
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(input);
            discountPercent = 0m;
            if (subtotal >= 300m)
                discountPercent = 0.4m;
            else if (subtotal >= 200m)
                discountPercent = 0.3m;
            else if (subtotal >= 100m)
                discountPercent = 0.2m;
            else
                discountPercent = 0.1m;
            return discountPercent.ToString("n2");
        }

        public static string Calc06(string inputA, string inputB)
        {
            // #6 Nested if
            decimal subtotal = 0m;
            decimal discountPercent = 0m;
            subtotal = Decimal.Parse(inputA);
            string customerType = inputB;
            discountPercent = 0m;
            if (customerType == "R")
            {
                if (subtotal >= 100m)
                    discountPercent = 0.2m;
                else
                    discountPercent = 0.1m;

            }
            else         // customerType isn't "R"
                discountPercent = 0.4m;
            return discountPercent.ToString("n2");
        }

        public static string Calc07(string input)
        {
            // #7 Validate input: non-empty string
            if (input != "")
            {
                input = (Convert.ToDecimal(input) * 200m).ToString("n2");
                return input;
            }
            return "Invalid input";
        }

        public static string Calc08(string price, string quantity)
        {
            // #8 Validate input, calculate quantity * price, shipping



            if (price != "" && quantity != "")
            {
                if (Decimal.Parse(price) * Decimal.Parse(quantity) >= 50m)
                    return (Decimal.Parse(price) * Decimal.Parse(quantity)).ToString("n2");
                else
                    return (Decimal.Parse(price) * Decimal.Parse(quantity) + 5.00m).ToString("n2");
            }
            return "Invalid input";
            
        }
        public static string Calc09(string inputA, string inputB)
        {
            // #9 Validate input, calculate difference * rate

            if (inputA != "" && inputB != "" && Decimal.Parse(inputA) <= Decimal.Parse(inputB))
            {
                return ((Decimal.Parse(inputB) - Decimal.Parse(inputA)) * 0.10m).ToString("n2");
            }
            return "Invalid input";

        }
        


        public static string Calc10(string inputA, string inputB)
        {
            // #10 Validate input, divide large num by small
            //     Both numbers must be > 0
            if (inputA != "" && inputB != "")
            {
               if (Double.Parse(inputA) > 0 && Double.Parse(inputB) > 0)
                    {
                    if (Double.Parse(inputA) >= Double.Parse(inputB))
                        return (Double.Parse(inputA) / Double.Parse(inputB)).ToString("n2");
                    else
                        return (Double.Parse(inputB) / Double.Parse(inputA)).ToString("n2");
                }
                }
                return "Invalid input";
        }
    }
}

     

        
    

