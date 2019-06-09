using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class UnsharedConcreteFlyweight : Flyweight
    {
        public override void Operation(int extrinsicState)
        {
            Console.WriteLine("UnsharedConcreteFlyweight：" + extrinsicState);
        }
    }
}
