using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public interface ICurrency
    {
        string Name { get; }

        decimal Value { get; }
    }
}
