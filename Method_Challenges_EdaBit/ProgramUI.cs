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
            string main = "Marlin, is the fish that the Old Man caught.";
            string head = "Marlin,";
            string body = "is the fish";
            string tail = "that the Old Man caught.";
            string truth = TenthChallenge(main, head, body, tail);
            _console.WriteLine(truth);
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

        public bool ThirdChallenge()
        {
            bool truth = _easyRepo.LessThanOrEqualToZero(10d);
            return truth;
        }

        public bool FourthChallenge()
        {
            int year = 2018;
            int month = 12;
            int day = 24;

            bool truth = _easyRepo.IsItChristmasEve(year, month, day);
            return truth;
        }

        public string FifthChallenge()
        {
            string evenOrOdd = _easyRepo.EvenOrOdd(2);
            return evenOrOdd;
        }

        public object SixthChallenge(object[] arr)
        {
            object lastItem = _easyRepo.GetLastItem(arr);
            return lastItem;
        }

        public int SeventhChallenge(int[] arr)
        {
            int max = _easyRepo.FindLargestNumber(arr);
            return max;
        }

        public double EighthChallenge(double[] arr)
        {
            double max = _easyRepo.FindSmallestNumber(arr);
            return max;
        }

        public bool NinthChallenge(string stringOne, string stringTwo)
        {
            bool truth = _easyRepo.CheckEnding(stringOne, stringTwo);
            return truth;
        }

        public string TenthChallenge(string main, string head, string body, string tail)
        {
            string message = _easyRepo.VerifySubStrings(main, head, body, tail);
            
            return message;
        }
    }
}
