using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 环境类
    /// </summary>
    class Context
    {
        private Strategy strategy;

        public Strategy Strategy { set { strategy = value; } }

        /// <summary>
        /// 算法
        /// </summary>
        public void Algorithm()
        {
            strategy.Algorithm();
        }
    }
}
