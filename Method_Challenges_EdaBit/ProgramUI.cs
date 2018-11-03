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
            FirstChallenge();
        }

        public bool FirstChallenge()
        {
            bool truth = _easyRepo.ReturnTrue();
            _console.WriteLine(truth);
            return truth;
        }
    }
}
