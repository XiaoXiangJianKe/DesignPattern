using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            RefinedAbstraction refinedAbstraction = new RefinedAbstraction();

            Implementor implementorA = new ImplementorA();
            refinedAbstraction.Implementor = implementorA;
            refinedAbstraction.Operation();

            Implementor implementorB = new ImplementorB();
            refinedAbstraction.Implementor = implementorB;
            refinedAbstraction.Operation();
        }
    }
}
