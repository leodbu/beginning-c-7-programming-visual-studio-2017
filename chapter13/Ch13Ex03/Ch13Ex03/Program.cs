using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;


namespace Ch13Ex03
{
    public class Program
    {

        public static void Main(string[] args)
        {
            Connection myConnection1 = new Connection();
            myConnection1.Name = "First Connection";

            Connection myConnection2 = new Connection();
            myConnection2.Name = "Second Connection";

            Display myDisplay = new Display();

            myConnection1.MessageArrived += myDisplay.DisplayMessage;
            myConnection2.MessageArrived += myDisplay.DisplayMessage;
            myConnection1.Connect();
            myConnection2.Connect();

            System.Threading.Thread.Sleep(200);
            ReadKey();
        }
    }
}
