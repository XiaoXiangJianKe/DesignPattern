using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TemplateMethodPattern
{
    abstract class AbstactClass
    {
        /// <summary>
        /// 模板方法
        /// </summary>
        public void TemplateMethod()
        {
            Operation1();
            Operation2();
        }

        protected abstract void Operation1();
        protected abstract void Operation2();
    }
}
