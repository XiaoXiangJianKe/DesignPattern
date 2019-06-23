using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            SingletonA.Instance.Print();
            SingletonB.Instance.Print();
            SingletonC.Instance.Print();
            SingletonD.Instance.Print();
        }
    }
}
