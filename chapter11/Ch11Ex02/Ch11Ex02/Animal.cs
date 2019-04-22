using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace Ch11Ex02
{
    /// <summary>
    /// Class Animal is 
    /// </summary>
    public abstract class Animal
    {
        protected string name;

        public string Name
        {
            get { return name; }
            set { name = value; }

        }

        public Animal() => name = "The Animal with no name";
        public Animal(String newName) => name = newName;
        public void Feed() => WriteLine($"{name} has beed fed.");

    }
}
