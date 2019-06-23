using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VisitorPattern
{
    class ElementManager
    {
        private List<Element> elementList = new List<Element>();

        public void AddElement(Element element)
        {
            elementList.Add(element);
        }

        public void RemoveElement(Element element)
        {
            elementList.Remove(element);
        }

        /// <summary>
        /// 接受
        /// </summary>
        public void Accept(Visitor visitor)
        {
            foreach(Element element in elementList)
            {
                element.Accept(visitor);
            }
        }
    }
}
