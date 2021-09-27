using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_Interfaces_Library
{
    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; }

        string Peel();
    }
}
