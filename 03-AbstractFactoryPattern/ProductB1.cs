﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactoryPattern
{
    class ProductB1 : ProductB
    {
        public override void Operation()
        {
            Console.WriteLine("ProductB1");
        }
    }
}