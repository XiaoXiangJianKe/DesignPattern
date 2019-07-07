using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class ProductA : Product
    {
        public override void Operation()
        {
            Console.WriteLine("ProductA");
        }
    }
}
