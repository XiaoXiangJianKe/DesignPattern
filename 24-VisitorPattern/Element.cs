using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 抽象元素
    /// </summary>
    abstract class Element
    {
        public abstract void Accept(Visitor visitor);
    }
}
