using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace _00_TypesAndVariables
{
    [TestClass]
    public class ValueTypes
    {
        [TestMethod]
        public void Booleans()
        {
            //Declaring a variable
            bool isDeclared;

            //Initializing a variable
            isDeclared = true;

            //Using camelCase for variables
            bool isDeclaredAndInitialized = true;

            isDeclaredAndInitialized = false;
        }
        

        [TestMethod]
        public void Characters()
        {
            // To define a character use single quotes.
            char character = 'a';
            char symbol = '?';
            char number = '7';
            char space = ' ';
            char spacialCharacter = '\n';
        }

        [TestMethod]
        public void WholeNumbers()
        {
            //int short byte long int16 int32 int64
            //2 ^ 8
            byte byteExample = 255;
            sbyte sByteExample = -128;

            //2^16
            short shortexample = 32767;
            Int16 anotherShortExample = -32768;

            //2^32
            int intMax = 2147483647;
            Int32 intMin = -2147483648;
            uint unSignedInt = 2147483648;

            //2^64
            long longExample = 9223372036854775807;
            Int64 longMin = -9223372036854775808;
        }

        [TestMethod]
        public void Decimals()
        {
            //decimal double float
            float floatExample = 1.92385712315f;
            double doubleExample = 1.923857512312578d;
            decimal decimalExample = 881.1239485998799768768687m;


            Console.WriteLine(9223372036854775807f);
            Console.WriteLine(9223372036854775807d);
            Console.WriteLine(9223372036854775807m);
        }


        //Enum
        enum PastryTypes { Eclair, Croissant, PetitFour, Cake, Cupcake }
        [TestMethod]
        public void Enums()
        {
            PastryTypes myPastry = PastryTypes.Croissant;
            PastryTypes anotherOne = PastryTypes.Cake;
        }

        [TestMethod]
        public void Structs()
        {
            Int32 age = 42;

            DateTime today = DateTime.Today;

            DateTime specificDate = new DateTime(2021, 9, 14);

            DateTime todayTwo = today;



            //var takes its type from the right side of assignment operator
            var variable = today;
            //variable = 'a';
        }
    }
}
