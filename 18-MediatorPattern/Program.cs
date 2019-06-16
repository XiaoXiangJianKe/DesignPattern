using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediatorPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            ConcreteMediator mediator = new ConcreteMediator();
            ColleaguaA colleaguaA = new ColleaguaA(mediator);
            ColleaguaB colleaguaB = new ColleaguaB(mediator);

            mediator.ColleaguaA = colleaguaA;
            mediator.ColleaguaB = colleaguaB;

            colleaguaA.Notify("一起玩游戏啊！");
            colleaguaB.Notify("不了，我还要学习。");
        }
    }
}
