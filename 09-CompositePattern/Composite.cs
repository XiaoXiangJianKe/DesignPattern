using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompositePattern
{
    class Composite : Component
    {
        private List<Component> componentList = new List<Component>();

        public Composite(string name)
            : base(name)
        {

        }

        public override void Add(Component component)
        {
            if (!componentList.Contains(component))
                componentList.Add(component);
        }

        public override void Remove(Component component)
        {
            if (!componentList.Contains(component))
                componentList.Remove(component);
        }

        public override void Display(int depth)
        {
            Console.WriteLine(new string('-', depth) + name);
            foreach (Component component in componentList)
            {
                component.Display(depth + 2);
            }
        }
    }
}
