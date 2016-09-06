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
                sum = sum + number;
            }

            return sum;
        }
    }
}
