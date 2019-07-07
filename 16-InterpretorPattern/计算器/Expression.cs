using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    abstract class Expression
    {
        /// <summary>
        /// 解释
        /// </summary>
        /// <returns></returns>
        public abstract int interpret();
    }
}
