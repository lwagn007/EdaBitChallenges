using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Method_Challenges_EdaBit
{
    public class EasyMethodsRepository
    {
        public bool ReturnTrue()
        {
            return true;
        }

        public int Sum(int a, int b)
        {
            int addition = a + b;
            return addition;
        }

        public bool LessThanOrEqualToZero(double a)
        {
            if (a <= 0d)
                return true;
            else
                return false;
        }

        public bool IsItChristmasEve(int year, int month, int day)
        {
            if (month == 12 && day == 24)
                return true;
            else
                return false;
        }

        public string EvenOrOdd(int num)
        {
            string evenOrOdd;
            if(num%2 == 0)
            {
                evenOrOdd = "even";
            }
            else
            {
                evenOrOdd = "odd";
            }
            return evenOrOdd;
        }

        public object GetLastItem(object[] arr)
        {
            object lastItem = arr.Last();
            return lastItem;
        }
    }
}
