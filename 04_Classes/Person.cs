using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    class Person
    {

        public Person() { }

        public Person(string firstName, string lastName, DateTime dateOfBirth)
        {
            FirstName = firstName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        public string HairColor { get; set; }

        public int Age { get; set; }

        public double Height { get; set; }

        public double Weight { get; set; }

        public DateTime DateOfBirth { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string FullName
        {
            get
            {
                string fullName = FirstName + " " + LastName;
                return fullName;
            }
        }

        public Vehicle Transport { get; set; }

        //Methods

        //Jump
        public void Jump()
        {
            Console.WriteLine($"{FirstName} jumps in the air");

        }

        //Run

        //Walk

        //Eat
        public void Eat(string food)
        {
            Console.WriteLine($"{FirstName} eats {food}");
        }
    }
}
