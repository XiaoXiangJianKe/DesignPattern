using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingletonD
    {
        private static SingletonD instance;
        private static readonly object syncObject = new object();

        public static SingletonD Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncObject)//在同一时刻加了锁的那一部分程序，只有一个线程可以进去
                    {
                        if (instance == null)
                        {
                            instance = new SingletonD();
                        }                    
                    }
                }
                return instance;
            }
        }

        private SingletonD()
        {

        }

        public void Print()
        {
            Console.WriteLine("SingletonD是懒汉式双重锁定线程安全单例类");
        }
    }
}
