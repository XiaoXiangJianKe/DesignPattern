using AdapterPattern.ClassAdapter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {          
            ITarget target = new Adapter();
            target.Request();
           
            ITarget target1 = new AdapterPattern.ObjectAdapter.Adapter();
            target1.Request();
        }
    }
}
