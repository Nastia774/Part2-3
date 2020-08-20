using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._2
{
    class Program
    {
        static void Input(int num)
        {
            Pupil pupil1 = new Pupil();
            Pupil pupil2 = new Pupil();
            switch (num)
            {
                case 2:
                    {
                        ClassRoom classRoom = new ClassRoom(pupil1, pupil2);
                        break;
                    }
                case 3:
                    {
                        Pupil pupil3 = new Pupil();
                        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3);
                        break;
                    }
                case 4:
                    {
                        Pupil pupil3 = new Pupil();
                        Pupil pupil4 = new Pupil();
                        ClassRoom classRoom = new ClassRoom(pupil1, pupil2, pupil3, pupil4);
                        break;
                    }
                default:
                    Console.WriteLine("Такого количества учеников нет.");
                    break;
            }

        }
        static void Main(string[] args)
        {
            Console.Write("Сколько учеников вы хотите ввести 2-4 :");
            int num = int.Parse(Console.ReadLine());

            Input(num);

            Console.ReadKey();
        }
    }
}
