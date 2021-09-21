using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculatorChallenge
{
    public class Calculator
    {
        //ADD
        public int Sum(int numOne, int numTwo)
        {
            return numOne + numTwo;
        }

        public double Sum(double numOne, double numTwo)
        {
            return numOne + numTwo;
        }
        //SUBTRACT
        public int Difference(int numOne, int numTwo)
        {
            return numOne - numTwo;
        }

        //**BONUS**

        //AS MANY NUMBERS AS USER PROVIDES
        public double Difference(params double[] args)
        {
            double runningTotal = args[0] + args[0];
            foreach (double arg in args)
            {
                runningTotal -= arg;
            }
            return runningTotal;
        }
    }
}
