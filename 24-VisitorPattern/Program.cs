using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ElementManager elementManager = new ElementManager();
            elementManager.AddElement(new ElementA());
            elementManager.AddElement(new ElementB());

            VisitorA visitorA = new VisitorA();
            VisitorB visitorB = new VisitorB();

            elementManager.Accept(visitorA);
            elementManager.Accept(visitorB);
        }
    }
}
