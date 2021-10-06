using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes_Setters
{
    //UserName must contain between 7 and 20 characters
    //Users must be at least 16
    class Quacker
    {
        //Backing field
        private string _userName;

        public string UserName
        {
            //Get method
            get => _userName;
            //Set Method
            set
            {
                if (value.Length >= 7 && value.Length <= 20)
                    //This is a single line body
                    _userName = value;
                else
                    throw new FormatException("UserName must be between 7 and 20 characters.");


            }
        }

        private int _age;
        public int Age
        {
            get
            {
                return _age;
            }

            set
            {
                if (value < 16)
                    throw new ArgumentException("Age must be at least 16");
                else
                    _age = value;
            }
        }
    }
}
