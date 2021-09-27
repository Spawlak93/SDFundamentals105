using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public class Penny : ICurrency
    {
        public string Name
        {
            get
            {
                return "Penny";
            }
        }

        public decimal Value
        {
            get
            {
                return 0.01m;
            }
        }
    }

    public class Dime :ICurrency
    {
        public string Name { get { return "Dime"; } }
        public decimal Value { get { return 0.10m; } }
    }

    public class Dollar : ICurrency
    {
        public string Name { get { return "Dollar"; } }
        public decimal Value { get { return 1.00m; } }
    }

    public class ElectronicPayment : ICurrency
    {
        public ElectronicPayment(decimal value)
        {
            Value = value;
        }

        public string Name { get { return "Electronic Payment"; } }

        public decimal Value { get; }
    }

    public class Euro : ICurrency
    {
        public string Name { get { return "Euro"; } }

        public decimal Value { get { return 1.17m; } }
    }
}
