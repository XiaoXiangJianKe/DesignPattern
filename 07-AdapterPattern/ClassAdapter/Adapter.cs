using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern.ClassAdapter
{
    /// <summary>
    /// 适配器
    /// </summary>
    class Adapter : Adaptee, ITarget
    {
        public void Request()
        {
            Console.WriteLine("类适配器：");
            SpecificRequest();
        }
    }
}
