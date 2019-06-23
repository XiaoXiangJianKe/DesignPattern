using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            AbstactClass classA = new ConcreteClassA();
            classA.TemplateMethod();

            AbstactClass classB = new ConcreteClassB();
            classB.TemplateMethod();
        }
    }
}
