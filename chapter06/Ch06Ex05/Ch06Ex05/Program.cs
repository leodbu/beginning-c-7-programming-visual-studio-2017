using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
using static System.Convert;

namespace Ch06Ex05
{
    class Program
    {
        delegate double ProcessDelegate(double param1, double param2);
        static double Multiply(double param1, double param2) => param1 * param2;
        static double Divide(double param1, double param2) => param1 / param2;

        static void Main(string[] args)
        {
            ProcessDelegate process;
            WriteLine("Enter 2 numbers separated with a coma: ");
            string numbers = ReadLine();
            int commaPos = numbers.IndexOf(",");
            double param1 = ToDouble(numbers.Substring(0, commaPos));
            double param2 = ToDouble(numbers.Substring(commaPos + 1, numbers.Length - commaPos - 1));

            WriteLine("Enter M to Multiply or D to divide :");
            string inputs = ReadLine();
            if (inputs == "M")
            {
                process = new ProcessDelegate(Multiply);
            } else
            {
                process = new ProcessDelegate(Divide);
            }

            WriteLine($"Result : {process(param1, param2)}");
            ReadKey();

        }



    }
}
