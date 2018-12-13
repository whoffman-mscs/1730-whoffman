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
            search = search.Trim();
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
            
        }
        public static double Calc5(double[] numbers)
        {
            int length = numbers.GetLength(0);
            double sum = 0.0;
            double average = 0.0;
            if (length > 0)
            {
                for (int i = 0; i < length; i++)
                {
                    sum += numbers[i];
                }

                average = sum / length;

                return average;
            }
            else
                return -1;
        }

        public static double[] Calc6(double[] numbers)
        {
            int length = numbers.GetLength(0);
            List<double> aboveAvgList = new List<double>();
            if (length > 0)
            {
                double avg = Calc5(numbers);
                double average = avg / length;
                double aboveAverage = 0;
                foreach(int total in aboveAvgList)
                {
                    if (avg > average)
                        aboveAverage++;
                        
                }
            }
            return aboveAvgList.ToArray();
        }
    }
}
