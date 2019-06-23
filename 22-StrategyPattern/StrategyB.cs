using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    class StrategyB : Strategy
    {
        /// <summary>
        /// 算法
        /// </summary>
        public override void Algorithm()
        {
            Console.WriteLine("StrategyB.Algorithm");
        }
    }
}
