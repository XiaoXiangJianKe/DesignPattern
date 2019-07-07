using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPattern
{
    class SimpleFactory
    {
        public Product CreateProduct(string name)
        {
            switch(name)
            {
                case "ProductA":
                    return new ProductA();
                case "ProductB":
                    return new ProductB();
                default:
                    return null;
            }
        }
    }
}
