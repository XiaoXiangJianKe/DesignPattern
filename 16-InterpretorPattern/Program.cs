using InterpretorPattern.计算器;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern
{
    class Program
    {
        /// <summary>
        /// 构建表示该文法定义的语言中一个特定的句子的抽象语法树
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Context context = new Context();
            List<Expression> list = new List<Expression>();
            list.Add(new TerminalExpression());
            list.Add(new NonterminalExpression());
            list.Add(new TerminalExpression());
            list.Add(new TerminalExpression());

            foreach(Expression expression in list)
            {
                expression.Interpret(context);
            }

            string context1 = "1+2+3-4+1";
            Calculator calculator = new Calculator();
            calculator.Build(context1);
            int result = calculator.Calculate();
            Console.WriteLine("{0}={1}", context1, result);
        }
    }
}
