using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch06Ex02
{
    

    class Program
    {
        static int MaxValue(int[] intArray)
        {
            int maxValue = 0;

            foreach (int value in intArray)
            {
                maxValue = (value > maxValue ? value : maxValue);
            }

            return maxValue;
        }
        static void Main(string[] args)
        {
            int[] intArray = new int[5] {5, 3, 12, 22, 8 };

            Console.WriteLine(MaxValue(intArray));

        }
    }
}
