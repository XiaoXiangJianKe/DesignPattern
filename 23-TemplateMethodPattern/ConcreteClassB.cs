using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    class ConcreteClassB : AbstactClass
    {
        protected override void Operation1()
        {
            Console.WriteLine("ConcreteClassB.Operation1");
        }

        protected override void Operation2()
        {
            Console.WriteLine("ConcreteClassB.Operation2");
        }
    }
}
