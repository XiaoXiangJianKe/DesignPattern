using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteAggregate aggregate = new ConcreteAggregate();
            aggregate[0] = "A";
            aggregate[1] = "B";
            aggregate[2] = "C";
            aggregate[3] = "D";
            aggregate[4] = "E";

            Iterator iterator = aggregate.CreateIterator();
            object item = iterator.First();
            while (!iterator.IsDone())
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }
        }
    }
}
