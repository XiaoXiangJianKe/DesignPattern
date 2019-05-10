using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    class Receiver
    {
        public void Add()
        {
            Console.WriteLine("添加 "+ DateTime.Now.ToString());
        }

        public void Remove()
        {
            Console.WriteLine("移除 " + DateTime.Now.ToString());
        }

        public void Save()
        {
            Console.WriteLine("保存 " + DateTime.Now.ToString());
        }
    }
}
