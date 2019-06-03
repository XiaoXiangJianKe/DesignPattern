using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class DecoratorB : Decorator
    {
        public override void Show()
        {
            base.Show();
            Console.WriteLine("DecoratorB");
        }
    }
}
