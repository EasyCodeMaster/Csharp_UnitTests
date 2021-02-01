using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject
{
    public class NumbersCalculator
    {
        public int Add(int a, int b)
        {
            return a + b;
        }

        public int Subtract(int a, int b)
        {
            return (b > a) ? 0 : a - b;
        }

        public int Multiplication(int a, int b)
        {
            return a * b;
        }

        public float Division(int a, int b)
        {
            return a/b;
        }


    }
}
