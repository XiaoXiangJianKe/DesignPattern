using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern
{
    class NonterminalExpression:Expression
    {
        /// <summary>
        /// 非终结符表达式
        /// </summary>
        /// <param name="context"></param>
        public override void Interpret(Context context)
        {
            Console.WriteLine("非终端解释器");
        }
    }
}
