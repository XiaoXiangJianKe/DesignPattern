using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProxyPattern
{
    class Proxy : Subject
    {
        private SubjectA subjectA;

        public override void Request()
        {
            if(subjectA == null)
            {
                subjectA = new SubjectA();
            }
            subjectA.Request();
        }
    }
}
