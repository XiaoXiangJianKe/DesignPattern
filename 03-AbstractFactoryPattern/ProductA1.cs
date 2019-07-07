using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ProductA1 : ProductA
    {
        public override void Operation()
        {
            Console.WriteLine("ProductA1");
        }
    }
}
