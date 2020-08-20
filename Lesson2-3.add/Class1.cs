using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3.add
{
    class Printer
    {
        public void Print(string value)
        {
            Console.WriteLine(value);
        }
    }
    class PrintRed : Printer
    {
        public void PrintR(string value)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Print(value);
            Console.ResetColor();
        }
    }
    class PrintBlue : Printer
    {
        public void PrintB(string value)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Print(value);
            Console.ResetColor();
        }
    }
}
