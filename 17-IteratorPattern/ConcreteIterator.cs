using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPattern
{
    /// <summary>
    /// 具体迭代器类
    /// </summary>
    class ConcreteIterator : Iterator
    {
        private ConcreteAggregate aggregate;
        private int currentIndex = 0;

        public ConcreteIterator(ConcreteAggregate aggregate)
        {
            this.aggregate = aggregate;
        }

        public override object First()
        {
            return aggregate[0];
        }

        public override object Next()
        {
            if(currentIndex++ < aggregate.Count -1)
            {
                return aggregate[currentIndex];
            }
            return null;
        }

        public override bool IsDone()
        {
            return currentIndex >= aggregate.Count;
        }

        public override object CurrentItem()
        {
            return aggregate[currentIndex];
        }
    }
}
