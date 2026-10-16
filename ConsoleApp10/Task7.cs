using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Task7
    {
        int[,] _arr;
        public void SetMatrix(int[,] arr)
        {
            _arr = arr;
        }
        public void GetMatrix()
        {
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    Console.Write($"{_arr[i, j]} ");
                }
                Console.WriteLine(" ");
            }
        }
        public void GetMax()
        {
            int temp = _arr[0, 0];
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    if (temp < _arr[i, j])
                    {
                        temp = _arr[i, j];
                    }
                }
            }
            Console.WriteLine(temp);
        }
        public void GetMin()
        {
            int temp = _arr[0, 0];
            for (int i = 0; i < _arr.GetLength(0); i++)
            {
                for (int j = 0; j < _arr.GetLength(1); j++)
                {
                    if (temp > _arr[i, j])
                    {
                        temp = _arr[i, j];
                    }
                }
            }
            Console.WriteLine(temp);
        }
    }
}
