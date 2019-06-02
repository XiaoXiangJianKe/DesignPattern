using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BuilderPattern
{
    class Product
    {
        private List<string> partList = new List<string>();

        public void Add(string part)
        {
            partList.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("Product Parts:");
            foreach(string part in partList)
            {
                Console.WriteLine(part);
            }
        }
    }
}
