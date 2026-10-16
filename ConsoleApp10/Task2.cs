using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Text;

namespace ConsoleApp10
{
    internal class Task2
    {
        public static bool GetF(int num)
        {
            int num1 = 0;
            int num2 = 1;
            int res = 0;
            while(true)
            {
                if (res == num)
                {
                    return true;
                }
                else if (res > num)
                {
                    return false;
                }
                res = num1 + num2;
                num1 = num2;
                num2 = res;
            }
            
        }
    }
}
