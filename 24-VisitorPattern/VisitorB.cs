using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class VisitorB : Visitor
    {
        public override void VisitElementA(ElementA elementA)
        {
            Console.WriteLine("{0}被{1}访问", elementA.GetType().Name, this.GetType().Name);
        }

        public override void VisitElementB(ElementB elementB)
        {
            Console.WriteLine("{0}被{1}访问", elementB.GetType().Name, this.GetType().Name);
        }
    }
}
