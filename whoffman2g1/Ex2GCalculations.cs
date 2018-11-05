﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whoffman2g1
{
    public class Ex2gCalculations
    {
        public static string Switch01(string customerType)
        {
            // 1a: switch with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = 0.1m;
                    break;
                case "C":
                    discountPercent = 0.2m;
                    break;
            }

            return discountPercent.ToString("0.0");

            
        }

        public static string If01(string customerType)
        {
            // 1b: separate "if" statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.1m;
            if (customerType == "C")
                discountPercent = 0.2m;
            return discountPercent.ToString("0.0");

        }

        public static string ElseIf01(string customerType)
        {
            // 1c: ElseIf statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.1m;
            else if (customerType == "C")
                discountPercent = 0.2m;
            return discountPercent.ToString("0.0");

        }

        public static string NestedIfElse01(string customerType)
        {
            // 1d: Nested if statements
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = 0.2m;
                }
            }
            return discountPercent.ToString("0.0");

        }
        public static string SwitchDefault01(string customerType)
        {
            // 1e: switch with default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                    discountPercent = 0.1m;
                    break;
                case "C":
                    discountPercent = 0.2m;
                    break;
                default:
                    discountPercent = 0.0m;
                    break;
            }

            return discountPercent.ToString("0.0");


        }
        public static string IfDefault01(string customerType)
        {
            // 6: separate "if" statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.1m;
            if (customerType == "C")
                discountPercent = 0.2m;
            if (customerType != "R" && customerType != "C")
                discountPercent = 0.0m;
            return discountPercent.ToString("0.0");

        }
        public static string ElseIfDefault01(string customerType)
        {

            // 7: ElseIf default
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.1m;
            else if (customerType == "C")
                discountPercent = 0.2m;
            else
                discountPercent = 0.0m;
            return discountPercent.ToString("0.0");
        }

        public static string NestedIfElseDefault01(string customerType)
        {
            // 1d: Nested if statements
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = 0.1m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = 0.2m;
                }
                else
                {
                    discountPercent = 0.0m;
                }

            }
            return discountPercent.ToString("0.0");

        }
        public static string Switch02(string customerType)
        {
            // 2a) 'Switch' with no default
            decimal discountPercent = -1m;

            switch (customerType)
            {
                case "R":
                
                case "C":
                    discountPercent = 0.2m;
                    break;
                case "T":
                    discountPercent = 0.4m;
                    break;
            }

            return discountPercent.ToString("0.0");
            
        }
        public static string If02(string customerType)
        {
            // 2b) Separate 'if' statements
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.2m;
            if (customerType == "C")
                discountPercent = 0.2m;
            if (customerType == "T")
                discountPercent = 0.4m;
            return discountPercent.ToString("0.0");
            
        }
        public static string ElseIf02(string customerType)
        {
            // 2c) if elseif
            decimal discountPercent = -1m;

            if (customerType == "R")
                discountPercent = 0.2m;
            else if (customerType == "C")
                discountPercent = 0.2m;
            else if (customerType == "T")
                discountPercent = 0.4m;
            return discountPercent.ToString("0.0");
        }
        public static string NestedIfElse02(string customerType)
        {
            // 2d) Nested if-else
            decimal discountPercent = -1m;

            if (customerType == "R")
            {
                discountPercent = 0.2m;
            }
            else
            {
                if (customerType == "C")
                {
                    discountPercent = 0.2m;
                }
                else
                {
                    if (customerType == "T")
                    {
                        discountPercent = 0.4m;
                    }
                }
            }
            return discountPercent.ToString("0.0");
        }
    }
}
