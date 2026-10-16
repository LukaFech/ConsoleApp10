using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Task4
    {

        public string Name { get; set;}
        public string Country { get; set; }
        public int Population { get; set; }
        public int Code { get; set; }
        string[] district = new string[0];
        public void add_district(string dname)
        {
            string[] buff = new string[district.Length+1];
            for (int i = 0; i < district.Length; i++)
            {
                buff[i] = district[i];
            }
            buff[district.Length] = dname;
            district = new string[buff.Length];
            for (int i = 0; i < district.Length; i++)
            {
                district[i] = buff[i];
            }

        }
        public void get_district()
        {
            for (int i = 0; i < district.Length; i++)
            {
                Console.WriteLine(district[i]);
            }
        }
    }
}
