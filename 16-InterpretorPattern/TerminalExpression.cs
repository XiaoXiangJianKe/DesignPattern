using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern
{
    /// <summary>
    /// 终结符表达式
    /// </summary>
    class TerminalExpression : Expression
    {
        public override void Interpret(Context context)
        {
            Console.WriteLine("终端解释器");
        }
    }
}
