using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandPattern
{
    public abstract class BaseClass
    {
        public abstract void Fun1();
    }
    public class ClassA : BaseClass
    {

        public override void Fun1()
        {
            Console.WriteLine("ClassA");
        }
    }

    public class ClassB : ClassA
    {
        public override void Fun1()
        {
            Console.WriteLine("ClassB");
        }

        public void Fun2()
        {
            Console.WriteLine("ClassB");
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

           // int[,] array = new int[5, 10];
           // Console.WriteLine(string.Format("array的行：" + array.GetLength(0)));
           // Console.WriteLine(string.Format("array的列：" + array.GetLength(1)));
           // Console.WriteLine(string.Format("array的元素个数：" + array.Length));

           //BaseClass baseClass = new ClassA();
           //baseClass.Fun1();

           //BaseClass baseClass1 = new ClassB();
           //baseClass1.Fun1();
        }
    }
}
