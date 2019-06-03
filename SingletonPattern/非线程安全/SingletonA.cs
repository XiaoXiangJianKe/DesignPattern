using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    class SingletonA
    {
        private static SingletonA instance;
        public static SingletonA Instance
        {
            get
            {
                if(instance==null)
                {
                    instance = new SingletonA();
                }
                return instance;
            }
        }

        private SingletonA()
        {

        }
        
        public void Print()
        {
            Console.WriteLine("SingletonA是非线程安全单例类");
        }
    }
}
