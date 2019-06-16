using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteSubject subject = new ConcreteSubject();

            subject.Attach(new ConcreteObserver("A", subject));
            subject.Attach(new ConcreteObserver("B", subject));
            subject.Attach(new ConcreteObserver("C", subject));

            subject.SubjectState = "起立";
            subject.Notify();
        }
    }
}
