using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ObjectAdapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    class Adapter : ITarget
    {
        private Adaptee adaptee = new Adaptee();

        public void Request()
        {
            Console.WriteLine("对象适配器：");
            adaptee.SpecificRequest();
        }
    }
}
