using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MementoPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Originator originator = new Originator();
            originator.State = "Idle";
            Console.WriteLine(originator.State);

            Caretaker caretaker = new Caretaker();
            caretaker.Memento = originator.CreateMemento();

            originator.State = "Run";
            Console.WriteLine(originator.State);

            originator.SetMemento(caretaker.Memento);
            Console.WriteLine("恢复状态：" + originator.State);
        }
    }
}
