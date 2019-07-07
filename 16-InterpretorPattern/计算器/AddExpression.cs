using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    /// <summary>
    /// 加法表达式
    /// </summary>
    class AddExpression : OperatorExpression
    {
        public AddExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override int interpret()
        {
            return left.interpret() + right.interpret();
        }
    }
}
