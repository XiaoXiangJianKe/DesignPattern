using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    /// <summary>
    /// 具体中介者
    /// </summary>
    class ConcreteMediator : Mediator
    {
        private ColleaguaA colleaguaA;
        private ColleaguaB colleaguaB;

        public ColleaguaA ColleaguaA { set { colleaguaA = value; } }
        public ColleaguaB ColleaguaB { set { colleaguaB = value; } }

        public override void Send(string message, Colleague colleague)
        {
            if (colleague == colleaguaA)
            {
                colleaguaB.Notify(message);
            }
            else
            {
                colleaguaA.Notify(message);
            }
        }
    }
}
