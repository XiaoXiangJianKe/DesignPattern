using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    /// <summary>
    /// 抽象访问者
    /// </summary>
    abstract class Visitor
    {
        public abstract void VisitElementA(ElementA elementA);
        public abstract void VisitElementB(ElementB elementB);
    }
}
