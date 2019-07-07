using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    /// <summary>
    /// 叶子
    /// </summary>
    class Leaf : Component
    {
        public Leaf(string name)
            : base(name)
        {

        }

        public override void Add(Component component)
        {
            Console.WriteLine("不能添加到叶子节点！");
        }

        public override void Remove(Component component)
        {
            Console.WriteLine("不能从叶子节点移除！");
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
        }
    }
}
