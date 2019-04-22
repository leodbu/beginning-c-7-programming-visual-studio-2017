using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch11Ex02
{
    /// <summary>
    /// Animals class is a CollectionBase class specialliy for Animal
    /// 
    /// </summary>
    public class Animals : CollectionBase
    {
        public void Add(Animal newAnimal) => List.Add(newAnimal);

        public void Remove(Animal oldAnimal) => List.Remove(oldAnimal);

        public Animal this[int animalIndex]
        {
            get { return (Animal)List[animalIndex]; }
            set { List[animalIndex] = value; }
        }
    }
}
