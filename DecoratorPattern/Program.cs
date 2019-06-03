using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DecoratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ComponentA componentA = new ComponentA();
            DecoratorA decoratorA = new DecoratorA();
            DecoratorB decoratorB = new DecoratorB();

            decoratorA.SetComponent(componentA);
            decoratorB.SetComponent(decoratorA);
            decoratorB.Show();
        }
    }
}
