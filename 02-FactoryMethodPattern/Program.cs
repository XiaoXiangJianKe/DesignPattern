using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Factory factoryA = new FactoryA();
            Product productA = factoryA.CreateProduct();
            productA.Operation();

            Factory factoryB = new FactoryB();
            Product productB = factoryB.CreateProduct();
            productB.Operation();
        }
    }
}
