﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using static System.Console;



namespace Ch13Ex03
{

    //public delegate void MessageHandler(string messageText);

    public class Connection
    {
        //public event MessageHandler MessageArrived;
        public event EventHandler<MessageArrivedEventArgs> MessageArrived;

        private Timer pollTimer;
        private string name;
        public string Name {get; set;}

        public Connection()
        {
            pollTimer = new Timer(100);
            pollTimer.Elapsed += new ElapsedEventHandler(CheckForMessage);

        }


        public void Connect() => pollTimer.Start();
        public void Disconnect() => pollTimer.Stop();
        private static Random random = new Random();


        private void CheckForMessage(object source, ElapsedEventArgs e)
        {
            WriteLine("Checking for new messages.");
            if ((random.Next(9) == 0) && (MessageArrived != null)) {
                MessageArrived(this, new MessageArrivedEventArgs("Hello Mami !!"));
                //MessageArrived("Hello, Donna !");
            }
        }



    }
}
