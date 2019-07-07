using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FactoryB : Factory
    {
        public override Product CreateProduct()
        {
            return new ProductB();
        }
    }
}
