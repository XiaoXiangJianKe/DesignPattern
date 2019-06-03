using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingletonC
    {
        private static SingletonC instance;
        private static readonly object syncObject = new object();
        
        public static SingletonC Instance
        {
            get
            {
                lock(syncObject)//在同一时刻加了锁的那一部分程序，只有一个线程可以进去
                {
                    if(instance == null)
                    {
                        instance = new SingletonC();
                    }
                    return instance;
                }
            }
        }

        private SingletonC()
        {

        }

        public void Print()
        {
            Console.WriteLine("SingletonC是懒汉式线程安全单例类");
        }
    }
}
