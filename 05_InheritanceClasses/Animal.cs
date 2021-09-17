using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05_InheritanceClasses
{
    public enum DietType { Herbivore=1, Omnivore, Carnivore }
    public class Animal
    {
        public Animal() { }
        public Animal(bool isMammal)
        {
            IsMammal = isMammal;
            Console.WriteLine("This Made an Animal");
        }
        public int NumberOfLegs { get; set; }
        public bool IsMammal { get; set; }
        public bool HasFur { get; set; }
        public DietType TypeOfDiet { get; set; }

        public virtual void Move()
        {
            Console.WriteLine($"This {GetType().Name} moves.");
        }
    }
}
