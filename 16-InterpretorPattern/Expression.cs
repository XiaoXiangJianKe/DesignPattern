using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern
{
    /// <summary>
    /// 抽象表达式
    /// </summary>
    abstract class Expression
    {
        public abstract void Interpret(Context context);
    }
}
