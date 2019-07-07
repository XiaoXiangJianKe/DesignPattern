using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterpretorPattern.计算器
{
    /// <summary>
    /// 值表达式
    /// </summary>
    class ValueExpression : Expression
    {
        private int value;

        public ValueExpression(int value)
        {
            this.value = value;
        }

        public override int interpret()
        {
            return this.value;
        }
    }
}
