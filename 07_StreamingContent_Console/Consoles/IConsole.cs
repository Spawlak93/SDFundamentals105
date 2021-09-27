using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console.Consoles
{
    public interface IConsole
    {
        void WriteLine(string s);
        void WriteLine(object o);

        void Write(string s);
        void Write(object o);

        void Clear();
        string ReadLine();
        ConsoleKeyInfo ReadKey();
    }
}
