using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    /// <summary>
    /// 计算器
    /// </summary>
    class Calculator
    {
        private Expression expression;
        private Stack<Expression> stackExpression = new Stack<Expression>();

        /// <summary>
        /// 构建抽象语法树
        /// </summary>
        /// <param name="context"></param>
        public void Build(string context)
        {
            for (int i = 0; i < context.Length; i++)
            {
                if(context[i] == '+')
                {
                    Expression left = stackExpression.Pop();
                    Expression right = new ValueExpression(int.Parse(context[++i].ToString()));
                    AddExpression subExpression = new AddExpression(left, right);
                    stackExpression.Push(subExpression);
                }
                else if (context[i] == '-')
                {
                    Expression left = stackExpression.Pop();
                    Expression right = new ValueExpression(int.Parse(context[++i].ToString()));
                    SubExpression subExpression = new SubExpression(left, right);
                    stackExpression.Push(subExpression);
                }
                else
                {
                    ValueExpression valueExpression = new ValueExpression(int.Parse(context[i].ToString()));
                    stackExpression.Push(valueExpression);
                }
            }
            expression = stackExpression.Pop();
        }

        /// <summary>
        /// 计算
        /// </summary>
        /// <returns></returns>
        public int Calculate()
        {
            return expression.interpret();
        }
    }
}
