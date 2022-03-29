using System;
using System.Collections.Generic;
using System.Text;

namespace Interfaces
{
    class MainPrintFile : IPrintable
    {
        public string Name;

        public MainPrintFile(string name)
        {
            Name = name;
        }

        public void Print()
        {
            Console.WriteLine($"{Name} is printed");
        }
    }
}
