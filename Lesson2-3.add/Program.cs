using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3.add
{
    class Program
    {
        static void Main(string[] args)
        {
            PrintRed printRed = new PrintRed();
            printRed.PrintR("LKJ");
            PrintBlue printBlue = new PrintBlue();
            printBlue.PrintB("LKJ");
            Printer printer = new Printer();
            printer.Print("LKJ");

            Console.ReadKey();
        }
    }
}
