using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern
{
    /// <summary>
    /// 抽象策略类
    /// </summary>
    abstract class Strategy
    {
        /// <summary>
        /// 算法
        /// </summary>
        public abstract void Algorithm();
    }
}
