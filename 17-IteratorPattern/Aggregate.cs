using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 抽象聚合类
    /// </summary>
    abstract class Aggregate
    {
        public abstract Iterator CreateIterator();
    }
}
