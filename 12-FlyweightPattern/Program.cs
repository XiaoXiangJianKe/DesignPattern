using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyweightPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            FlyweightFactory flyweightFactory = new FlyweightFactory();

            Flyweight fA = flyweightFactory.GetFlyweight("A");
            fA.Operation(10);

            Flyweight fB = flyweightFactory.GetFlyweight("A");
            fB.Operation(9);

            Flyweight fC = flyweightFactory.GetFlyweight("C");
            fC.Operation(8);

            UnsharedConcreteFlyweight uf = new UnsharedConcreteFlyweight();
            uf.Operation(7);

            Console.WriteLine("fA == fB：" + (fA == fB));
            Console.WriteLine("fA == fC：" + (fA == fC));
        }
    }
}
