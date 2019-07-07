using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            PrototypeA pA1 = new PrototypeA("A");
            PrototypeA pA2 = pA1.Clone() as PrototypeA;
            Console.WriteLine("Cloned:{0}", pA2.Id);

            PrototypeB pB1 = new PrototypeB("B");
            PrototypeB pB2 = pB1.Clone() as PrototypeB;
            Console.WriteLine("Cloned:{0}", pB2.Id);
        }
    }
}
