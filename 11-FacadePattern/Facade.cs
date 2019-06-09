using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern
{
    class Facade
    {
        private SubSystemA subSystemA;
        private SubSystemB subSystemB;

        public Facade()
        {
            subSystemA = new SubSystemA();
            subSystemB = new SubSystemB();
        }

        public void OperationA()
        {
            Console.WriteLine("\nOperationA：");
            subSystemA.Operation();
            subSystemB.Operation();
        }

        public void OperationB()
        {
            Console.WriteLine("\nOperationB：");
            subSystemA.Operation();
        }
    }
}
