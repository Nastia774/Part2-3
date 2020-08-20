using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson2_3._4
{
    class DocumentWorker
    {
        public void OpenDocument()
        { Console.WriteLine("Документ открыт"); }
        public void EditDocument()
        { Console.WriteLine("Редактирование документа доступно в версии Про"); }
        public void SaveDocument()
        { Console.WriteLine("Сохранение документа доступно в версии Про"); }
    }
    class ProDocumentWorker : DocumentWorker
    {
        public void EditDocument()
        { Console.WriteLine("Документ отредактирован"); }
        public void SaveDocument()
        { Console.WriteLine("Документ сохранен в старом формате, сохранение в остальных форматах доступно в версии Эксперт"); }
    }
    class ExpertDocumentWorker : ProDocumentWorker
    {
        public void SaveDocument()
        { Console.WriteLine("Документ сохранен в новом формате"); }
    }
}
