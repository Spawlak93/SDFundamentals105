using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Console.Consoles
{
    public class MockConsole : IConsole
    {
        //Giving Input
        public Queue<string> UserInput;

        //Holding onto Output
        public string Output;


        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);

            Output = "";
        }

        public void Clear()
        {
            Output += "Called Clear Method\n";
        }

        public ConsoleKeyInfo ReadKey()
        {
            Output += "Called ReadKey method\n";
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            return UserInput.Dequeue();
        }

        public void Write(string s)
        {
            Output += s;
        }

        public void Write(object o)
        {
            Output += o;
        }

        public void WriteLine(string s)
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o + "\n";
        }
    }
}
