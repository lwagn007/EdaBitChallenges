using Method_Challenges_EdaBit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Challenges_Edabit_Tests
{
    public class MockConsole : IConsole
    {
        public Queue<string> UserInput;
        public string Output;

        public MockConsole() { }

        public MockConsole(IEnumerable<string> input)
        {
            UserInput = new Queue<string>(input);
            Output = string.Empty;
        }

        public void Clear()
        {
            Output += "Called Clear Method";
        }

        public ConsoleKeyInfo ReadKey()
        {
            return new ConsoleKeyInfo();
        }

        public string ReadLine()
        {
            if (UserInput.Count == 0)
                return "";
            return UserInput.Dequeue();
        }

        public void Write(string s)
        {
            Output += s;
        }

        public void WriteLine(string s)
        {
            Output += s + "\n";
        }

        public void WriteLine(object o)
        {
            Output += o.ToString() + "\n";
        }
    }
}
