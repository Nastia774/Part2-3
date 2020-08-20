using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._3
{
    class Program
    {
        static void Main(string[] args)
        {
            Plane plane = new Plane();
            Car car = new Car();
            Ship ship = new Ship();

            plane.Write();
            car.Write();
            ship.Write();

            Console.ReadKey();
        }
    }
}
