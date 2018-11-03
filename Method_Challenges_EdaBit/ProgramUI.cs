using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Challenges_EdaBit
{
    class ProgramUI
    {
        private readonly IConsole _console;
        EasyMethodsRepository _easyRepo = new EasyMethodsRepository();
        HardMethodsRepository __hardRepo = new HardMethodsRepository();

        public ProgramUI(IConsole console)
        {
            _console = console;
        }

        public void Run()
        {
            _console.WriteLine("Welcome, I hope testing your method works out well for you!");
            int sum = SecondChallenge();
            Console.WriteLine(sum);
        }

        public bool FirstChallenge()
        {
            bool truth = _easyRepo.ReturnTrue();
            _console.WriteLine(truth);
            return truth;
        }

        public int SecondChallenge()
        {
            int a = 15;
            int b = 29;
            int sum = _easyRepo.Sum(a, b);
            return sum;
        }
    }
}
