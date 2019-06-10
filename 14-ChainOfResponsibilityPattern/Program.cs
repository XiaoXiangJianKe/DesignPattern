using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibilityPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Handler hA = new HandlerA();
            Handler hB = new HandlerB();

            hA.SetSuccessor(hB);

            hA.Request(1);
            hA.Request(7);
            hA.Request(13);
            hA.Request(15);
        }
    }
}
