using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            Composite root = new Composite("模型库");
            Composite robot = new Composite("机器人");
            robot.Add(new Leaf("机器人1"));
            robot.Add(new Leaf("机器人2"));
            root.Add(new Leaf("车床"));
            root.Add(new Leaf("加工中心"));
            root.Add(robot);
            root.Add(new Leaf("立库"));

            root.Display(1);
        }
    }
}
