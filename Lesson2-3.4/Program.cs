using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите ключ доступа к про версии : ");
            int key = int.Parse(Console.ReadLine());
            if (key == 123)
            {
                Console.Write("Есть ли у вас ключь к експерт версии? у-да, n-нет : ");
                string answer = Console.ReadLine();
                if (answer == "y")
                {
                    Console.Write("Введите ключь для експерт версии : ");
                    int keyExpert = int.Parse(Console.ReadLine());
                    if (keyExpert == 321)
                    {
                        ExpertDocumentWorker expertWorker = new ExpertDocumentWorker();
                        expertWorker.OpenDocument();
                        expertWorker.EditDocument();
                        expertWorker.SaveDocument();
                    }
                }
                else
                {
                    ProDocumentWorker proWorker = new ProDocumentWorker();
                    proWorker.OpenDocument();
                    proWorker.EditDocument();
                    proWorker.SaveDocument();
                }
            }
            else
            {
                DocumentWorker worker = new DocumentWorker();
                worker.OpenDocument();
                worker.EditDocument();
                worker.SaveDocument();
            }
            Console.ReadKey();
        }
    }
}
