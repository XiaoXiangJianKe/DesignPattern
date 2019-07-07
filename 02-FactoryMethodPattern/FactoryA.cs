﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    class FactoryA : Factory
    {
        public override Product CreateProduct()
        {
            return new ProductA();
        }
    }
}
