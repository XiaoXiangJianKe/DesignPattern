using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factory1 = new Factory1();
            Factory factory2 = new Factory2();

            ProductA productA1 = factory1.CreateProductA();
            productA1.Operation();
            ProductB productB1 = factory1.CreateProductB();
            productB1.Operation();

            ProductA productA2 = factory2.CreateProductA();
            productA2.Operation();
            ProductB productB2 = factory2.CreateProductB();
            productB2.Operation();
        }
    }
}
