using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Task1
    {
        public static int GetAB(int a, int b)
        {
            int res = 1;
            if (a > b)
            {
                int temp = a;
                a = b;
                b = a;
            }
            for (int i = a; i <= b; i++)
            {
                res *= i;
            }
            return res;
        }
    }
}
