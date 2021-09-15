using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Classes
{
    public class Calculator
    {
        //Add
        //1 Access Modifier
        //2 return type
        //3 Method Name
        //4 Paramater
        //5 Method Body(code method will run
        //6 return keyword(what method sends back)

        //1    //2  //3       //4
        public int Add(int numOne, int numTwo)
        {
            //5
            int sum = numOne + numTwo;
            //6
            return sum;

            return numOne + numTwo;
        }

        public double Add(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }

        //Subtract

        //Multiply

        //Divide

        //Remainder

        //Calculate age
        public int CalculateAge(DateTime birthdate)
        {
            TimeSpan span = DateTime.Now - birthdate;
            double totalAgeDouble = span.Days / 365.25;
            int years = Convert.ToInt32(Math.Floor(totalAgeDouble));
            return years;
        }
    }
}
