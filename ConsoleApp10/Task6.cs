using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    internal class Task6
    {
        public string Name { get; set; }
        public string Nameofcreator { get; set; }
        public int Year { get; set; }
        public string Type { get; set; }
        public Task6(string name, int year)
        {
            Name = name;
            Year = year;
        }
        public Task6(string name)
        {
            Name = name;
        }
    }
}
