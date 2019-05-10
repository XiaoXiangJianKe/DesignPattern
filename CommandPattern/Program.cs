using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public class ClassA
    {
        public delegate void TestEventHandler();
        public event TestEventHandler TestEvent;

        public virtual void Fun1(TestEventHandler test)
        {
            TestEvent += test;
            TestEvent();
        }
    }

    public class ClassB : ClassA
    {
        public ClassB()
        {
            Fun1(Test);
        }

        public override void Fun1(ClassA.TestEventHandler test)
        {
            base.Fun1(test);
        }

        public void Test()
        {
            Console.WriteLine("测试");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Receiver receiver = new Receiver();
            AddCommand addCommand = new AddCommand(receiver);
            RemoveCommand removeCommand = new RemoveCommand(receiver);
            SaveCommand saveCommand = new SaveCommand(receiver);
            Invoker invoker = new Invoker();

            invoker.SetCommand(addCommand);
            invoker.ExecuteCommand();
            invoker.SetCommand(removeCommand);
            invoker.ExecuteCommand();
            invoker.SetCommand(saveCommand);
            invoker.ExecuteCommand();

            int[,] array = new int[5, 10];
            Console.WriteLine(string.Format("array的行："+array.GetLength(0)));
            Console.WriteLine(string.Format("array的列：" + array.GetLength(1)));
            Console.WriteLine(string.Format("array的元素个数：" + array.Length));

            ClassB classB = new ClassB();
        }
    }
}
