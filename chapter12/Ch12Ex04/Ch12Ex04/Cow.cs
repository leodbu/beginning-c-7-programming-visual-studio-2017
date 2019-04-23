﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch12Ex04
{
    public class Cow : Animal
    {
        public Cow(string newName) : base(newName) { }

        public override void MakeANoise()
        {
            WriteLine($"{name} says 'moo!'");
        }

        public void Milk() => WriteLine($"{name} has been milked."); 
    }
}
