using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BridgePattern
{
    /// <summary>
    /// 具体实现A
    /// </summary>
    class ImplementorA : Implementor
    {
        public override void Operation()
        {
            Console.WriteLine("ImplementorA");
        }
    }
}
