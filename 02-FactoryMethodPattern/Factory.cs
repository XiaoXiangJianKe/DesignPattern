using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethodPattern
{
    /// <summary>
    /// 抽象工厂
    /// </summary>
    abstract class Factory
    {
        public abstract Product CreateProduct();
    }
}
