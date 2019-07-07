using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class ComponentA : Component
    {
        public override void Show()
        {
            Console.WriteLine("ComponentA");
        }
    }
}
