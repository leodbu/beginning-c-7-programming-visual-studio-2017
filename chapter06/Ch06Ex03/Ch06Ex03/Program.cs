using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch06Ex03
{
    class Program
    {

        static int SumVals(params int[] vals)
        {
            int total = 0;

            foreach(int value in vals)
            {
                total += value;
            }

            return total;
        }


        static void Main(string[] args)
        {

            WriteLine($"Total sum of value : {SumVals(10,55,12,33,67,132)}");
        }
    }
}
