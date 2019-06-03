using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingletonB
    {
        private static readonly SingletonB instance = new SingletonB();
        public static SingletonB Instance
        {
            get
            {
                return instance;
            }
        }

        private SingletonB()
        {

        }

        public void Print()
        {
            Console.WriteLine("SingletonB是饿汉式线程安全单例类");
        }
    }
}
