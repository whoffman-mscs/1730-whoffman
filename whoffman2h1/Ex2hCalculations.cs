using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;


namespace whoffman2h1
{
    public class Ex2hCalculations
    {
        public static string DateCalc06(string strYear, string strMonth, string strDay)
        {
            // #6
            string result = "Invalid input";
            DateTime date;
            try
            {
                int year = Int32.Parse(strYear);
                int month = Int32.Parse(strMonth);
                int day = Int32.Parse(strDay);
                date = new DateTime(year, month, day);
                result = date.ToShortDateString();
            }
            catch { }
            
            return result;
        }
        public static string DateCalc07(string strDate)
        {
            // #7

            string result = "Invalid input";
            DateTime date;
            try
            {
                date = DateTime.Parse(strDate);
                result = date.ToShortDateString();
            }
            catch { }
            return result;
        }
        public static string DateCalc08(string strDate)
        {
            // #8

            string result = "Invalid input";
            DateTime date; 
            DateTime.TryParse(strDate, out date);
            result = date.ToShortDateString();
            return result;
        }
        public static string DateCalc09(string dateA, string dateB)
        {
            // #7

            string result = "Invalid input";
            
            TimeSpan difference;
            try
            {
                difference = DateTime.Parse(dateA) - DateTime.Parse(dateB);

                result = difference.Days.ToString() + " days";
            }
            catch { }
            return result;
        }
        public static string DateCalc10(string dateA, string dateB)
        {
            // #7

            string result = "Invalid input";

            try
            {
                if (DateTime.Parse(dateA) <= DateTime.Parse(dateB))
                    result = "On time";
                else
                    result = (DateTime.Parse(dateA) - DateTime.Parse(dateB)).Days.ToString() + " days past due";
            }
            catch { }
            return result;
        }
        public static string StringCalc01(string input)
        {
            string result = "Invalid input";
            try
            {
                input = input.Trim();
                input = input.Remove(0, 1);
                input = input.Insert(0,"cr");
                return input;
            }
            catch { }
            return result;
        }
        public static string StringCalc02(string input)
        {
            string result = "Invalid input";
            try
            {
                input = input.Trim();
                input = input.Remove(1, 2);
                input = input.Insert(1, "rit");
                return input;
            }
            catch { }
                return result;
        }
        public static string StringCalc03(string input)
        {
            string result = "Invalid input";
            try
            {
                input = input.Trim();
                input = input.Substring(2, 4).ToUpper();
                return input;
            }
            catch { }
                return result;
        }
        public static string StringCalc04(string input)
        {
            input.Trim();
            input = input.PadLeft(10, '*');
            return input;
        }
        public static string StringCalc05(string input)
        {
            input = input.Replace("(", "");
            input = input.Replace(")", "");
            input = input.Replace(" ", "");
            input = input.Replace("-", "");
            return input;
            
        }
        public static string StringCalc06(string input)
        {
            input = input.Replace("(", "");
            input = input.Replace(")", "");
            input = input.Replace(" ", "");
            input = input.Replace("-", "");
            if (input.Length == 7)
                input = input.Insert(3, ".");
            if (input.Length == 10)
            {
                input = input.Insert(3, ".");
                input = input.Insert(7, ".");
            }
            return input;
        }
        public static string StringCalc07(string input)
        {
            input = input.ToLower();
            if (input.Contains("pioneer"))
                input = "Found";
            else
                input = "Not found";
            return input;
        }
        public static string StringCalc08(string input)
        {
            string result = "Invalid input";
            try
            {
                
                int firstComma = input.LastIndexOf(", ");
                
                input = input.Substring(firstComma + 2);
                return input;
            }
            catch { }
            return result;
        }
        public static string StringCalc09(string input)
        {
            int lastSpace = input.LastIndexOf(" ");
            input = input.Substring(lastSpace + 1);
            return input;
        }
        public static string StringCalc10(string input1, string input2, string input3)
        {
            StringBuilder sb = new StringBuilder(100);
            sb.Append(input1);
            sb.Append(input2);
            sb.Append(input3);
            return sb.ToString();
        }
    }
}