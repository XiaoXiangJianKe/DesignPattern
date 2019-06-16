using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 具体聚合类
    /// </summary>
    class ConcreteAggregate : Aggregate
    {
        private List<object> list = new List<object>();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        public int Count
        {
            get { return list.Count; }
        }

        public object this[int index]
        {
            get { return list[index]; }
            set { list.Insert(index, value); }
        }
    }
}
