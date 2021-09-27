using _07_StreamingContent_Console.Consoles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console
{
    class Program
    {
        static void Main(string[] args)
        {
            RealConsole realConsole = new RealConsole();
            ProgramUI ui = new ProgramUI(realConsole);
            ui.Run();
        }
    }
}
