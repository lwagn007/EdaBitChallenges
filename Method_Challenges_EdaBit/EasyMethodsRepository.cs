﻿using System;
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

        public int FindLargestNumber(int[] arr)
        {
            int value = arr.Max();
            return value;
        }

        public double FindSmallestNumber(double[] arr)
        {
            double value = arr.Min();
            return value;
        }

        public bool CheckEnding(string stringOne, string stringTwo)
        {
            bool endsWithString = stringOne.EndsWith(stringTwo);
            return endsWithString;
        }

        public string VerifySubStrings(string main, string head, string body, string tail)
        {
            string message;

            bool first = main.StartsWith(head);
            bool second = main.Contains(body);
            bool third = main.EndsWith(tail);

            if (first == true && second == true && third == true)
            {
                message = "My head, body, and tail.";
            }
            else
            {
                message = "Incomplete.";
            }
            return message;   
        }

        public int AddUp(int num)
        {
            int addedInt = 0;
            for (int i = 1; i <= num; i++)
            {
                addedInt += i;
            }
            return addedInt;
        }

        public double[] FindMinAndMax(double[] values)
        {
            double[] minMax = { values.Min(), values.Max() };
            return minMax;
        }
    }
}
