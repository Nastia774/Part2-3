using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._2
{
    class ClassRoom
    {


        ExcelentPupil _first = new ExcelentPupil();
        GoodPupil _second = new GoodPupil();
        BadPupil _therd = new BadPupil();

        public ClassRoom(Pupil first, Pupil second, Pupil therd, Pupil fourth)
        {
            Console.WriteLine("Первый ученик :");
            first = _first;
            _first.Output();
            Console.WriteLine("Второй ученик :");
            second = _second;
            _second.Output();
            Console.WriteLine("Третий ученик :");
            therd = _therd;
            _therd.Output();
            Console.WriteLine("Четвертый ученик :");
            fourth = _second;
            _second.Output();
        }
        public ClassRoom(Pupil first, Pupil second, Pupil therd)
        {
            Console.WriteLine("Первый ученик :");
            first = _first;
            _first.Output();
            Console.WriteLine("Второй ученик :");
            second = _second;
            _second.Output();
            Console.WriteLine("Третий ученик :");
            therd = _therd;
            _therd.Output();
        }
        public ClassRoom(Pupil first, Pupil second)
        {
            Console.WriteLine("Первый ученик :");
            first = _first;
            _first.Output();
            Console.WriteLine("Второй ученик :");
            second = _second;
            _second.Output();
        }
    }
    class Pupil
    {
        void Study() { }
        void Read() { }
        void Write() { }
        void Relax() { }
    }
    class ExcelentPupil : Pupil
    {
        void Study()
        { Console.WriteLine("Отлично учится "); }
        void Read()
        { Console.WriteLine("Отлично читает "); }
        void Write()
        { Console.WriteLine("Отлично пишет "); }
        void Relax()
        { Console.WriteLine("Мало отдыхает "); }
        public void Output()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
    class GoodPupil : Pupil
    {
        void Study()
        { Console.WriteLine("Хорошо учится "); }
        void Read()
        { Console.WriteLine("Нормально читает "); }
        void Write()
        { Console.WriteLine("Нормально пишет "); }
        void Relax()
        { Console.WriteLine("Хорошо отдыхает "); }
        public void Output()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
    class BadPupil : Pupil
    {
        void Study()
        { Console.WriteLine("Плохо учится "); }
        void Read()
        { Console.WriteLine("Не хорошо читает "); }
        void Write()
        { Console.WriteLine("Плохо пишет "); }
        void Relax()
        { Console.WriteLine("Много отдыхает "); }
        public void Output()
        {
            Study();
            Read();
            Write();
            Relax();
        }
    }
}
