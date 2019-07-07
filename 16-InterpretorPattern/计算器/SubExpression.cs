using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    class SubExpression : OperatorExpression
    {
        public SubExpression(Expression left, Expression right)
            : base(left, right)
        {

        }

        public override int interpret()
        {
            return left.interpret() - right.interpret();
        }
    }
}
