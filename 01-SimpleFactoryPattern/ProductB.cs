using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class ProductB : Product
    {

        public override void Operation()
        {
            Console.WriteLine("ProductB");
        }
    }
}
