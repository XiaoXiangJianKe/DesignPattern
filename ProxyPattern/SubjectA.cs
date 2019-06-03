using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class SubjectA : Subject
    {
        public override void Request()
        {
            Console.WriteLine("SubjectA");
        }
    }
}
