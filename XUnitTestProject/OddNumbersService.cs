using System;
using System.Collections.Generic;
using System.Text;

namespace XUnitTestProject
{
    public class OddNumbersService
    {
        public bool IsOdd(int a)
        {
            return a % 2 != 0;
        }

        public bool IsEven(int a)
        {
            return a % 2 == 0;
        }
    }
}
