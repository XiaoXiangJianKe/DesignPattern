using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SimpleFactory simpleFactory = new SimpleFactory();

            Product productA = simpleFactory.CreateProduct("ProductA");
            productA.Operation();

            Product productB = simpleFactory.CreateProduct("ProductB");
            productB.Operation();
        }
    }
}
