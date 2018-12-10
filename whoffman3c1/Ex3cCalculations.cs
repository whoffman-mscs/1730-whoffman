using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace whoffman3c1
{
    public class Ex3cCalculations
    {
        public static string Calc0(int index)
        {
            string[] days = { "Sunday", "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday" };
            if (index >= 1 && index < days.Length + 1)
                return days[index - 1];
            else
                return "Invalid index";
        }

        public static string Calc1(string search)
        {
            search.Trim();
            search = search.ToUpper();
            string[] days = { "SUNDAY", "MONDAY", "TUESDAY", "WEDNESDAY", "THURSDAY", "FRIDAY", "SATURDAY" };
            string[] hours = { "Closed", "10am - 6pm", "10am - 6pm", "10am - 6pm", "10am - 9pm", "10am - 6pm", "8am - 4pm" };
            int index = Array.IndexOf(days, search);
            if (index >= 0 && index <= days.Length)
                return hours[index];
            else
                return "Invalid input";
        }

        public static int Calc2(int[] numbers)
        {
            int sum = 0;
            foreach (int total in numbers)
                sum += total;
            return sum;
        }
        public static double Calc3(double[] numbers, int number)
        {
            double sum = 0.0;
            int length = numbers.GetLength(0);
            
                for (int i = 0; i < number; i++)
                    sum += numbers[i];
            return sum;
            else
                return 0.0;
            
        }
        public static double Calc5(double[] numbers)
        {
            return 0.0;
        }

        public static double[] Calc6(double[] numbers)
        {
            return new double[10];
        }
    }
}
