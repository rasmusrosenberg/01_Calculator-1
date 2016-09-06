using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Calculator
{
    class Calculator
    {
        public static int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }

        public static int Subtract(int arg1, int arg2)
        {
            return arg1 - arg2;
        }

        public static int Sum(int[] numbers)
        {
            //  Solvable with LINQ
            //return numbers.Sum();

            int sum = 0;

            foreach (int number in numbers)
            {
                sum += number;
            }

            return sum;
        }

        public static int Multiply(int[] numbers)
        {
            int sum = 1;

            foreach (int number in numbers)
            {
                sum *= number;
            }

            return sum;
        }

        public static double Power(int arg1, int arg2)
        {
            //  Solution using Math namespace
            //return Math.Pow(arg1, arg2);

            int sum = 1;

            for (int i = 1; i <= arg2; i++)
            {
                sum *= arg1;
            }

            return sum;
        }

        public static int Factorial(int arg)
        {
            if (arg <= 0)
                return 1;

            int sum = 1;
            for (int i = 0; i < arg; i++)
            {
                sum *= arg - i;
            }
            
            return sum;
        }
    }
}
