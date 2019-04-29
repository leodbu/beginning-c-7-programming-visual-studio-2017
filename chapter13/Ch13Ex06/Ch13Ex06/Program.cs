using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.CSharp.RuntimeBinder;
using static System.Console;

namespace Ch13Ex06
{

    class MyClass1
    {
        public int Add(int var1, int var2) => var1 + var2;
    }
    class MyClass2 { }


    public class Program
    {

        static int callCount = 0;
        static dynamic GetValue()
        {
            if (callCount++ == 0)
            {
                return new MyClass1();
            }

            return new MyClass2();
        }

        static void Main(string[] args)
        {
            try
            {
                dynamic firstResult = GetValue();
                dynamic secondResult = GetValue();
                WriteLine($"first result is: {firstResult.ToString()}");
                WriteLine($"second result is: {secondResult.ToString()}");
                WriteLine($"first result call: {firstResult.Add(2,3)}");
                WriteLine($"second result call: {secondResult.Add(2,3)}");
    
            } catch (RuntimeBinderException e)
            {
                WriteLine(e.Message);
            }

            ReadKey();

        }
    }
}
