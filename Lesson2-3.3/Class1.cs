using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._3
{
    class Vehicle
    {
        protected decimal _price;
        protected double _speed;
        protected int _age;
    }
    class Plane : Vehicle
    {
        private double height = 2000;
        private int passengers = 150;
        public Plane()
        {
            _price = 20000.5m;
            _speed = 246;
            _age = 5;
            passengers = 150;
            height = 2000;
        }
        public void Write()
        {
            Console.WriteLine($"Даный самолет стоит {_price}, может лететь со скоростью {_speed}, взраст {_age}, высота на которую может подняться {height}, вместимость {passengers} человек");
        }
    }
    class Car : Vehicle
    {
        public Car()
        {
            _price = 5000.32m;
            _speed = 180;
            _age = 10;
        }
        public void Write()
        {
            Console.WriteLine($"Даная машина стоит {_price}, может ехать со скоростью {_speed}, взраст {_age} ");
        }
    }
    class Ship : Vehicle
    {
        private int passengers;
        private string port;

        public Ship()
        {
            _price = 23000m;
            _speed = 68;
            _age = 3;
            passengers = 63;
            port = "North port";
        }
        public void Write()
        {
            Console.WriteLine($"Даный корабль стоит {_price}, может плыть со скоростью {_speed}, взраст {_age},  вместимость {passengers} человек, прибывает в порт {port}");
        }
    }
}
