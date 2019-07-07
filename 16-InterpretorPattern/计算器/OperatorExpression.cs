using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    /// <summary>
    /// 运算符表达式
    /// </summary>
    abstract class OperatorExpression : Expression
    {
        protected Expression left;
        protected Expression right;

        public OperatorExpression(Expression left, Expression right)
        {
            this.left = left;
            this.right = right;
        }
    }
}
