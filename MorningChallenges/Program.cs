using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MorningChallenges
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                try
                {
                    int.Parse(Console.ReadLine());
                }
                catch
                {
                    Console.WriteLine("Wrong");

                }
            }
            
        }
    }
}
