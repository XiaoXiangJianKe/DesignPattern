using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class ColleaguaA : Colleague
    {
        public ColleaguaA(Mediator mediator)
            : base(mediator)
        {

        }

        public void Send(string message)
        {
            mediator.Send(message, this);
        }

        /// <summary>
        /// 通知
        /// </summary>
        /// <param name="message"></param>
        public void Notify(string message)
        {
            Console.WriteLine("ColleaguaA 收到消息：" + message);
        }
    }
}
