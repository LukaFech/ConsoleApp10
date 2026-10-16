using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Task3
    {
        public static int[] Sort(int[] arr, int up)
        {
            int[] arrsort = arr;
            if (up == 1)
            {
                while(true)
                {
                    for(int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1)
                        {
                            continue;
                        }
                        if (arrsort[i] > arrsort[i+1])
                        {
                            int temp = arrsort[i + 1];
                            arrsort[i + 1] = arrsort[i];
                            arrsort[i] = temp;
                        }
                    }
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1) 
                        {
                            continue;
                        }
                        else if (arrsort[i] < arrsort[i + 1])
                        {
                            count++;
                        }
                    }
                    if (count == arr.Length-1)
                    {
                        return arrsort;
                    }
                }
            }
            if (up == 2)
            {
                while (true)
                {
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1)
                        {
                            continue;
                        }
                        if (arrsort[i] < arrsort[i + 1])
                        {
                            int temp = arrsort[i + 1];
                            arrsort[i + 1] = arrsort[i];
                            arrsort[i] = temp;
                        }
                    }
                    int count = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        if (i == arr.Length - 1)
                        {
                            continue;
                        }
                        else if (arrsort[i] > arrsort[i + 1])
                        {
                            count++;
                        }
                    }
                    if (count == arr.Length - 1)
                    {
                        return arrsort;
                    }
                }
            }
            return arr;
        }
    }
}
