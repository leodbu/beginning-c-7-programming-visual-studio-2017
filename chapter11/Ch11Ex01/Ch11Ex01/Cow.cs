﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex01
{
    class Cow : Animal
    {
        public Cow(string newName) : base(newName) { }
        public void Milk() => WriteLine($"{name} has been milked."); 
    }
}
